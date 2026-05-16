using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace The_ture_project
{
    public partial class UC_Orders : UserControl
    {
        private BindingList<Products> _availableProducts;
        private BindingList<OrderItem> _currentOrderItems = new BindingList<OrderItem>();
        //private string _csvPath = "C:/Users/jan/Downloads/Copy of shop-product-catalog - shop-product-catalog.csv";
        private string _csvPath = "C:/Users/0348550/Downloads/Copy of shop-product-catalog - shop-product-catalog.csv";
        public UC_Orders()
        {
            InitializeComponent();
            SetupOrderSystem();
        }
        public class OrderItem  
        {
            public int ProductID { get; set; }
            public string ProductName { get; set; }
            public decimal UnitPrice { get; set; }
            public int Quantity { get; set; }
            public decimal Subtotal => UnitPrice * Quantity;
        }

       public class Order
        {
            public string OrderName { get; set; }
            public string Description { get; set; }
            public DateTime OrderDate { get; set; }
            public List<OrderItem> Items { get; set; } = new List<OrderItem>();
            public decimal TotalAmount { get; set; }
        }
        private void SetupOrderSystem()
        {
            // Apply these settings to the Inventory grid
            dgvAvailable.ReadOnly = true;
            dgvAvailable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAvailable.MultiSelect = false; // Prevents selecting multiple rows at once

            // Apply these settings to the Current Order grid
            dgvCurrentOrder.ReadOnly = true;
            dgvCurrentOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCurrentOrder.MultiSelect = false;

            // Configure Inventory Grid (Left)
            dgvAvailable.AutoGenerateColumns = false;
            dgvAvailable.Columns.Clear();
            dgvAvailable.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ProductID", HeaderText = "ID", Name = "colID", Width = 50 });
            dgvAvailable.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ProductName", HeaderText = "Product Name", Name = "colName", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });

            // Configure Current Order Grid (Right)
            dgvCurrentOrder.AutoGenerateColumns = false;
            dgvCurrentOrder.Columns.Clear();
            dgvCurrentOrder.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ProductID", HeaderText = "ID", Width = 50 });
            dgvCurrentOrder.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ProductName", HeaderText = "Product", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvCurrentOrder.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "UnitPrice", HeaderText = "Price", DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" } });
            dgvCurrentOrder.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Quantity", HeaderText = "Qty", Width = 50 });
            dgvCurrentOrder.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Subtotal", HeaderText = "Subtotal", DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" } });

            dgvCurrentOrder.DataSource = _currentOrderItems;
            dgvCurrentOrder.AllowDrop = true;
        }
        private void UC_Orders_Load(object sender, EventArgs e)
        {
            try
            {
                var products = InventoryService.LoadFromCSV(_csvPath);
                _availableProducts = new BindingList<Products>(products);
                dgvAvailable.DataSource = _availableProducts;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load inventory: " + ex.Message);
            }
        }

        // Drag and Drop implementation
        private void dgvAvailable_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void dgvCurrentOrder_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Products)))
                e.Effect = DragDropEffects.Copy;
        }

        private void dgvCurrentOrder_DragDrop(object sender, DragEventArgs e)
        {
            Products droppedProduct = (Products)e.Data.GetData(typeof(Products));
            AddProductToOrder(droppedProduct);
        }

        private void AddProductToOrder(Products product)
        {
            var existingItem = _currentOrderItems.FirstOrDefault(i => i.ProductID == product.ProductID);

            if (existingItem != null)
            {
                existingItem.Quantity++;
            }
            else
            {
                _currentOrderItems.Add(new OrderItem
                {
                    ProductID = product.ProductID,
                    ProductName = product.ProductName,
                    UnitPrice = product.ProductPrice,
                    Quantity = 1
                });
            }

            _currentOrderItems.ResetBindings();
            UpdateTotal();
        }

        private void UpdateTotal()
        {
            decimal total = _currentOrderItems.Sum(i => i.Subtotal);
            lblTotal.Text = $"Total: ${total:F2}";
        }

        // 20-word limit validation
        private bool IsDescriptionValid(string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return true;
            string[] words = text.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length <= 20;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ShowScreen(new Checkout());
            if (string.IsNullOrWhiteSpace(txtOrderName.Text))
            {
                MessageBox.Show("Please enter an order name.");
                return;
            }

            if (!IsDescriptionValid(txtDescription.Text))
            {
                MessageBox.Show("Description must be 20 words or less.");
                return;
            }

            if (_currentOrderItems.Count == 0)
            {
                MessageBox.Show("The order list is empty.");
                return;
            }

            Order newOrder = new Order
            {
                OrderName = txtOrderName.Text,
                Description = txtDescription.Text,
                OrderDate = DateTime.Now,
                Items = _currentOrderItems.ToList(),
                TotalAmount = _currentOrderItems.Sum(i => i.Subtotal)
            };

            try
            {
                string fileName = $"Order_{newOrder.OrderName}_{DateTime.Now:yyyyMMdd_HHmm}.json";

                // Serialize using System.Text.Json
                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(newOrder, options);

                File.WriteAllText(fileName, jsonString);

                MessageBox.Show("Order saved to JSON file successfully.");
                ResetOrderForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving order: " + ex.Message);
            }
        }
        //hi
        private void ResetOrderForm()
        {
            _currentOrderItems.Clear();
            txtOrderName.Clear();
            txtDescription.Clear();
            UpdateTotal();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvAvailable.SelectedRows.Count > 0)
            {
                // Get the selected product object from the inventory grid
                Products selectedProduct = (Products)dgvAvailable.SelectedRows[0].DataBoundItem;

                // Use the existing logic to add it to the order
                AddProductToOrder(selectedProduct);
            }
            else
            {
                MessageBox.Show("Please select a product from the inventory list first.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvCurrentOrder.SelectedRows.Count > 0)
            {
                // Get the item selected in the order grid
                OrderItem itemToRemove = (OrderItem)dgvCurrentOrder.SelectedRows[0].DataBoundItem;

                // Remove it from the BindingList
                _currentOrderItems.Remove(itemToRemove);

                // Refresh grid and total cost
                _currentOrderItems.ResetBindings();
                UpdateTotal();
            }
            else
            {
                MessageBox.Show("Please select an item in your current order to remove.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_currentOrderItems.Count == 0) return;

            // Create the Order object
            Order myOrder = new Order
            {
                OrderName = txtOrderName.Text,
                Description = txtDescription.Text,
                OrderDate = DateTime.Now,
                Items = _currentOrderItems.ToList(),
                TotalAmount = _currentOrderItems.Sum(i => i.Subtotal)
            };

            // Serialize to JSON string
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonContent = JsonSerializer.Serialize(myOrder, options);

            // Save to file
            string fileName = $"Order_{myOrder.OrderName}.json";
            File.WriteAllText(fileName, jsonContent);

            MessageBox.Show("Order saved successfully.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "JSON files (*.json)|*.json",
                Title = "Open Order File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Read file content
                    string jsonContent = File.ReadAllText(openFileDialog.FileName);

                    // Deserialize back into an Order object
                    Order loadedOrder = JsonSerializer.Deserialize<Order>(jsonContent);

                    // Populate the UI fields
                    txtOrderName.Text = loadedOrder.OrderName;
                    txtDescription.Text = loadedOrder.Description;

                    // Clear current list and add loaded items
                    _currentOrderItems.Clear();
                    foreach (var item in loadedOrder.Items)
                    {
                        _currentOrderItems.Add(item);
                    }

                    UpdateTotal();
                    MessageBox.Show("Order loaded successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading file: " + ex.Message);
                }
            }
        }
        private void ShowScreen(UserControl newScreen)
        {
            foreach (Control ctrl in pnlContent1.Controls)
            {
                ctrl.Dispose();
            }

            pnlContent1.Controls.Clear();
            newScreen.Dock = DockStyle.Fill;
            pnlContent1.Controls.Add(newScreen);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvAvailable_MouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvAvailable.SelectedRows.Count > 0)
            {
                var product = (Products)dgvAvailable.SelectedRows[0].DataBoundItem;
                dgvAvailable.DoDragDrop(product, DragDropEffects.Copy);
            }
        }

        private void dgvCurrentOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvAvailable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtOrderName_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
