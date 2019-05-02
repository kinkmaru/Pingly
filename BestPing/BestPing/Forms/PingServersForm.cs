﻿using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BestPing
{
    public partial class PingServersForm : Form
    {
        List<Game> gameList = new List<Game>();

        public PingServersForm()
        {
            InitializeComponent();
        }

        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Tuple<List<Server>, int> list = (Tuple<List<Server>, int>) e.Argument;
            List<Server> serverList = list.Item1;
            int timesToPing = list.Item2;

            Pinging ping = new Pinging();

            double totalServers = serverList.Count();
            double pingProgressionCount = 0;

            foreach (Server server in serverList)
            {
                server.Ping = ping.GetAveragePing(server, timesToPing);
                int pingCompare = Convert.ToInt32((server.Ping));

                pingProgressionCount++;
                int progressValue = Convert.ToInt32(Math.Floor(((pingProgressionCount / totalServers) * 100)));

                Tuple<double, double> progressTextItems = Tuple.Create(pingProgressionCount, totalServers);

                backgroundWorker.ReportProgress(progressValue, progressTextItems);
                listServersOLV.AddObject(server);
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;

            Tuple<double, double> list = (Tuple<double, double>) e.UserState;
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
        }

        private void DisableAll()
        {
            gamesListComboBox.Enabled = false;
            pingPrecisionComboBox.Enabled = false;
            regionsListView.Enabled = false;
        }

        private void gamesListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetForm();
            string selectedGame = gamesListComboBox.Text;
            List<Region> regionList = gameList.Find(x => x.Name == selectedGame).Regions;
            foreach(Region region in regionList)
            {
                regionsListView.Items.Add(region.Name);
            }
            pingPrecisionComboBox.Enabled = true;
            regionsListView.Enabled = true;
        }

        private void PingServersForm_Load(object sender, EventArgs e)
        {
            populateForm(Properties.Resources.gamesList, nameof(Properties.Resources.gamesList));
        }

        private void regionsListView_MouseClick(object sender, MouseEventArgs e)
        {
            listServersOLV.ClearObjects();

            string selectedServer = regionsListView.SelectedItems[0].Text;
            List<Server> serverList = gameList.Find(x => x.Name == gamesListComboBox.Text).Regions.Find(y => y.Name == selectedServer).Servers;

            // int timesToPing = Convert.ToInt32(new String(pingPrecisionComboBox.Text.Where(Char.IsDigit).ToArray()));
            int timesToPing;

            switch (pingPrecisionComboBox.Text)
            {
                case "Fast":
                    timesToPing = 1;
                    break;
                case "Moderate":
                    timesToPing = 5;
                    break;
                case "Thorough":
                    timesToPing = 10;
                    break;
                default:
                    timesToPing = 1;
                    break;
            }

            Tuple<List<Server>, int> serverListItems = Tuple.Create(serverList, timesToPing);

            backgroundWorker.RunWorkerAsync(argument: serverListItems);

            Status.ImageGetter = delegate (object rowObject)
            {
                Server server = (Server)rowObject;
                int p = Convert.ToInt32(server.Ping);
                if (p < 50)
                    return Properties.Resources.GreenDot;
                if (p > 50 && p < 101)
                    return Properties.Resources.YellowDot;
                if (p > 100 && p < 201)
                    return Properties.Resources.OrangeDot;

                return Properties.Resources.RedDot;
            };

            listServersOLV.RebuildColumns();
        }

        private void ResetForm()
        {
            listServersOLV.ClearObjects();
            regionsListView.Items.Clear();
            pingPrecisionComboBox.SelectedIndex = 0;
        }

        //private void selectGameFileButton_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog ofd = new OpenFileDialog()
        //    {
        //        Filter = "XML Files (*.xml)|*xml",
        //        Multiselect = true,
        //        Title = "Select XML File"
        //    };

        //    if (ofd.ShowDialog() == DialogResult.OK)
        //    {
        //        fileLabel.Text = ofd.SafeFileName;

        //        string gameListLocation = ofd.FileName;
        //        XMLManipulation xmlRead = new XMLManipulation();
        //        gameList = xmlRead.ReadXmlFile(gameListLocation);

        //        gamesListComboBox.Items.Clear();
        //        foreach (Game game in gameList)
        //        {
        //            gamesListComboBox.Items.Add(game.Name);
        //        }

        //        gamesListComboBox.Sorted = true;
        //        gamesListComboBox.Text = "Game Name";

        //        DisableAll();
        //        gamesListComboBox.Enabled = true;
        //        ResetForm();
        //    }
        //}

        private void populateForm(string gamesXMLFile, string gamesXMLFileName)
        {
            XMLManipulation xmlRead = new XMLManipulation();
            gameList = xmlRead.ReadXmlFile(gamesXMLFile);

            gamesListComboBox.Items.Clear();
            foreach (Game game in gameList)
            {
                gamesListComboBox.Items.Add(game.Name);
            }

            gamesListComboBox.Sorted = true;
            gamesListComboBox.Text = "Game Name";

            DisableAll();
            gamesListComboBox.Enabled = true;
            fileLabel.Text = gamesXMLFileName;
            ResetForm();
        }
    }
}
