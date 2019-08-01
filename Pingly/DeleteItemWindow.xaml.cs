using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Pingly
{
    /// <summary>
    /// Interaction logic for DeleteItemWindow.xaml
    /// </summary>
    public partial class DeleteItemWindow : Window
    {
        public string itemToDelete;
        public bool isDeleting;
        Dictionary<string, ImageList> buttonsImageList = new Dictionary<string, ImageList>();

        public DeleteItemWindow(string itemName)
        {
            InitializeComponent();
            itemToDelete = itemName;
            LoadButtonImages();
        }

        private void LoadButtonImages()
        {
            // Load images into a dictionary of images for changing button appearance during events
            string startingFolder = "../../ButtonImgs/DeleteItemWindow/";
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

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            isDeleting = true;
            this.Visibility = Visibility.Hidden;
        }
        private void ConfirmDeleteButtonImage_MouseEnter(object sender, MouseEventArgs e)
        {
            ConfirmDeleteButtonImage.Source = buttonsImageList["ConfirmDeleteButtons"].Images[1];
        }
        private void ConfirmDeleteButtonImage_MouseLeave(object sender, MouseEventArgs e)
        {
            ConfirmDeleteButtonImage.Source = buttonsImageList["ConfirmDeleteButtons"].Images[0];
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void CancelDeleteButtonImage_MouseEnter(object sender, MouseEventArgs e)
        {
            CancelDeleteButtonImage.Source = buttonsImageList["CancelDeleteButtons"].Images[1];
        }
        private void CancelDeleteButtonImage_MouseLeave(object sender, MouseEventArgs e)
        {
            CancelDeleteButtonImage.Source = buttonsImageList["CancelDeleteButtons"].Images[0];
        }
    }
}
