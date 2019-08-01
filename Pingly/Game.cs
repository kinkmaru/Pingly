using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pingly
{
    class Game
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
        List<Region> regions = new List<Region>();
        public List<Region> Regions
        {
            get
            {
                return regions;
            }
            set
            {
                regions = value;
            }
        }
    }
}
