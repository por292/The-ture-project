using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace The_ture_project
{
    public partial class UCProducts : UserControl
    {
        List<String> Products = new List<string>();
        public UCProducts()
        {
            InitializeComponent();
            using (StreamReader sr = new StreamReader("C:/Users/0348550/Downloads/Copy of shop - product - catalog - shop - product - catalog.csv"))

            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    Products.Add(line);
                }


            }
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


        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
