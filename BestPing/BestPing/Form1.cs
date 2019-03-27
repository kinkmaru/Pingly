using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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
            ResetForm();
            string selectedGame = comboBox1.Text;
            List<Region> r = gg.Find(x => x.Name == selectedGame).Regions;
            foreach(Region region in r)
            {
                listView1.Items.Add(region.Name);
            }
            comboBox2.Enabled = true;
            listView1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisableAll();
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
            if(numericUpDown1.Enabled)
                timesToPing = Convert.ToInt32(numericUpDown1.Value);
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

                objectListView1.AddObject(server); 
            }

            Status.ImageGetter = delegate (object rowObject)
            {
                Server s = (Server)rowObject;
                int p = Convert.ToInt32(s.Ping);
                if (p < 50)
                    return Properties.Resources.GreenDot;
                if (p > 50 && p < 101)
                    return Properties.Resources.YellowDot;
                if (p > 100 && p < 201)
                    return Properties.Resources.OrangeDot;

                return Properties.Resources.RedDot;
            };

            objectListView1.RebuildColumns();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Custom")
                numericUpDown1.Enabled = true;
            else
                numericUpDown1.Enabled = false;
        }

        private void ResetForm()
        {
            objectListView1.ClearObjects();
            listView1.Items.Clear();
            comboBox2.SelectedIndex = 0;
        }

        private void DisableAll()
        {
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            listView1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "XML Files (*.xml)|*xml",
                Multiselect = false,
                Title = "Select XML File"
            };

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                label5.Text = ofd.SafeFileName;

                string s = ofd.FileName;
                XMLReader x = new XMLReader();
                gg = x.ReadXmlFiles(s);

                comboBox1.Items.Clear();
                foreach (Game g in gg)
                {
                    comboBox1.Items.Add(g.Name);
                }

                comboBox1.Text = "<Options>";
                DisableAll();
                comboBox1.Enabled = true;
                ResetForm();
            }
        }
    }
}
