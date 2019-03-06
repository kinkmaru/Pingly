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
        private int ping;

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
    }
}
