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
    public partial class UCProducts : UserControl
    {
        public UCProducts()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Inventory_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int maxCharacters = 15;
            String err = "";
            String contents = this.textBox1.Text;

            if (contents.Length == 0)
            {
                err = "I am sorry but the name cannot be empty";
           //     e.Cancel = true;
            }
            else if (!contents.Replace(" ", "").Equals(contents, StringComparison.OrdinalIgnoreCase))
            {
                err = "I am sorry but the name cannot contain spaces";
           //     e.Cancel = true;
            }
            else if (contents.Length > 15)
            {
                err = "I am sorry, but the name cannot have more than " + maxCharacters + " characters";
           //     e.Cancel = true;
            }

           // this.UCProductsErrorProvider.SetError(this.textBox1, err);
        }
    }
}
