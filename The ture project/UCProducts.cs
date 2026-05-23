using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        private BindingList<Products> _inventoryList = new BindingList<Products>();
        private BindingSource _bindingSource = new BindingSource();

       // string filePath = "C:/Users/0348550/Downloads/Copy of shop-product-catalog - shop-product-catalog.csv";
        // string filePath = "C:/Users/jan/Downloads/Copy of shop-product-catalog - shop-product-catalog.csv";
        private string filePath = Path.Combine(AppContext.BaseDirectory, "Copy of shop-product-catalog - shop-product-catalog.csv");
        private void Button2_Click(object sender, EventArgs e)
        {
            //ADD
            if (!ValidateInputs()) return;

            // 2. Create the new product
            int newId = _inventoryList.Count + 1000;
            string name = txtName.Text;
            string brand = txtBrand.Text;
            decimal price = decimal.Parse(txtPrice.Text);
            int quantity = int.Parse(txtQuantity.Text);

            Products newProduct = new Products(newId, name, brand, price, quantity);
            _inventoryList.Add(newProduct);

            // 4. Refresh the grid to show the new item
            _bindingSource.ResetBindings(false);

            // 5. Clear fields for the next entry
            ClearFields();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //Update
            // 1. Check if a Product ID is present to identify the record
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

                    // 5. Refresh the grid to show the updated data
                    _bindingSource.ResetBindings(false);
                    dgvInventory.Refresh();

                    // 6. Clear input fields
                    ClearFields();
                    MessageBox.Show("Product updated successfully in the list.");
                }
            }
            else
            {
                MessageBox.Show("Product ID not found in inventory.");
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            //SAVE
            try
            {
                string path = filePath;

                // Convert the BindingList to a standard List to pass to the service
                List<Products> listToSave = _inventoryList.ToList();

                // Call the save method
                InventoryService.SaveToCSV(path, listToSave);

                MessageBox.Show("Changes saved to CSV successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            //DEL
            string searchTerm = txtDelete.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                MessageBox.Show("Please enter a Product ID or Name to delete.");
                return;
            }

            // Find the product in the BindingList
            // This checks if the ID matches OR if the Name matches (ignoring case)
            Products productToDelete = _inventoryList.FirstOrDefault(p =>
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

        private void UCProducts_Load(object sender, EventArgs e)
        {
            string path = filePath;

            // 1. Load the data into a temporary list
            var tempData = InventoryService.LoadFromCSV(path);

            // 2. Clear the BindingList and add the loaded data
            _inventoryList.Clear();
            foreach (var item in tempData)
            {
                _inventoryList.Add(item);
            }

            // 3. Bind the BindingList to the grid
            dgvInventory.DataSource = _inventoryList;
        }
        private bool ValidateInputs()
        {
            // Check if Name contains invalid special characters like #, $, @
            // This regex allows only letters, numbers, and spaces
            if (!Regex.IsMatch(txtName.Text, @"^[a-zA-Z0-9 ]+$"))
            {
                MessageBox.Show("Product Name contains invalid characters.");
                return false;
            }

            // Check if Price is a positive decimal
            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Please enter a valid positive price.");
                return false;
            }

            // Check if Quantity is a positive integer
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
        }

        private void DgvInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
