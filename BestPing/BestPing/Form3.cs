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
    public partial class Form3 : Form
    {
        private static Form1 form1;
        private static Form2 form2;
        public Form3()
        {
            InitializeComponent();
        }

        private void pingServersButton_Click(object sender, EventArgs e)
        {
            if(form1 == null || form1.IsDisposed)
                form1 = new Form1();

            form1.Show();
            form1.Focus();
        }

        private void editGameListButton_Click(object sender, EventArgs e)
        {
            if (form2 == null || form2.IsDisposed)
                form2 = new Form2();

            form2.Show();
            form2.Focus();
        }
    }
}
