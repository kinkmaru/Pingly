using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPing
{
    public class Region
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

        List<Server> servers = new List<Server>();
        public List<Server> Servers
        {
            get
            {
                return servers;
            }
            set
            {
                servers = value;
            }
        }
    }
}
