using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta3_odev
{
    public class CartItem
    {
        public int CartId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public CartItem(int cartId, Product product, int quantity)
        {
            CartId = cartId;
            Product = product;
            Quantity = quantity;
        }

        public override string? ToString()
        {
            return $"{CartId,-10} {Product,-10} {Quantity,-10}";
        }
    }
}
