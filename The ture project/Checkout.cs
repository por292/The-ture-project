using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_ture_project
{
    public partial class Checkout : UserControl
    {
        public Checkout()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Checkout_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowScreen(new UC_Orders());
        }
        private void ShowScreen(UserControl newScreen)
        {
            foreach (Control ctrl in pnlContent.Controls)
            {
                ctrl.Dispose();
            }

            pnlContent.Controls.Clear();
            newScreen.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(newScreen);
        }
    }
}
