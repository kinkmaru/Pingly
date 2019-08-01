using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Pingly
{
    class Pinging
    {
        public int GetAveragePing(Server server, int timesToRunPing)
        {
            Ping p = new Ping();
            PingReply pingReply;
            long count = 0;
            int successfulPings = 0;

            for (int i = 0; i < timesToRunPing; i++)
            {
                pingReply = p.Send(server.Ip, 1000);
                if (pingReply.Status != IPStatus.Success)
                    continue;
                else
                {
                    successfulPings++;
                    count += pingReply.RoundtripTime;
                }
            }
            if (successfulPings < 1)
                return 999;

            return Convert.ToInt32(count / successfulPings);
        }

        public int GetPingStatusCode(int ping)
        {
            if (ping < 50)
                return 0;
            if (ping > 50 && ping < 101)
                return 1;
            if (ping > 100 && ping < 201)
                return 2;

            return 3;
        }
    }
}
