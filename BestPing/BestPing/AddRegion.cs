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
    public partial class AddRegion : Form
    {
        public string returnRegion;
        public AddRegion()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(nameTextbox.Text == "")
            {
                // TODO: tell user to fill in textbox
            }
            else
            {
                returnRegion = nameTextbox.Text;
                this.Visible = false;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
