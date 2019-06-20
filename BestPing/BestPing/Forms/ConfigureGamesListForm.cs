using BestPing.Forms;
using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestPing
{
    public partial class ConfigureGamesListForm : Form
    {
        List<Game> gameList = new List<Game>();
        private static DeleteItemForm deleteItemForm;

        private bool editingGameName;
        private string gameBeingEdited;

        private bool editingRegionName;
        private string regionBeingEdited;

        public ConfigureGamesListForm()
        {
            InitializeComponent();
        }

        private void ConfigureGamesListForm_Load(object sender, EventArgs e)
        {
            string gamesList = "..\\..\\gamesList.xml";
            PopulateForm(gamesList, Path.GetFileName(gamesList));
        }

        private void PopulateForm(string gamesXMLFile, string gamesXMLFileName)
        {
            XMLManipulation xmlRead = new XMLManipulation();
            gameList = xmlRead.ReadXmlFile(gamesXMLFile);

            gamesListComboBox.Items.Clear();
            foreach (Game game in gameList)
            {
                gamesListComboBox.Items.Add(game.Name);
            }

            gamesListComboBox.Sorted = true;

            ResetForm();
            fileLabel.Text = "Edit > " + gamesXMLFileName;
        }

        private void ResetForm()
        {
            addGameButton.ImageIndex = 0;
            editGameButton.Enabled = false;
            deleteGameButton.Enabled = false;

            regionListComboBox.Items.Clear();
            regionListComboBox.Text = "";
            regionListComboBox.Enabled = false;
            //regionsListLabel.Enabled = false;
            regionsListLabel.ForeColor = Color.FromArgb(0, 92, 101);
            //addRegionButton.Enabled = false;
            addRegionButton.ImageIndex = 0;
            editRegionButton.Enabled = false;
            deleteRegionButton.Enabled = false;

            //serversListLabel.Enabled = false;
            serversListLabel.ForeColor = Color.FromArgb(0, 92, 101);
            addServerButton.Enabled = false;
            addServerButton.Visible = true;
            serversOLV.ClearObjects();
            serversOLV.Enabled = false;
            deleteServerButton.Enabled = false;
            deleteServerButton.Visible = false;
        }

        // GAME FUNCTIONS
        private void gamesListComboBoxSearchForGame(object sender, EventArgs e)
        {
            if (!editingGameName)
            {
                // If searched game exists, populate regions combobox and enable appropriate action buttons
                if (gamesListComboBox.Items.Contains(gamesListComboBox.Text))
                {
                    ResetForm();
                    string selectedGame = gamesListComboBox.Text;
                    List<Region> regionList = gameList.Find(x => x.Name == selectedGame).Regions;
                    foreach (Region region in regionList)
                    {
                        regionListComboBox.Items.Add(region.Name);
                    }
                    editGameButton.Enabled = true;
                    deleteGameButton.Enabled = true;
                    //addGameButton.ImageIndex = 0;
                    //addGameButton.Enabled = false;

                    regionListComboBox.Sorted = true;
                    regionListComboBox.Enabled = true;
                    //regionsListLabel.Enabled = true;
                    regionsListLabel.ForeColor = Color.FromArgb(0, 151, 167);
                }

                // Can't add a game with no text - diable add button
                else if (gamesListComboBox.Text == "")
                {
                    //addGameButton.Enabled = false;
                    addGameButton.ImageIndex = 0;
                }

                // Reset form under any other conditions
                else
                {
                    ResetForm();
                    //addGameButton.Enabled = true;
                    addGameButton.ImageIndex = 1;
                }
            }
        }

        private void addGameButton_Click(object sender, EventArgs e)
        {
            if(addGameButton.ImageIndex != 0)
            {
                // Add new game to gamelist and game combobox
                Game newGame = new Game();
                newGame.Name = gamesListComboBox.Text;
                gameList.Add(newGame);
                gamesListComboBox.Items.Add(newGame.Name);

                // Make changes to form suitable to having a game selected
                gamesListComboBoxSearchForGame(gamesListComboBox, e);
            }
        }
        private void addGameButton_MouseEnter(object sender, EventArgs e)
        {
            if (addGameButton.ImageIndex != 0)
                addGameButton.ImageIndex = 2;
        }
        private void addGameButton_MouseLeave(object sender, EventArgs e)
        {
            if (gamesListComboBox.Text == "" || gamesListComboBox.Items.Contains(gamesListComboBox.Text))
                addGameButton.ImageIndex = 0;
            else
                addGameButton.ImageIndex = 1;
        }

        private void editGameButton_Click(object sender, EventArgs e)
        {
            // If game matches an existing one, enable editing
            if (gamesListComboBox.Items.Contains(gamesListComboBox.Text))
            {
                gamesListComboBox.Focus();
                editingGameName = true;
                gameBeingEdited = gamesListComboBox.Text;
            }

            // Proceed with editing
            else
            {
                // find existing game based on given combobox text
                Game currentGame = gameList.Find(x => x.Name == gameBeingEdited);

                // remove existing game from the combobox items list and game list
                gamesListComboBox.Items.Remove(currentGame.Name);
                gameList.Remove(currentGame);

                // Override the existing game name and reenter into combo items list and game list
                currentGame.Name = gamesListComboBox.Text;
                gameList.Add(currentGame);
                gamesListComboBox.Items.Add(currentGame.Name);

                // set the combobox to changed name combobox list index
                int newIndex = gamesListComboBox.Items.IndexOf(gamesListComboBox.Text);
                gamesListComboBox.SelectedIndex = newIndex;

                editingGameName = false;
            }
        }

        private void deleteGameButton_Click(object sender, EventArgs e)
        {
            if (deleteItemForm == null || deleteItemForm.IsDisposed)
                deleteItemForm = new DeleteItemForm(gamesListComboBox.Text);

            deleteItemForm.Show();
            deleteItemForm.VisibleChanged += deleteGameFormClosed;
            deleteItemForm.Focus();
        }
        private void deleteGameFormClosed(object sender, EventArgs e)
        {
            if (!deleteItemForm.Visible)
            {
                string deletedGame = deleteItemForm.itemToDelete;

                Game game = gameList.Find(x => x.Name == deletedGame);
                gameList.Remove(game);
                gamesListComboBox.Items.Remove(deletedGame);

                ResetForm();
                gamesListComboBox.Text = "";

                deleteItemForm.Dispose();
            }
        }

        // REGION FUNCTIONS
        private void regionListComboBoxSearchForRegion(object sender, EventArgs e)
        {
            if(!editingRegionName)
            {
            serversOLV.ClearObjects();

                // If searched region exists, populate serversOLV and enable appropriate action buttons
                if (regionListComboBox.Items.Contains(regionListComboBox.Text))
                {
                    string selectedGame = gamesListComboBox.Text;
                    string selectedRegion = regionListComboBox.Text;
                    List<Server> serverList = gameList.Find(x => x.Name == selectedGame).Regions.Find(x => x.Name == selectedRegion).Servers;
                    foreach (Server server in serverList)
                    {
                        serversOLV.AddObject(server);
                    }

                    editRegionButton.Enabled = true;
                    deleteRegionButton.Enabled = true;
                    //addRegionButton.Enabled = false;
                    addRegionButton.ImageIndex = 0;

                    //serversListLabel.Enabled = true;
                    serversListLabel.ForeColor = Color.FromArgb(0, 151, 167);

                    addServerButton.Enabled = true;
                    serversOLV.Enabled = true;
                }

                // Can't add a region with no text - disable add button
                else if (regionListComboBox.Text == "")
                    addRegionButton.ImageIndex = 0;
                    //addRegionButton.Enabled = false;

                // Reset server/region functions under any other conditions
                else
                {
                    editRegionButton.Enabled = false;
                    deleteRegionButton.Enabled = false;
                    //addRegionButton.Enabled = true;
                    addRegionButton.ImageIndex = 1;

                    // serversListLabel.Enabled = false;
                    serversListLabel.ForeColor = Color.FromArgb(0, 92, 101);

                    addServerButton.Enabled = false;
                    serversOLV.ClearObjects();
                }
            }

        }

        private void addRegionButton_Click(object sender, EventArgs e)
        {
            if(addRegionButton.ImageIndex != 0)
            {
                // Add new region to gamelist and region combobox
                Region newRegion = new Region();
                newRegion.Name = regionListComboBox.Text;
                gameList.Find(x => x.Name == gamesListComboBox.Text).Regions.Add(newRegion);
                regionListComboBox.Items.Add(newRegion.Name);

                // Mage changes to form suitable to having a region selected
                regionListComboBoxSearchForRegion(sender, e);
            }
        }
        private void addRegionButton_MouseEnter(object sender, EventArgs e)
        {
            if (addRegionButton.ImageIndex != 0)
                addRegionButton.ImageIndex = 2;
        }
        private void addRegionButton_MouseLeave(object sender, EventArgs e)
        {
            if (regionListComboBox.Text == "" || regionListComboBox.Items.Contains(regionListComboBox.Text))
                addRegionButton.ImageIndex = 0;
            else
                addRegionButton.ImageIndex = 1;
        }

        private void editRegionButton_Click(object sender, EventArgs e)
        {
            // If region matches an existing one, enable editing
            if (regionListComboBox.Items.Contains(regionListComboBox.Text))
            {
                regionListComboBox.Focus();
                editingRegionName = true;
                regionBeingEdited = regionListComboBox.Text;
            }

            // Proceed with editing
            else
            {
                // find existing region based on given game and region combobox text
                Game regionsGame = gameList.Find(x => x.Name == gamesListComboBox.Text);
                Region currentRegion = regionsGame.Regions.Find(x => x.Name == regionBeingEdited);

                // remove existing region from the region combobox items list and gameList
                regionListComboBox.Items.Remove(currentRegion.Name);
                gameList.Find(x => x == regionsGame).Regions.Remove(currentRegion);

                // Override the existing game name and re-enter into combo items list and game list
                currentRegion.Name = regionListComboBox.Text;
                gameList.Find(x => x == regionsGame).Regions.Add(currentRegion);
                regionListComboBox.Items.Add(currentRegion.Name);

                // set the combobox to changed name combobox list index
                int newIndex = regionListComboBox.Items.IndexOf(regionListComboBox.Text);
                regionListComboBox.SelectedIndex = newIndex;

                editingRegionName = false;
            }
        }

        private void deleteRegionButton_Click(object sender, EventArgs e)
        {
            if (deleteItemForm == null || deleteItemForm.IsDisposed)
                deleteItemForm = new DeleteItemForm(regionListComboBox.Text);

            deleteItemForm.Show();
            deleteItemForm.VisibleChanged += deleteRegionFormClosed;
            deleteItemForm.Focus();
        }
        private void deleteRegionFormClosed(object sender, EventArgs e)
        {
            if (!deleteItemForm.Visible)
            {
                string deletedRegion = deleteItemForm.itemToDelete;

                Region region = gameList.Find(x => x.Name == gamesListComboBox.Text).Regions.Find(x => x.Name == deletedRegion);
                gameList.Find(x => x.Name == gamesListComboBox.Text).Regions.Remove(region);
                regionListComboBox.Items.Remove(deletedRegion);

                regionListComboBox.Text = "";
                addServerButton.Enabled = false;
                serversOLV.ClearObjects();
                serversOLV.Enabled = false;
                serversListLabel.Enabled = false;

                deleteItemForm.Dispose();
            }
        }

        // SERVER FUNCTIONS
        private void addServerButton_Click(object sender, EventArgs e)
        {
            // Add a new server to the servers object list and gameList
            // By adding the new server to both lists, the CellEditFinished of the ObjectListView will automatically modify the server list item
            Server server = new Server();
            serversOLV.AddObject(server);
            gameList.Find(x => x.Name == gamesListComboBox.Text).Regions.Find(x => x.Name == regionListComboBox.Text).Servers.Add(server);

            // Scroll the listview to the top using EnsureVisible so the user sees the new server added
            serversOLV.EnsureVisible(0);

            // Start the edit process on the first cell of the newly formed object
            serversOLV.EditSubItem((OLVListItem)serversOLV.Items[0], 0);
        }

        private void serversOLV_CellEditStarting(object sender, CellEditEventArgs e)
        {
            // We clear the selecteditem to allow cell decoration changes to appear immediately after editing
            serversOLV.SelectedItems.Clear();
        }

        private void serversOLV_CellEditFinishing(object sender, CellEditEventArgs e)
        {
            // If a cell is left empty after editing, cancel the cell edit to refute the change
            if (e.NewValue.ToString() == "")
            {
                e.Cancel = true;

                // Create a red border and apply it to the edited cell
                CellBorderDecoration standardDecoration = new CellBorderDecoration();
                standardDecoration.BorderPen = new Pen(Color.Red);
                standardDecoration.FillBrush = null;
                standardDecoration.BoundsPadding = Size.Empty;
                standardDecoration.CornerRounding = 0;

                e.ListViewItem.GetSubItem(e.SubItemIndex).Decoration = standardDecoration;

                // Display a tooltip under the edited cell that a cell cannot be empty
                ToolTip toolTip = new ToolTip();
                Rectangle cellBounds = serversOLV.CellEditor.Bounds;
                toolTip.Show("Cells cannot be empty", serversOLV, cellBounds.X, cellBounds.Y + cellBounds.Height, 3000);
            }
            //else
            //    e.ListViewItem.GetSubItem(e.SubItemIndex).Decoration = null;
        }

        private void serversOLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (serversOLV.SelectedIndex != -1)
            {
                deleteServerButton.Enabled = true;
                deleteServerButton.Visible = true;

                addServerButton.Enabled = false;
                addServerButton.Visible = false;
            }
            else
            {
                deleteServerButton.Enabled = false;
                deleteServerButton.Visible = false;

                addServerButton.Enabled = true;
                addServerButton.Visible = true;
            }

        }

        private void deleteServerButton_Click(object sender, EventArgs e)
        {
            if (deleteItemForm == null || deleteItemForm.IsDisposed)
                deleteItemForm = new DeleteItemForm(regionListComboBox.Text);

            deleteItemForm.Show();
            deleteItemForm.VisibleChanged += deleteServerFormClosed;
            deleteItemForm.Focus();
        }
        private void deleteServerFormClosed(object sender, EventArgs e)
        {
            if (!deleteItemForm.Visible)
            {
                string deletedServer = deleteItemForm.itemToDelete;

                Server server = (Server)serversOLV.SelectedItem.RowObject;

                gameList.Find(x => x.Name == gamesListComboBox.Text)
                    .Regions.Find(x => x.Name == regionListComboBox.Text).Servers.Remove(server);
                //regionListComboBox.Items.Remove(deletedRegion);
                serversOLV.RemoveObject(server);

                deleteItemForm.Dispose();
            }
        }

        // SAVE CHANGES TO FILE
        private void saveButton_Click(object sender, EventArgs e)
        {
            XMLManipulation xML = new XMLManipulation();
            xML.WriteXMLFile("..\\..\\gamesList.xml", gameList);
            this.Close();
        }

    }
}
