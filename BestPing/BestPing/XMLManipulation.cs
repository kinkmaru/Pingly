using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BestPing
{
    public class XMLManipulation
    {
        public List<Game> ReadXmlFile(string xmlFile)
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

        public void WriteXMLFile(string fileLocation, List<Game> gameList)
        {
            XmlWriterSettings settings = new XmlWriterSettings()
            {
                Indent = true
            };

            XmlWriter xmlWriter = XmlWriter.Create(fileLocation, settings);

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("games");

            foreach (Game game in gameList)
            {
                xmlWriter.WriteStartElement("game");
                xmlWriter.WriteAttributeString("name", game.Name);

                foreach(Region region in game.Regions)
                {
                    xmlWriter.WriteStartElement("region");
                    xmlWriter.WriteAttributeString("name", region.Name);

                    foreach(Server server in region.Servers)
                    {
                        xmlWriter.WriteStartElement("server");
                        xmlWriter.WriteAttributeString("name", server.Name);
                        xmlWriter.WriteAttributeString("ip", server.Ip);
                        xmlWriter.WriteEndElement();
                    }
                    xmlWriter.WriteEndElement();
                }
                xmlWriter.WriteEndElement();
            }

            xmlWriter.WriteEndDocument();
            xmlWriter.Close();
        }
    }
}
