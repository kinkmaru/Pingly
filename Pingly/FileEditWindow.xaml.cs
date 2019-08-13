using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pingly
{
    public partial class FileEditWindow : Window
    {
        private static DeleteItemWindow deleteItemWindow;
        List<Game> gameList = new List<Game>();
        ObservableCollection<Server> serverList = new ObservableCollection<Server>();
        Dictionary<string, ImageList> buttonsImageList = new Dictionary<string, ImageList>();

        private bool editingGameName;
        private string gameBeingEdited;
        private bool editingRegionName;
        private string regionBeingEdited;

        private bool isCancelledByGridClick;
        public bool isSavingFile;

        private string gameFileLocation;

        public FileEditWindow(string gameFile)
        {
            InitializeComponent();
            gameFileLocation = gameFile;
            PopulateForm(gameFile, System.IO.Path.GetFileName(gameFile));
            LoadButtonImages();
            ResetForm();
        }

        // Used to force a refresh of a given control on the UI thread 
        private delegate void NoArgDelegate();
        public static void RefreshUIControl(DependencyObject obj)
        {
            obj.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.ApplicationIdle,
                (NoArgDelegate)delegate { });
        }

        private void PopulateForm(string gamesXMLFile, string gamesXMLFileName)
        {
            XMLManipulation xmlRead = new XMLManipulation();
            gameList = xmlRead.ReadXmlFile(gamesXMLFile);

            var games = gameList.OrderBy(x => x.Name);
            foreach (Game game in games)
            {
                gamesListComboBox.Items.Add(game.Name);
            }
            FileLabel.Content = "Edit > " + gamesXMLFileName;
        }

        private void LoadButtonImages()
        {
            // Load images into a dictionary of images for changing button appearance during events
            string startingFolder = "ButtonImgs/EditGameListWindow/";
            DirectoryInfo di = new DirectoryInfo(startingFolder);
            foreach (var directory in di.GetDirectories())
            {
                ImageList bil = new ImageList();
                bil.Name = directory.Name;
                foreach (var file in directory.GetFiles())
                {
                    BitmapImage bmpi = new BitmapImage(new Uri(startingFolder + directory.Name + "/" + file.Name, UriKind.RelativeOrAbsolute));

                    bil.Images.Add(bmpi);
                }
                buttonsImageList.Add(directory.Name, bil);
            }
        }

        // ResetForm is used to quickly return all controls to a base state
        private void ResetForm()
        {
            AddGameButtonImage.Source = buttonsImageList["AddButtons"].Images[0];
            EditGameButtonImage.Source = buttonsImageList["EditButtons"].Images[0];
            DeleteGameButtonImage.Source = buttonsImageList["DeleteButtons"].Images[0];

            regionsListComboBox.Items.Clear();
            regionsListComboBox.Text = "";
            RegionsLabel.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 92, 101));
            AddRegionButtonImage.Source = buttonsImageList["AddButtons"].Images[0];
            EditRegionButtonImage.Source = buttonsImageList["EditButtons"].Images[0];
            DeleteRegionButtonImage.Source = buttonsImageList["DeleteButtons"].Images[0];

            ServersLabel.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 92, 101));
            ServersDataGrid.Foreground = new SolidColorBrush(Color.FromArgb(255, 102, 102, 102));
            ServersDataGrid.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 75, 75, 75));

            AddServerButtonImage.Visibility = Visibility.Visible;
            AddServerButtonImage.Source = buttonsImageList["AddServerButtons"].Images[0];

            ServersDataGrid.ItemsSource = null;
            DeleteServerButton.Visibility = Visibility.Hidden;
            DeleteServerButtonImage.Source = buttonsImageList["DeleteServerButtons"].Images[0];

            SaveChangesButtonImage.Source = buttonsImageList["SaveButtons"].Images[0];
        }

        // GAME EVENTS
        private void GamesListComboBoxSearchForGame(object sender, EventArgs e)
        {
            if (!editingGameName)
            {
                string comboText = gamesListComboBox.Text;
                // If searched game exists, populate regions combobox and enable appropriate action buttons
                if (gamesListComboBox.Items.Contains(comboText))
                {
                    ResetForm();
                    List<Region> regionList = gameList.Find(x => x.Name == comboText).Regions;
                    var regions = regionList.OrderBy(x => x.Name);
                    foreach (Region region in regions)
                    {
                        regionsListComboBox.Items.Add(region.Name);
                    }
                    AddGameButtonImage.Source = buttonsImageList["AddButtons"].Images[0];
                    EditGameButtonImage.Source = buttonsImageList["EditButtons"].Images[1];
                    DeleteGameButtonImage.Source = buttonsImageList["DeleteButtons"].Images[1];

                    RegionsLabel.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 151, 167));
                }

                // Can't add or modify a game without text - Reset
                else if (comboText == "")
                {
                    ResetForm();
                }

                // Text isn't apart of the combobox list of items. Reset and allow adding of the item
                else
                {
                    ResetForm();
                    AddGameButtonImage.Source = buttonsImageList["AddButtons"].Images[1];
                }
            }
        }
        private void gamesListComboBox_PreviewLostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            // Should a user leave the combobox during an edit before completing, cancel movement
            if (editingGameName)
                e.Handled = true;
        }

        private void AddGameButton_Click(object sender, EventArgs e)
        {
            if (!AddGameButtonImage.Source.ToString().Contains("0"))
            {
                // Add new game to gamelist and game combobox
                Game newGame = new Game();
                newGame.Name = gamesListComboBox.Text;
                gameList.Add(newGame);

                gamesListComboBox.Items.Clear();
                var games = gameList.OrderBy(x => x.Name);
                foreach (Game game in games)
                {
                    gamesListComboBox.Items.Add(game.Name);
                }

                // Make changes to window suitable to having a game selected
                GamesListComboBoxSearchForGame(gamesListComboBox, e);
            }
        }
        private void AddGameButton_MouseEnter(object sender, EventArgs e)
        {
            if (!AddGameButtonImage.Source.ToString().Contains("0") && !editingGameName)
                AddGameButtonImage.Source = buttonsImageList["AddButtons"].Images[2];
        }
        private void AddGameButton_MouseLeave(object sender, EventArgs e)
        {
            if (gamesListComboBox.Text == "" || gamesListComboBox.Items.Contains(gamesListComboBox.Text) || editingGameName)
                AddGameButtonImage.Source = buttonsImageList["AddButtons"].Images[0];
            else
                AddGameButtonImage.Source = buttonsImageList["AddButtons"].Images[1];
        }

        private void EditGameButton_Click(object sender, EventArgs e)
        {
            if (!EditGameButtonImage.Source.ToString().Contains("0"))
            {
                // If game matches an existing one, enable editing
                if (gamesListComboBox.Items.Contains(gamesListComboBox.Text))
                {
                    if (editingGameName)
                    {
                        editingGameName = false;
                        EditGameButtonImage.Source = buttonsImageList["EditButtons"].Images[2];
                    }
                    else
                    {
                        gamesListComboBox.Focus();

                        // Must find the combobox textbox template by name in order to modify its caret position
                        var gameComboTextBox = (TextBox)gamesListComboBox.Template.FindName("PART_EditableTextBox", gamesListComboBox);
                        gameComboTextBox.CaretIndex = gamesListComboBox.Text.Length;

                        editingGameName = true;
                        gameBeingEdited = gamesListComboBox.Text;

                        EditGameButtonImage.Source = buttonsImageList["EditButtons"].Images[3];
                    }
                }
                // Proceed with editing
                else
                {
                    // find existing game based on given combobox text
                    Game currentGame = gameList.Find(x => x.Name == gameBeingEdited);

                    // store the new game name
                    string newGameName = gamesListComboBox.Text;

                    // remove existing game from the game list
                    gameList.Remove(currentGame);

                    // Override the existing game name and reenter into combo items list and game list
                    currentGame.Name = newGameName;
                    gameList.Add(currentGame);

                    // Repopulate the game list combobox with reordered items
                    gamesListComboBox.Items.Clear();
                    var games = gameList.OrderBy(x => x.Name);
                    foreach (Game game in games)
                    {
                        gamesListComboBox.Items.Add(game.Name);
                    }

                    // set the combobox value to the new game name
                    gamesListComboBox.SelectedValue = newGameName;

                    editingGameName = false;

                    EditGameButtonImage.Source = buttonsImageList["EditButtons"].Images[2];
                }
            }
        }
        private void EditGameButton_MouseEnter(object sender, EventArgs e)
        {
            if (!EditGameButtonImage.Source.ToString().Contains("0"))
            {
                if (editingGameName)
                    EditGameButtonImage.Source = buttonsImageList["EditButtons"].Images[3];
                else
                    EditGameButtonImage.Source = buttonsImageList["EditButtons"].Images[2];
            }
        }
        private void EditGameButton_MouseLeave(object sender, EventArgs e)
        {
            if (editingGameName || gamesListComboBox.Items.Contains(gamesListComboBox.Text))
                EditGameButtonImage.Source = buttonsImageList["EditButtons"].Images[1];
            else
                EditGameButtonImage.Source = buttonsImageList["EditButtons"].Images[0];
        }

        private void DeleteGameButton_Click(object sender, EventArgs e)
        {
            if (!DeleteGameButtonImage.Source.ToString().Contains("0") && !editingGameName)
            {
                if (deleteItemWindow == null || !deleteItemWindow.IsLoaded)
                    deleteItemWindow = new DeleteItemWindow(gamesListComboBox.Text);

                deleteItemWindow.Owner = this;

                deleteItemWindow.Show();
                deleteItemWindow.IsVisibleChanged += DeleteGameWindowClosed;
                deleteItemWindow.Focus();
            }
        }
        private void DeleteGameWindowClosed(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (deleteItemWindow.isDeleting)
            {
                string deletedGame = deleteItemWindow.itemToDelete;

                // Find game by the deleted item name and update the combobox
                Game game = gameList.Find(x => x.Name == deletedGame);
                gameList.Remove(game);
                gamesListComboBox.Items.Remove(deletedGame);

                ResetForm();
                gamesListComboBox.Text = "";

                deleteItemWindow.Close();
            }
        }
        private void DeleteGameButton_MouseEnter(object sender, EventArgs e)
        {
            if (!DeleteGameButtonImage.Source.ToString().Contains("0"))
                DeleteGameButtonImage.Source = buttonsImageList["DeleteButtons"].Images[2];
        }
        private void DeleteGameButton_MouseLeave(object sender, EventArgs e)
        {
            if (gamesListComboBox.Items.Contains(gamesListComboBox.Text) || editingGameName)
                DeleteGameButtonImage.Source = buttonsImageList["DeleteButtons"].Images[1];
            else
                DeleteGameButtonImage.Source = buttonsImageList["DeleteButtons"].Images[0];
        }

        // REGION EVENTS
        private void RegionsListComboBoxSearchForRegion(object sender, EventArgs e)
        {
            if (!editingRegionName)
            {
                string selectedGame = gamesListComboBox.Text;
                string selectedRegion = regionsListComboBox.Text;

                // If searched region exists, populate ServersOLV and enable appropriate action buttons
                if (regionsListComboBox.Items.Contains(selectedRegion))
                {
                    List<Server> servers = gameList.Find(x => x.Name == selectedGame).Regions.Find(x => x.Name == selectedRegion).Servers;

                    serverList.Clear();
                    foreach (Server server in servers)
                    {
                        serverList.Add(server);
                    }

                    ServersDataGrid.ItemsSource = serverList;

                    AddRegionButtonImage.Source = buttonsImageList["AddButtons"].Images[0];
                    EditRegionButtonImage.Source = buttonsImageList["EditButtons"].Images[1];
                    DeleteRegionButtonImage.Source = buttonsImageList["DeleteButtons"].Images[1];

                    ServersLabel.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 151, 167));
                    ServersDataGrid.Foreground = new SolidColorBrush(Color.FromArgb(255, 153, 153, 153));
                    ServersDataGrid.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 153, 153, 153));

                    AddServerButtonImage.Source = buttonsImageList["AddServerButtons"].Images[1];
                }

                // Can't add a region with no text - ensure all buttons are disabled and datagrid cleared
                else if (regionsListComboBox.Text == "")
                {
                    AddRegionButtonImage.Source = buttonsImageList["AddButtons"].Images[0];
                    EditRegionButtonImage.Source = buttonsImageList["EditButtons"].Images[0];
                    DeleteRegionButtonImage.Source = buttonsImageList["DeleteButtons"].Images[0];

                    AddServerButtonImage.Source = buttonsImageList["AddServerButtons"].Images[0];

                    ServersLabel.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 92, 101));
                    ServersDataGrid.Foreground = new SolidColorBrush(Color.FromArgb(255, 102, 102, 102));
                    ServersDataGrid.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 75, 75, 75));

                    ServersDataGrid.ItemsSource = null;
                }

                // Other conditioned mean potentially adding a new region - enable region add button and reset all other controls
                else
                {
                    AddRegionButtonImage.Source = buttonsImageList["AddButtons"].Images[1];
                    EditRegionButtonImage.Source = buttonsImageList["EditButtons"].Images[0];
                    DeleteRegionButtonImage.Source = buttonsImageList["DeleteButtons"].Images[0];

                    AddServerButtonImage.Source = buttonsImageList["AddServerButtons"].Images[0];
                    ServersLabel.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 92, 101));
                    ServersDataGrid.Foreground = new SolidColorBrush(Color.FromArgb(255, 102, 102, 102));
                    ServersDataGrid.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 75, 75, 75));

                    ServersDataGrid.ItemsSource = null;
                }
            }
        }
        private void regionsListComboBox_PreviewLostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            // Should a user try to leave the combobox before completing an edit, cancel the movement
            if (editingRegionName)
            {
                e.Handled = true;
            }
        }

        private void AddRegionButton_Click(object sender, EventArgs e)
        {
            if (!AddRegionButtonImage.Source.ToString().Contains("0"))
            {
                // store new region name for later use
                string newRegionName = regionsListComboBox.Text;

                if (newRegionName.Length > 3)
                {
                    regionsListComboBox.Focus();

                    // Must find the combobox textbox template by name in order to modify its caret position
                    var regionComboTextBox = (TextBox)regionsListComboBox.Template.FindName("PART_EditableTextBox", regionsListComboBox);
                    regionComboTextBox.CaretIndex = regionsListComboBox.Text.Length;

                    // TODO: Display error
                }
                else
                {
                    // Add new region to gamelist and region combobox
                    Region newRegion = new Region();
                    newRegion.Name = newRegionName;
                    gameList.Find(x => x.Name == gamesListComboBox.Text).Regions.Add(newRegion);
                    Game regionsGame = gameList.Find(x => x.Name == gamesListComboBox.Text);

                    var regions = regionsGame.Regions.OrderBy(x => x.Name);
                    regionsListComboBox.Items.Clear();
                    foreach (Region region in regions)
                    {
                        regionsListComboBox.Items.Add(region.Name);
                    }

                    // Mage changes to form suitable to having a region selected
                    RegionsListComboBoxSearchForRegion(sender, e);
                }
            }
        }
        private void AddRegionButton_MouseEnter(object sender, EventArgs e)
        {
            if (!AddRegionButtonImage.Source.ToString().Contains("0") && !editingRegionName)
                AddRegionButtonImage.Source = buttonsImageList["AddButtons"].Images[2];
        }
        private void AddRegionButton_MouseLeave(object sender, EventArgs e)
        {
            if (regionsListComboBox.Text == "" || regionsListComboBox.Items.Contains(regionsListComboBox.Text) || editingRegionName)
                AddRegionButtonImage.Source = buttonsImageList["AddButtons"].Images[0];
            else
                AddRegionButtonImage.Source = buttonsImageList["AddButtons"].Images[1];
        }

        private void EditRegionButton_Click(object sender, EventArgs e)
        {
            if (!EditRegionButtonImage.Source.ToString().Contains("0"))
            {
                // If region matches an existing one, enable editing
                if (regionsListComboBox.Items.Contains(regionsListComboBox.Text))
                {
                    if (editingRegionName)
                    {
                        editingRegionName = false;
                        EditRegionButtonImage.Source = buttonsImageList["EditButtons"].Images[2];
                    }
                    else
                    {
                        regionsListComboBox.Focus();

                        // Must find the combobox textbox template by name in order to modify its caret position
                        var regionComboTextBox = (TextBox)regionsListComboBox.Template.FindName("PART_EditableTextBox", regionsListComboBox);
                        regionComboTextBox.CaretIndex = regionsListComboBox.Text.Length;

                        editingRegionName = true;
                        regionBeingEdited = regionsListComboBox.Text;

                        EditRegionButtonImage.Source = buttonsImageList["EditButtons"].Images[3];
                    }
                }
                else
                {
                    // store new region name for later use
                    string newRegionName = regionsListComboBox.Text;

                    if (newRegionName.Length > 3)
                    {
                        regionsListComboBox.Focus();

                        // Must find the combobox textbox template by name in order to modify its caret position
                        var regionComboTextBox = (TextBox)regionsListComboBox.Template.FindName("PART_EditableTextBox", regionsListComboBox);
                        regionComboTextBox.CaretIndex = regionsListComboBox.Text.Length;

                        // TODO: Display error

                    }
                    else
                    {
                        // find existing region based on given game and region combobox text
                        Game regionsGame = gameList.Find(x => x.Name == gamesListComboBox.Text);
                        Region currentRegion = regionsGame.Regions.Find(x => x.Name == regionBeingEdited);


                        // remove existing region from the gameList
                        gameList.Find(x => x == regionsGame).Regions.Remove(currentRegion);

                        // Override the existing game name and re-enter into game list
                        currentRegion.Name = newRegionName;
                        gameList.Find(x => x == regionsGame).Regions.Add(currentRegion);

                        // Order the new region list and populat the combobox
                        var regions = regionsGame.Regions.OrderBy(x => x.Name);
                        regionsListComboBox.Items.Clear();
                        foreach (Region region in regions)
                        {
                            regionsListComboBox.Items.Add(region.Name);
                        }

                        // set the combobox value to the new region name
                        regionsListComboBox.SelectedValue = newRegionName;

                        editingRegionName = false;

                        EditRegionButtonImage.Source = buttonsImageList["EditButtons"].Images[2];
                    }
                }
            }
        }
        private void EditRegionButton_MouseEnter(object sender, EventArgs e)
        {
            if (!EditRegionButtonImage.Source.ToString().Contains("0"))
            {
                if (editingRegionName)
                    EditRegionButtonImage.Source = buttonsImageList["EditButtons"].Images[3];
                else
                    EditRegionButtonImage.Source = buttonsImageList["EditButtons"].Images[2];
            }
        }
        private void EditRegionButton_MouseLeave(object sender, EventArgs e)
        {
            if (editingRegionName || regionsListComboBox.Items.Contains(regionsListComboBox.Text))
                EditRegionButtonImage.Source = buttonsImageList["EditButtons"].Images[1];
            else
                EditRegionButtonImage.Source = buttonsImageList["EditButtons"].Images[0];
        }

        private void DeleteRegionButton_Click(object sender, EventArgs e)
        {
            if (!DeleteRegionButtonImage.Source.ToString().Contains("0") && !editingRegionName)
            {
                if (deleteItemWindow == null || !deleteItemWindow.IsLoaded)
                    deleteItemWindow = new DeleteItemWindow(regionsListComboBox.Text);

                deleteItemWindow.Owner = this;

                deleteItemWindow.Show();
                deleteItemWindow.IsVisibleChanged += DeleteRegionWindowClosed;
                deleteItemWindow.Focus();
            }
        }
        private void DeleteRegionWindowClosed(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (deleteItemWindow.isDeleting)
            {
                string deletedRegion = deleteItemWindow.itemToDelete;

                Region region = gameList.Find(x => x.Name == gamesListComboBox.Text).Regions.Find(x => x.Name == deletedRegion);
                gameList.Find(x => x.Name == gamesListComboBox.Text).Regions.Remove(region);
                regionsListComboBox.Items.Remove(deletedRegion);

                regionsListComboBox.Text = "";
                ServersDataGrid.ItemsSource = null;

                deleteItemWindow.Close();
            }
        }
        private void DeleteRegionButton_MouseEnter(object sender, EventArgs e)
        {
            if (!DeleteRegionButtonImage.Source.ToString().Contains("0"))
                DeleteRegionButtonImage.Source = buttonsImageList["DeleteButtons"].Images[2];
        }
        private void DeleteRegionButton_MouseLeave(object sender, EventArgs e)
        {
            if (regionsListComboBox.Items.Contains(regionsListComboBox.Text) || editingRegionName)
                DeleteRegionButtonImage.Source = buttonsImageList["DeleteButtons"].Images[1];
            else
                DeleteRegionButtonImage.Source = buttonsImageList["DeleteButtons"].Images[0];
        }

        // SERVER EVENTS
        private void AddServerButton_Click(object sender, RoutedEventArgs e)
        {
            if (!AddServerButtonImage.Source.ToString().Contains("0"))
            {
                Server server = new Server();
                serverList.Add(server);

                gameList.Find(x => x.Name == gamesListComboBox.Text).Regions.Find(x => x.Name == regionsListComboBox.Text).Servers.Add(server);

                // Ensure newly added item is visible
                ServersDataGrid.ScrollIntoView(server);

                // Force the UI thread to update changes to the datagrids itemsource
                RefreshUIControl(ServersDataGrid);

                // Select the new item and ensure server buttons are correct
                ServersDataGrid.SelectedItem = server;
                DeleteServerButton.Visibility = Visibility.Visible;
                AddServerButton.Visibility = Visibility.Hidden;

                // Start the edit process on the first cell of the newly formed object
                ServersDataGrid.CurrentCell = new DataGridCellInfo(server, ServersDataGrid.Columns[0]);
                ServersDataGrid.BeginEdit();
            }
        }
        private void AddServerButton_MouseEnter(object sender, EventArgs e)
        {
            if (!AddServerButtonImage.Source.ToString().Contains("0"))
                AddServerButtonImage.Source = buttonsImageList["AddServerButtons"].Images[2];
        }
        private void AddServerButton_MouseLeave(object sender, EventArgs e)
        {
            if (regionsListComboBox.Items.Contains(regionsListComboBox.Text))
                AddServerButtonImage.Source = buttonsImageList["AddServerButtons"].Images[1];
            else
                AddServerButtonImage.Source = buttonsImageList["AddServerButtons"].Images[0];
        }

        private void ServersDataGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            TextBox cellTextBox = e.EditingElement as TextBox;
            // If a cell is left empty after editing, cancel the cell edit to refute the change
            if (cellTextBox.Text == "" && !isCancelledByGridClick)
            {
                // Cancel the edit by invoking a new edit on the current cell
                (sender as DataGrid).Dispatcher.BeginInvoke((Action)(() =>
                {
                    Server server = (Server)e.Row.Item;
                    ServersDataGrid.CurrentCell = new DataGridCellInfo(server, e.Column);
                    ServersDataGrid.BeginEdit();
                    cellTextBox.BorderBrush = new SolidColorBrush(Colors.DarkRed);
                }));

                // TODO: Change the specific cell border to red and/or display a tooltip with error text "Cell cannot be empty"
            }
        }
        private void ServersOLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ServersDataGrid.SelectedIndex != -1 && ServersDataGrid.IsKeyboardFocusWithin)
            {
                DeleteServerButton.Visibility = Visibility.Visible;
                AddServerButton.Visibility = Visibility.Hidden;
            }
            else
            {
                DeleteServerButton.Visibility = Visibility.Hidden;
                AddServerButton.Visibility = Visibility.Visible;
            }
        }

        private void DeleteServerButton_Click(object sender, EventArgs e)
        {
            if (deleteItemWindow == null || !deleteItemWindow.IsLoaded)
            {
                Server server = (Server)ServersDataGrid.SelectedItem;
                deleteItemWindow = new DeleteItemWindow(server.Name);
            }

            deleteItemWindow.Owner = this;

            deleteItemWindow.Show();
            deleteItemWindow.IsVisibleChanged += DeleteServerWindowClosed;
            deleteItemWindow.Focus();
        }
        private void DeleteServerWindowClosed(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (deleteItemWindow.isDeleting)
            {
                string deletedServer = deleteItemWindow.itemToDelete;

                Server server = (Server)ServersDataGrid.SelectedItem;

                gameList.Find(x => x.Name == gamesListComboBox.Text)
                    .Regions.Find(x => x.Name == regionsListComboBox.Text).Servers.Remove(server);
                serverList.Remove(server);

                deleteItemWindow.Close();
            }
        }
        private void DeleteServerButtonMouseEnterOrLeave(object sender, EventArgs e)
        {
            if (DeleteServerButtonImage.Source.ToString().Contains("0"))
                DeleteServerButtonImage.Source = buttonsImageList["DeleteServerButtons"].Images[1];
            else
                DeleteServerButtonImage.Source = buttonsImageList["DeleteServerButtons"].Images[0];
        }

        // SAVE CHANGES TO FILE
        private void SaveButton_Click(object sender, EventArgs e)
        {
            XMLManipulation xML = new XMLManipulation();
            xML.WriteXMLFile(gameFileLocation, gameList);
            isSavingFile = true;
            this.Close();
        }
        private void SaveButtonMouseEnterOrLeave(object sender, EventArgs e)
        {
            if (SaveChangesButtonImage.Source.ToString().Contains("0"))
                SaveChangesButtonImage.Source = buttonsImageList["SaveButtons"].Images[1];
            else
                SaveChangesButtonImage.Source = buttonsImageList["SaveButtons"].Images[0];
        }

        // Used for losing focus of non-control areas of the grid window, and ending datagrid edits if needed
        private void ClearDataGridSelection(object sender, EventArgs e)
        {
            if (ServersDataGrid.SelectedItem != null)
            {
                isCancelledByGridClick = true;
                ServersDataGrid.CommitEdit();
                isCancelledByGridClick = false;
                ServersDataGrid.UnselectAll();
            }
            ClearFocus(sender, e);
        }

        // Clearing focus for editable items
        private void ClearFocus(object sender, EventArgs e)
        {
            AddGameButton.Focus();
        }

        private void ServersDataGrid_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            // By handling the keydown event by default, this will prevent the datagrid tabbing to a new row
            if (e.Key == Key.Tab || e.Key == Key.Enter)
            {
                DataGrid dg = sender as DataGrid;
                if (dg.CurrentColumn.Header.ToString() == "Name")
                    ServersDataGrid.CommitEdit();
                else
                {
                    e.Handled = true;
                    ServersDataGrid.CommitEdit();
                }
            }
        }
    }
}