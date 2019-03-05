using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPing
{
    public class Server
    {
        private string name;
        private string ip;
        private string ping;

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
        public string Ping
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
    }
}
