using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Pingly
{
    class Server
    {
        private string name;
        private string ip;
        private int ping;
        private BitmapImage status;

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
        public string Ip
        {
            get
            {
                return ip;

            }
            set
            {
                ip = value;
            }
        }
        public int Ping
        {
            get
            {
                return ping;
            }
            set
            {
                ping = value;
            }
        }
        public BitmapImage Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }
    }
}
