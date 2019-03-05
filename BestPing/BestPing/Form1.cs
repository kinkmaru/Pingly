using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestPing
{
    public partial class Form1 : Form
    {
        List<Game> gg = new List<Game>();
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearItems();
            string selectedGame = comboBox1.Text;
            List<Region> r = gg.Find(x => x.Name == selectedGame).Regions;
            foreach(Region region in r)
            {
                listView1.Items.Add(region.Name);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string s = "C:/Users/cupps/Desktop/ping-realms-project/testgames.xml";
            XMLReader x = new XMLReader();
            gg = x.ReadXmlFiles(s);

            foreach(Game g in gg)
            {
                comboBox1.Items.Add(g.Name);
            }

            comboBox2.Items.Add("1 - Fast");
            comboBox2.Items.Add("5 - Moderate");
            comboBox2.Items.Add("10 - Thorough");
            comboBox2.Items.Add("Custom");
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            objectListView1.ClearObjects();
            string selectedServer = listView1.SelectedItems[0].Text;
            List<Server> serv = gg.Find(x => x.Name == comboBox1.Text).Regions.Find(x => x.Name == selectedServer).Servers;
            Pinging ping = new Pinging();

            double totalServers = serv.Count();
            double pingProgressionCount = 0;
            label3.Text = "Progress: " + pingProgressionCount + "/" + totalServers;
            label3.Refresh();

            int timesToPing;
            if(textBox1.Enabled)
                timesToPing = Convert.ToInt32(new String(textBox1.Text.Where(Char.IsDigit).ToArray()));
            else
                timesToPing = Convert.ToInt32(new String(comboBox2.Text.Where(Char.IsDigit).ToArray()));

            foreach (Server server in serv)
            {
                server.Ping = ping.getAveragePing(server, timesToPing);
                int pingCompare = Convert.ToInt32((server.Ping));

                pingProgressionCount++;
                progressBar1.Value = Convert.ToInt32(Math.Floor(((pingProgressionCount / totalServers) * 100)));

                label3.Text = "Progress: " + pingProgressionCount + "/" + totalServers;
                label3.Refresh();
            }
            objectListView1.SetObjects(serv);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Custom")
                textBox1.Enabled = true;
            else
                textBox1.Enabled = false;
        }

        private void clearItems()
        {
            objectListView1.ClearObjects();
            listView1.Items.Clear();
        }
    }
}
