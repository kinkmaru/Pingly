using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BestPing
{
    public partial class Form1 : Form
    {
        List<Game> gg = new List<Game>();
        int progressSet;

        public Form1()
        {
            InitializeComponent();
            progressSet = label3.Left;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetForm();
            string selectedGame = comboBox1.Text;
            List<Region> r = gg.Find(x => x.Name == selectedGame).Regions;
            foreach(Region region in r)
            {
                listView1.Items.Add(region.Name);
            }
            comboBox2.Enabled = true;
            listView1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisableAll();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            objectListView1.ClearObjects();
            label3.Left = progressSet;
            label3.Text = "0 / 0";

            string selectedServer = listView1.SelectedItems[0].Text;
            List<Server> serverList = gg.Find(x => x.Name == comboBox1.Text).Regions.Find(x => x.Name == selectedServer).Servers;

            int timesToPing;
            if (numericUpDown1.Enabled)
                timesToPing = Convert.ToInt32(numericUpDown1.Value);
            else
                timesToPing = Convert.ToInt32(new String(comboBox2.Text.Where(Char.IsDigit).ToArray()));

            Tuple<List<Server>, int> serverListItems = Tuple.Create(serverList, timesToPing);

            backgroundWorker1.RunWorkerAsync(argument: serverListItems);

            Status.ImageGetter = delegate (object rowObject)
            {
                Server s = (Server)rowObject;
                int p = Convert.ToInt32(s.Ping);
                if (p < 50)
                    return Properties.Resources.GreenDot;
                if (p > 50 && p < 101)
                    return Properties.Resources.YellowDot;
                if (p > 100 && p < 201)
                    return Properties.Resources.OrangeDot;

                return Properties.Resources.RedDot;
            };

            objectListView1.RebuildColumns();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Custom")
                numericUpDown1.Enabled = true;
            else
                numericUpDown1.Enabled = false;
        }

        private void ResetForm()
        {
            objectListView1.ClearObjects();
            listView1.Items.Clear();
            comboBox2.SelectedIndex = 0;
        }

        private void DisableAll()
        {
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            listView1.Enabled = false;
            label3.Left = progressSet;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "XML Files (*.xml)|*xml",
                Multiselect = true,
                Title = "Select XML File"
            };

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                label5.Text = ofd.SafeFileName;

                string s = ofd.FileName;
                XMLManipulation x = new XMLManipulation();
                gg = x.ReadXmlFile(s);

                comboBox1.Items.Clear();
                foreach (Game g in gg)
                {
                    comboBox1.Items.Add(g.Name);
                }

                comboBox1.Sorted = true;
                comboBox1.Text = "<Options>";

                DisableAll();
                comboBox1.Enabled = true;
                ResetForm();
            }
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Tuple<List<Server>, int> list = (Tuple<List<Server>, int>) e.Argument;
            List<Server> serverList = list.Item1;
            int timesToPing = list.Item2;

            Pinging ping = new Pinging();

            double totalServers = serverList.Count();
            double pingProgressionCount = 0;

            foreach (Server server in serverList)
            {
                server.Ping = ping.getAveragePing(server, timesToPing);
                int pingCompare = Convert.ToInt32((server.Ping));

                pingProgressionCount++;
                int value = Convert.ToInt32(Math.Floor(((pingProgressionCount / totalServers) * 100)));

                Tuple<double, double> progressTextItems = Tuple.Create(pingProgressionCount, totalServers);

                backgroundWorker1.ReportProgress(value, progressTextItems);
                objectListView1.AddObject(server);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;

            Tuple<double, double> list = (Tuple<double, double>) e.UserState;
            label3.Text = list.Item1 + "/" + list.Item2;
            label3.Left += Convert.ToInt32(progressBar1.Size.Width / list.Item2);
            label3.Refresh();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
        }
    }
}
