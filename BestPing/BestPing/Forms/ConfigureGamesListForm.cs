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

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "XML Files (*.xml)|*xml",
                Title = "Select XML File"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                selectedFileLabel.Text = ofd.SafeFileName;

                string s = ofd.FileName;
                XMLManipulation x = new XMLManipulation();
                gameList = x.ReadXmlFile(s);

                clearOVLs();

                foreach(Game game in gameList)
                {
                    gamesOLV.AddObject(game);
                }
            }
        }

        private void clearOVLs()
        {
            gamesOLV.ClearObjects();
            regionsOLV.ClearObjects();
            serversOLV.ClearObjects();
        }

        private void gamesOLV_SelectionChanged(object sender, EventArgs e)
        {
            regionsOLV.ClearObjects();
            serversOLV.ClearObjects();

            try
            {
                // get selected row, use it's name to find the servers in gameList, and add to regionsOVL
                Game selectedGame = (Game) gamesOLV.SelectedObject;
 
                List<Region> regionList = gameList.Find(x => x.Name == selectedGame.Name).Regions;

                foreach (Region region in regionList)
                {
                    regionsOLV.AddObject(region);
                }
            }
            catch { }
        }

        private void regionsOLV_SelectionChanged(object sender, EventArgs e)
        {
            serversOLV.ClearObjects();

            try
            {
                Game selectedGame = (Game)gamesOLV.SelectedObject;
                Region selectedRegion = (Region)regionsOLV.SelectedObject;

                List<Server> serverList = gameList.Find(x => x.Name == selectedGame.Name).Regions.Find(x => x.Name == selectedRegion.Name).Servers;

                foreach (Server server in serverList)
                {
                    serversOLV.AddObject(server);
                }
            }
            catch { }
        }

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
                gamesOLV.AddObject(newGame);
            }
            addGame.Dispose();
        }

        private void addRegionButton_Click(object sender, EventArgs e)
        {
            if (gamesOLV.SelectedItem != null)
            {
                if (addRegion == null || addRegion.IsDisposed)
                    addRegion = new AddRegion();

                addRegion.Show();
                addRegion.VisibleChanged += addRegionButtonFormClosed;
                addRegion.Focus();
            }
            else
            {
                // TODO: tell user to pick a game
            }
        }

        private void addRegionButtonFormClosed(object sender, EventArgs e)
        {

            Game selectedGame = (Game)gamesOLV.SelectedObject;

            AddRegion addRegion = (AddRegion)sender;
            if (!addRegion.Visible)
            {
                Region newRegion = new Region();
                newRegion.Name = addRegion.returnRegion;
                gameList.Find(x => x.Name == selectedGame.Name).Regions.Add(newRegion);
                regionsOLV.AddObject(newRegion);
            }
            addRegion.Dispose();
        }

        private void addServerButton_Click(object sender, EventArgs e)
        {
            if(regionsOLV.SelectedItem != null)
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
            Game selectedGame = (Game)gamesOLV.SelectedObject;
            Region selectedRegion = (Region)regionsOLV.SelectedObject;

            AddServer addServer = (AddServer)sender;
            if(!addServer.Visible)
            {
                Server newServer = new Server();
                newServer.Name = addServer.returnServerName;
                newServer.Ip = addServer.returnIPAddress;
                gameList.Find(x => x.Name == selectedGame.Name).Regions.Find(y => y.Name == selectedRegion.Name).Servers.Add(newServer);
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
    }
}
