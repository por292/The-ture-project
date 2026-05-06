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

        private BindingList<UCProducts> _inventoryList = new BindingList<UCProducts>();
        private BindingSource _bindingSource = new BindingSource();
        string filePath = "C:/Users/0348550/Downloads/Copy of shop-product-catalog - shop-product-catalog.csv";

        public UCProducts(int id, string name, string brand, decimal price, int quantity)
        {
            InitializeComponent();
        }
       

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

       /* private void Inventory_Load(object sender, EventArgs e)
        {
            string path = filePath;


            var tempData = InventoryService.LoadFromCSV(path);
            _inventoryList.Clear();
            foreach (var item in tempData)
            {
                _inventoryList.Add(item);
            }
            dvgInventory.DataSource = _inventoryList;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
       

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtID.Text, out int idToUpdate))
            {
                MessageBox.Show("Please select a product from the grid to update.");
                return;
            }

            // 2. Find the product in the BindingList using the ID
            var productToUpdate = _inventoryList.FirstOrDefault(p => p.ProductID == idToUpdate);

            if (productToUpdate != null)
            {
                // 3. Validate the new inputs before applying changes
                if (ValidateInputs())
                {
                    // 4. Update the object properties (excluding ProductID)
                    productToUpdate.ProductName = txtName.Text;
                    productToUpdate.ProductBrand = txtBrand.Text;
                    productToUpdate.ProductPrice = decimal.Parse(txtPrice.Text);
                    productToUpdate.ProductQuantity = int.Parse(txtQuantity.Text);

                    
                    _bindingSource.ResetBindings(false);
                    dgvInventory.Refresh();

                    
                    ClearFields();
                    MessageBox.Show("Product updated successfully in the list.");
                }
            }
            else
            {
                MessageBox.Show("Product ID not found in inventory.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string searchTerm = txtDelete.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                MessageBox.Show("Please enter a Product ID or Name to delete.");
                return;
            }

            
            Product productToDelete = _inventoryList.FirstOrDefault(p =>
                p.ProductID.ToString() == searchTerm ||
                p.ProductName.Equals(searchTerm, StringComparison.OrdinalIgnoreCase));

            if (productToDelete != null)
            {
                // Confirm deletion with the user
                DialogResult result = MessageBox.Show($"Are you sure you want to delete {productToDelete.ProductName}?",
                    "Confirm Delete", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Remove from the BindingList (the grid will update automatically)
                    _inventoryList.Remove(productToDelete);



                    txtDelete.Clear();
                    MessageBox.Show("Product deleted successfully.");
                }
            }
            else
            {
                MessageBox.Show("No product found matching that ID or Name.");
            }
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            string searchTerm = txtDelete.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                MessageBox.Show("Please enter a Product ID or Name to delete.");
                return;
            }

            Product productToDelete = _inventoryList.FirstOrDefault(p =>
                p.ProductID.ToString() == searchTerm ||
                p.ProductName.Equals(searchTerm, StringComparison.OrdinalIgnoreCase));

            if (productToDelete != null)
            {
                // Confirm deletion with the user
                DialogResult result = MessageBox.Show($"Are you sure you want to delete {productToDelete.ProductName}?",
                    "Confirm Delete", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Remove from the BindingList (the grid will update automatically)
                    _inventoryList.Remove(productToDelete);



                    txtDelete.Clear();
                    MessageBox.Show("Product deleted successfully.");
                }
            }
            else
            {
                MessageBox.Show("No product found matching that ID or Name.");
            }
        }
        private bool ValidateInputs()
        {

            if (!Regex.IsMatch(txtName.Text, @"^[a-zA-Z0-9 ]+$"))
            {
                MessageBox.Show("Product Name contains invalid characters.");
                return false;
            }


            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Please enter a valid positive price.");
                return false;
            }

            if (!int.TryParse(txtQuantity.Text, out int qty) || qty < 0)
            {
                MessageBox.Show("Please enter a valid positive quantity.");
                return false;
            }

            return true;
        }
        private void ClearFields()
        {
            txtID.Clear();
            txtName.Clear();
            txtBrand.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
        }*/
    }
    
}
