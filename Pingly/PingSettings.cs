using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pingly
{
    class PingSettings
    {
        protected string gameName { get; set; }
        protected string regionName { get; set; }
        protected string pingPrecision { get; set; }

        public string GameName
        {
            get
            {
                return gameName;
            }
            set
            {
                gameName = value;
            }
        }
        public string RegionName
        {
            get
            {
                return regionName;
            }
            set
            {
                regionName = value;
            }
        }
        public string PingPrecision
        {
            get
            {
                return pingPrecision;
            }
            set
            {
                pingPrecision = value;
            }
        }
    }
}
