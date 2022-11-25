using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta3_odev
{
    public class ShoppingCart
    {
        List<CartItem> cartItems = new List<CartItem>();

        public void Add(CartItem cartItem)
        {
            cartItems.Add(cartItem);
        }
        public void GetList()
        {
            foreach (var item in cartItems)
            {
                Console.WriteLine(item);
            }
        }
        public void GetBalance()
        {
            int total = 0;
            for (int i = 0; i < cartItems.Count; i++)
            {
                total += cartItems[i].Quantity * cartItems[i].Product.Price;
            }
            Console.WriteLine("Total: {0}",total);
        }

        public void Remove(CartItem cartItem)
        {
            cartItems.Remove(cartItem);
        }

    }
}
