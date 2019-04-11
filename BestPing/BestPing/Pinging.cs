using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace BestPing
{
    class Pinging
    {
        public int getAveragePing(Server server, int timesToRunPing)
        {
            Ping p = new Ping();
            string ip = server.Ip;
            PingReply pr;
            long count = 0;
            int successfulPings = 0;

            for(int i = 0; i < timesToRunPing; i++)
            {
                pr = p.Send(ip, 1000);
                if (pr.Status != IPStatus.Success)
                    continue;
                else
                {
                    successfulPings++;
                    count += pr.RoundtripTime;
                }
            }
            if (successfulPings < 1)
                return 999;

            return Convert.ToInt32(count / successfulPings);
        }
    }
}
