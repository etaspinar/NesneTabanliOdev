using Hafta3_odev;

Product product1 = new Product(12,"Hp",18000);
Product product2 = new Product(14,"Lenovo",25000);
Product product3 = new Product(17,"Casper",15000);
Product product4 = new Product(5,"Dell",17000);

CartItem cartItem1 = new CartItem(14,product2,5);
CartItem cartItem2 = new CartItem(12,product1,10);
CartItem cartItem3 = new CartItem(17,product3,3);
CartItem cartItem4 = new CartItem(5,product4,2);

ShoppingCart cart = new ShoppingCart();
cart.Add(cartItem1);    
cart.Add(cartItem2);
cart.Add(cartItem3);
cart.Add(cartItem4);

cart.GetList();
cart.GetBalance();
cart.Remove(cartItem4);
Console.WriteLine("\n");
cart.GetList();
cart.GetBalance();