using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_ture_project
{
    internal class Products
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductBrand { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductQuantity { get; set; }

        public Products(int id, string name, string brand, decimal price, int quantity)
        {
            ProductID = id;
            ProductName = name;
            ProductBrand = brand;
            ProductPrice = price;
            ProductQuantity = quantity;
        }
    }
    
}
