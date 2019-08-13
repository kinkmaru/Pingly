using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Pingly
{
    /// <summary>
    /// Interaction logic for PingWindow.xaml
    /// </summary>
    public partial class PingWindow : Window
    {
        private string chosenGameList = "gamesList.xml";
        List<Game> gameList = new List<Game>();
        private static FileEditWindow fileEditWindow;
        ObservableCollection<Server> pingingServerList = new ObservableCollection<Server>();
        PingSettings pingItems = new PingSettings();
        Dictionary<string, ImageList> buttonsImageList = new Dictionary<string, ImageList>();
        Dictionary<string, ImageList> serverStatusImageList = new Dictionary<string, ImageList>();

        public bool isPingCancelled;

        private string pingSortDirection = "Ascending";
        private string nameSortDirection = "Ascending";

        private bool isUpdatingFile;

        public PingWindow()
        {
            InitializeComponent();
            if (!File.Exists(chosenGameList))
            {
                XMLManipulation XML = new XMLManipulation();
                XML.CreateFreshGameList(chosenGameList);
            }
            LoadPingImages();
            PopulateForm(chosenGameList, System.IO.Path.GetFileName(chosenGameList));
            SetPingSettings();
        }

        private void LoadPingImages()
        {
            // Load images into a dictionary of images for changing button appearance during events
            string startingFolder = "ButtonImgs/PingWindow/";
            DirectoryInfo di = new DirectoryInfo(startingFolder);
            foreach (var directory in di.GetDirectories())
            {
                ImageList il = new ImageList
                {
                    Name = directory.Name
                };
                foreach (var file in directory.GetFiles())
                {
                    BitmapImage bmpi = new BitmapImage(new Uri(startingFolder + directory.Name + "/" + file.Name, UriKind.RelativeOrAbsolute));

                    il.Images.Add(bmpi);
                }
                buttonsImageList.Add(directory.Name, il);
            }

            startingFolder = "StatusButtonImgs/";
            di = new DirectoryInfo(startingFolder);

            ImageList bil = new ImageList
            {
                Name = di.Name
            };
            foreach (var file in di.GetFiles())
            {
                BitmapImage bmpi = new BitmapImage(new Uri(startingFolder + file.Name, UriKind.RelativeOrAbsolute));
                bil.Images.Add(bmpi);
            }
            serverStatusImageList.Add(di.Name, bil);
        }

        private void SetPingSettings()
        {
            pingItems.GameName = GamesListComboBox.Text;
            pingItems.RegionName = RegionsListView.SelectedItem != null ? RegionsListView.SelectedItem.ToString() : "NA";
            pingItems.PingPrecision = PingPrecisionComboBox.Text;
        }

        private int GetPingPrecision(string precisionText)
        {
            switch (precisionText)
            {
                case "Fast":
                    return 1;
                case "Moderate":
                    return 5;
                case "Thorough":
                    return 10;
                default:
                    return 1;
            }
        }

        private void PopulateForm(string gamesXMLFileLocation, string gamesXMLFileName)
        {
            ResetForm();
            XMLManipulation xmlRead = new XMLManipulation();
            gameList = xmlRead.ReadXmlFile(gamesXMLFileLocation);

            GamesListComboBox.Items.Clear();
            var games = gameList.OrderBy(x => x.Name);

            foreach (Game game in games)
            {
                GamesListComboBox.Items.Add(game.Name);
            }

            GamesListComboBox.Text = "Select Game";

            PingPrecisionComboBox.Items.Clear();
            PingPrecisionComboBox.Items.Add("Fast");
            PingPrecisionComboBox.Items.Add("Moderate");
            PingPrecisionComboBox.Items.Add("Thorough");

            if (gamesXMLFileName != "gamesList.xml")
            {
                CurrentFileTextBlock.Text = gamesXMLFileName;
                CurrentFileTextBlock.Visibility = Visibility.Visible;
                SelectGameListTextBlock.Visibility = Visibility.Hidden;
            }
            else
            {
                CurrentFileTextBlock.Visibility = Visibility.Hidden;
                SelectGameListTextBlock.Visibility = Visibility.Visible;

            }
            SelectedFileTextBlock.Text = gamesXMLFileName;

            PingingListView.ItemsSource = pingingServerList;
        }

        private void ResetForm()
        {
            pingingServerList.Clear();
            RegionsListView.Items.Clear();
            PingPrecisionComboBox.SelectedValue = pingItems.PingPrecision;
            PingingListView.IsEnabled = false;
        }

        private void GamesListComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!isUpdatingFile)
            {
                ResetForm();

                string selectedGame = GamesListComboBox.SelectedValue.ToString();
                List<Region> regionList = gameList.Find(x => x.Name == selectedGame).Regions;
                foreach (Region region in regionList)
                {
                    RegionsListView.Items.Add(region.Name);
                }
                RegionsListView.SelectedItem = RegionsListView.Items[0];
                pingItems.GameName = selectedGame;
                pingItems.RegionName = RegionsListView.SelectedItem.ToString();

                PingServers();
            }
        }

        private async void PingServers()
        {
            if (GamesListComboBox.SelectedItem != null)
            {
                GamesListComboBox.IsEnabled = false;
                PingPrecisionComboBox.IsEnabled = false;
                pingingServerList.Clear();
                RefreshButtonImage.Source = buttonsImageList["RefreshButtons"].Images[2];
                SaveSettingsButtonImage.Source = buttonsImageList["SaveButtons"].Images[2];
                SettingsButton.IsEnabled = false;
                SaveSettingsButton.IsEnabled = false;
                PingingListView.IsEnabled = true;

                List<Server> serverList = gameList.Find(x => x.Name == pingItems.GameName).Regions.Find(y => y.Name == pingItems.RegionName).Servers;

                await Task.Run(() =>
                {
                    Pinging ping = new Pinging();

                    double totalServers = serverList.Count();
                    double pingProgressionCount = 0;

                    foreach (Server server in serverList)
                    {
                        if (isPingCancelled)
                        {
                            isPingCancelled = false;
                            break;
                        }
                        server.Ping = ping.GetAveragePing(server, GetPingPrecision(pingItems.PingPrecision));
                        server.Status = serverStatusImageList["StatusButtonImgs"].Images[ping.GetPingStatusCode(server.Ping)];

                        pingProgressionCount++;
                        int progressValue = Convert.ToInt32(Math.Floor(((pingProgressionCount / totalServers) * 100)));

                        PingingListView.Dispatcher.Invoke(() =>
                        {
                            pingingServerList.Add(server);
                            PingingProgressBar.Value = progressValue;
                        });
                    }
                });


                SaveSettingsButton.IsEnabled = true;
                SettingsButton.IsEnabled = true;
                GamesListComboBox.IsEnabled = true;
                PingPrecisionComboBox.IsEnabled = true;
                RefreshButtonImage.Source = buttonsImageList["RefreshButtons"].Images[0];
                SaveSettingsButtonImage.Source = buttonsImageList["SaveButtons"].Images[0];
            }
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            ResizeForm();
        }

        private void CancelSettingsButton_Click(object sender, RoutedEventArgs e)
        {
            ResetSettings();
            ResizeForm();
        }

        private void FileEditButton_Click(object sender, RoutedEventArgs e)
        {
            if (fileEditWindow == null || !fileEditWindow.IsLoaded)
                fileEditWindow = new FileEditWindow(chosenGameList);

            fileEditWindow.Owner = this;

            fileEditWindow.Show();
            fileEditWindow.IsVisibleChanged += FileEditWindowClosed;
            SetPingCapabilities(false);
            fileEditWindow.Focus();
        }
        private void FileEditWindowClosed(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (fileEditWindow.isSavingFile)
            {
                isUpdatingFile = true;
                PopulateForm(chosenGameList, System.IO.Path.GetFileName(chosenGameList));
                isUpdatingFile = false;
            }
            SetPingCapabilities(true);
        }
        private void SetPingCapabilities(bool isEnabled)
        {
            if (isEnabled)
            {
                SelectFileButton.IsEnabled = true;
                GamesListComboBox.IsEnabled = true;
                RefreshButton.IsEnabled = true;
                SaveSettingsButton.IsEnabled = true;
            }
            else
            {
                SelectFileButton.IsEnabled = false;
                GamesListComboBox.IsEnabled = false;
                RefreshButton.IsEnabled = false;
                SaveSettingsButton.IsEnabled = false;
            }
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            if (RefreshButtonImage.Source.ToString().Contains("0"))
            {
                ResetSettings();
                PingServers();
            }
            else if (RefreshButtonImage.Source.ToString().Contains("2"))
            {
                isPingCancelled = true;
                //tokenSource.Cancel();
            }
        }

        private void ResetSettings()
        {
            PingPrecisionComboBox.Text = pingItems.PingPrecision;
            RegionsListView.SelectedItem = pingItems.RegionName;
        }

        private void SaveSettingsButton_Click(object sender, RoutedEventArgs e)
        {
            if (!SaveSettingsButtonImage.Source.ToString().Contains("2"))
            {
                SetPingSettings();
                ResizeForm();
                PingServers();
            }
        }

        private void SelectFileClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "XML Files (*.xml)|*xml",
                Multiselect = true,
                Title = "Select XML File"
            };
            bool? tryOpenFile = ofd.ShowDialog();
            if (tryOpenFile == true)
            {
                isUpdatingFile = true;
                PopulateForm(ofd.FileName, ofd.SafeFileName);
                chosenGameList = ofd.FileName;
                isUpdatingFile = false;
            }
        }
        private void SelectFileButton_MouseEnter(object sender, MouseEventArgs e)
        {
            if (SelectFileButtonImage.Source.ToString().Contains("0"))
                SelectFileButtonImage.Source = buttonsImageList["SelectFileButtons"].Images[1];
        }
        private void SelectFileButton_MouseLeave(object sender, MouseEventArgs e)
        {
            if (SelectFileButtonImage.Source.ToString().Contains("1"))
                SelectFileButtonImage.Source = buttonsImageList["SelectFileButtons"].Images[0];
        }

        private void ResizeForm()
        {
            string formWidth = (this.Width <= 332) ? "closed" : "opened";

            if (formWidth == "closed")
            {
                while (this.Width < 596)
                {
                    this.Width += 6;
                }
            }
            else if (formWidth == "opened")
            {
                while (this.Width > 332)
                {
                    this.Width -= 6;
                }
            }
        }

        private void PingColumnHeader_Click(object sender, RoutedEventArgs e)
        {
            if (pingingServerList.Count > 0)
            {
                GridViewColumnHeader column = sender as GridViewColumnHeader;
                string sortBy = column.Tag.ToString();

                SortColumnByHeader(sortBy, pingSortDirection);
                pingSortDirection = pingSortDirection == "Ascending" ? "Descending" : "Ascending";
            }
        }
        private void ServerNameColumnHeader_Click(object sender, RoutedEventArgs e)
        {
            if (pingingServerList.Count > 0)
            {
                GridViewColumnHeader column = sender as GridViewColumnHeader;
                string sortBy = column.Tag.ToString();

                SortColumnByHeader(sortBy, nameSortDirection);
                nameSortDirection = nameSortDirection == "Ascending" ? "Descending" : "Ascending";
            }
        }
        private void SortColumnByHeader(string header, string sortDirection)
        {
            ListSortDirection lsdir;
            if (sortDirection == "Ascending")
            {
                lsdir = ListSortDirection.Descending;
            }
            else
            {
                lsdir = ListSortDirection.Ascending;
            }

            ICollectionView icv = CollectionViewSource.GetDefaultView(pingingServerList);
            icv.SortDescriptions.Clear();
            icv.SortDescriptions.Add(new SortDescription(header, lsdir));
        }
    }
}
