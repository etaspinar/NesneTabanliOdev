using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta3_odev
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }

        public Product(int productId, string productName, int price)
        {
            ProductId = productId;
            ProductName = productName;
            Price = price;
        }

        public override string? ToString()
        {
            return $" {ProductId} {ProductName} {Price} ";
        }
    }
}
