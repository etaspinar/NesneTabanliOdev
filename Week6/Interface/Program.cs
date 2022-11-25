using Interface;

Product product1 = new Product(1, "Lenovo Legion", 15000, 3);
Product product2 = new Product(5, "Casper", 14000, 8);
Product product3 = new Product(4, "Monster", 13000, 7);
Product product4 = new Product(7, "Hp Pavilion", 19000, 10);


Product productList = new Product();

productList.Add(product1);
productList.Add(product2);
productList.Add(product3);
productList.Add(product4);

productList.GetProduct();
Console.WriteLine("");
productList.GetProductPrice(7);






