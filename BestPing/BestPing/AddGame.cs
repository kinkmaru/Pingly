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
    public partial class AddGame : Form
    {
        public string returnGame;
        public AddGame()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(nameTextBox.Text == "")
            {
                // TODO: Tell user to fill in textbox
            }
            else
            {
                returnGame = nameTextBox.Text;
                this.Visible = false;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
