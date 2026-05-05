using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_ture_project
{
    public partial class Inventory : UserControl
    {
        List<String> Products = new List<string>();
        public Inventory()
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

        private void Inventory_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
