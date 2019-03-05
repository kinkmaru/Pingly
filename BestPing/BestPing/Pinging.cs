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
        public string getAveragePing(Server server, int timesToRunPing)
        {
            Ping p = new Ping();
            string ip = server.Ip;
            PingReply pr;
            long count = 0;

            for(int i = 0; i < timesToRunPing; i++)
            {
                pr = p.Send(ip, 1000);
                if (pr.Status != IPStatus.Success)
                    return "999";
                count += pr.RoundtripTime;
            }
            return (count/ timesToRunPing).ToString();
        }
    }
}
