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
    public partial class AddServer : Form
    {
        public string returnServerName;
        public string returnIPAddress;
        public AddServer()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(nameTextbox.Text == "" || ipTextbox.Text == "")
            {
                // TODO: tell user to fill in the information
            }
            else
            {
                returnServerName = nameTextbox.Text;
                returnIPAddress = ipTextbox.Text;
                this.Visible = false;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
