using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestPing.Forms
{
    public partial class DeleteItemForm : Form
    {
        public string itemToDelete;

        public DeleteItemForm(string itemName)
        {
            InitializeComponent();
            itemToDelete = itemName;
        }

        private void confirmDeleteButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void cancelDeleteButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
