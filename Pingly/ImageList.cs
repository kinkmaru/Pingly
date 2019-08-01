using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Pingly
{
    class ImageList
    {
        protected string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        List<BitmapImage> images = new List<BitmapImage>();
        public List<BitmapImage> Images
        {
            get
            {
                return images;
            }
            set
            {
                images = value;
            }
        }
    }
}
