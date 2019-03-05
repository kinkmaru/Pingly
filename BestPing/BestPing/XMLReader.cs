using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BestPing
{
    public class XMLReader
    {
        public List<Game> ReadXmlFiles(string xmlFile)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlFile);
            //xmlDoc.Load("C:/Users/cupps/Desktop/ping-realms-project/testgames.xml");
            XmlNodeList xmlGames = xmlDoc.SelectNodes("games/game");

            List<Game> games = new List<Game>();

            foreach (XmlNode game in xmlGames)
            {
                Game g = new Game();
                g.Name = game.Attributes["name"].Value;
                foreach (XmlNode region in game)
                {
                    Region reg = new Region();
                    reg.Name = region.Attributes["name"].Value;

                    foreach(XmlNode server in region)
                    {
                        Server serv = new Server();
                        serv.Name = server.Attributes["name"].Value;
                        serv.Ip = server.Attributes["ip"].Value;
                        reg.Servers.Add(serv);
                    }
                    g.Regions.Add(reg);
                }
                games.Add(g);
            }
            return games;
        }
    }
}
