using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestPing
{
    public partial class ConfigureGamesListForm : Form
    {
        List<Game> gameList = new List<Game>();
        private static AddGame addGame;
        private static AddRegion addRegion;
        private static AddServer addServer;

        public ConfigureGamesListForm()
        {
            InitializeComponent();
        }

        //private void selectFileButton_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog ofd = new OpenFileDialog()
        //    {
        //        Filter = "XML Files (*.xml)|*xml",
        //        Title = "Select XML File"
        //    };

        //    if (ofd.ShowDialog() == DialogResult.OK)
        //    {
        //        selectedFileLabel.Text = ofd.SafeFileName;

        //        string s = ofd.FileName;
        //        XMLManipulation x = new XMLManipulation();
        //        gameList = x.ReadXmlFile(s);

        //        clearOVLs();

        //        foreach(Game game in gameList)
        //        {
        //            gamesOLV.AddObject(game);
        //        }
        //        SetupActionButtons(gamesListEditColumn, "Edit");
        //        SetupActionButtons(gamesListDeleteColumn, "Delete");
        //        gamesOLV.RebuildColumns();
        //    }
        //}

        private void clearOVLs()
        {
            serversOLV.ClearObjects();
        }

        //private void regionsOLV_SelectionChanged(object sender, EventArgs e)
        //{
        //    serversOLV.ClearObjects();

        //    try
        //    {
        //        Game selectedGame = (Game)gamesOLV.SelectedObject;
        //        Region selectedRegion = (Region)regionsOLV.SelectedObject;

        //        List<Server> serverList = gameList.Find(x => x.Name == selectedGame.Name).Regions.Find(x => x.Name == selectedRegion.Name).Servers;

        //        foreach (Server server in serverList)
        //        {
        //            serversOLV.AddObject(server);
        //        }
        //    }
        //    catch { }
        //}

        private void addGameButton_Click(object sender, EventArgs e)
        {
            if (addGame == null || addGame.IsDisposed)
                addGame = new AddGame();

            addGame.Show();
            addGame.VisibleChanged += addGameButtonFormClosed;
            addGame.Focus();
        }

        private void addGameButtonFormClosed(object sender, EventArgs e)
        {
            AddGame addGame = (AddGame)sender;
            if (!addGame.Visible)
            {
                Game newGame = new Game();
                newGame.Name = addGame.returnGame;
                gameList.Add(newGame);
                // gamesOLV.AddObject(newGame);
            }
            addGame.Dispose();
        }

        //private void addRegionButton_Click(object sender, EventArgs e)
        //{
        //    if (gamesOLV.SelectedItem != null)
        //    {
        //        if (addRegion == null || addRegion.IsDisposed)
        //            addRegion = new AddRegion();

        //        addRegion.Show();
        //        addRegion.VisibleChanged += addRegionButtonFormClosed;
        //        addRegion.Focus();
        //    }
        //    else
        //    {
        //        // TODO: tell user to pick a game
        //    }
        //}

        //private void addRegionButtonFormClosed(object sender, EventArgs e)
        //{

        //    Game selectedGame = (Game)gamesOLV.SelectedObject;

        //    AddRegion addRegion = (AddRegion)sender;
        //    if (!addRegion.Visible)
        //    {
        //        Region newRegion = new Region();
        //        newRegion.Name = addRegion.returnRegion;
        //        gameList.Find(x => x.Name == selectedGame.Name).Regions.Add(newRegion);
        //        regionsOLV.AddObject(newRegion);
        //    }
        //    addRegion.Dispose();
        //}

        private void addServerButton_Click(object sender, EventArgs e)
        {
            if (regionListComboBox.SelectedItem != null)
            {
                if (addServer == null || addServer.IsDisposed)
                    addServer = new AddServer();

                addServer.Show();
                addServer.VisibleChanged += addServerButtonFormClosed;
                addServer.Focus();
            }
            else
            {
                // tell user to select a region
            }
        }

        private void addServerButtonFormClosed(object sender, EventArgs e)
        {
            string selectedGame = gamesListComboBox.Text;
            string selectedRegion = regionListComboBox.Text;

            AddServer addServer = (AddServer)sender;
            if (!addServer.Visible)
            {
                Server newServer = new Server();
                newServer.Name = addServer.returnServerName;
                newServer.Ip = addServer.returnIPAddress;
                gameList.Find(x => x.Name == selectedGame).Regions.Find(y => y.Name == selectedRegion).Servers.Add(newServer);
                serversOLV.AddObject(newServer);
            }
            addServer.Dispose();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "XML Files (*.xml)|*xml",
                DefaultExt = "xml",
                Title = "Save XML File"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string saveLocation = sfd.FileName;
                XMLManipulation xmlM = new XMLManipulation();
                xmlM.WriteXMLFile(saveLocation, gameList);
            }
            this.Dispose();
        }

        private void SetupActionButtons(OLVColumn column, string icon)
        {
            column.ImageGetter = delegate (object rowObject)
            {
                switch (icon)
                {
                    case "Edit":
                        return Properties.Resources.YellowDot;
                    case "Delete":
                        return Properties.Resources.RedDot;
                }

                return 0;
            };
        }

        private void ConfigureGamesListForm_Load(object sender, EventArgs e)
        {
            populateForm(Properties.Resources.gamesList, nameof(Properties.Resources.gamesList));
        }

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
            regionListComboBox.Text = "Region";

            gamesListComboBox.Enabled = true;
            fileLabel.Text = gamesXMLFileName;
        }

        private void gamesListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetForm();
            string selectedGame = gamesListComboBox.Text;
            List<Region> regionList = gameList.Find(x => x.Name == selectedGame).Regions;
            foreach (Region region in regionList)
            {
                regionListComboBox.Items.Add(region.Name);
            }
            regionListComboBox.Sorted = true;
        }

        private void regionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            serversOLV.ClearObjects();

            try
            {
                string selectedGame = gamesListComboBox.Text;
                string selectedRegion = regionListComboBox.Text;

                List<Server> serverList = gameList.Find(x => x.Name == selectedGame).Regions.Find(x => x.Name == selectedRegion).Servers;

                foreach (Server server in serverList)
                {
                    serversOLV.AddObject(server);
                }
            }
            catch { }
        }

        private void ResetForm()
        {
            regionListComboBox.Text = "Region";
            serversOLV.ClearObjects();
        }
    }
}
