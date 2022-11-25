using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Product : IProduct,IComparable<Product>
    {
        private int _productId;
        private string _productName;
        private decimal _unitPrice;
        private Int16 _unitStock;

        private List<Product> _productList;

        public Product()
        {
            _productList = new List<Product>();
        }

        public Product(int productId, string productName, decimal unitPrice, short unitInStock)
        {
            ProductId = productId;
            ProductName = productName;
            UnitPrice = unitPrice;
            UnitInStock = unitInStock;
        }

        public int ProductId { get => _productId; set => _productId = value; }
        public string ProductName { get => _productName; set => _productName = value; }
        public decimal UnitPrice { get => _unitPrice; set => _unitPrice = value; }

        public Int16 UnitInStock { get => _unitStock; set => _unitStock = value; }

        public int CompareTo(Product? other)
        {
            return UnitPrice.CompareTo(other.UnitPrice);
        }

        public void Add(Product product)
        {
            _productList.Add(product);
        }
        public void GetProduct()
        {
            _productList.Sort();
            for (int i = 0; i < _productList.Count; i++)
            {
                Console.WriteLine($"{_productList[i]._productId} {_productList[i]._productName} {_productList[i]._unitPrice}  {_productList[i]._unitStock}");
            }
        }

        public decimal GetProductPrice(int id)
        {
            foreach (var item in _productList)
            {
                if (item.ProductId == id)
                {
                    _unitPrice = item.UnitPrice;
                    Console.WriteLine("price: {0}",_unitPrice);
                }
            }
            return _unitPrice;
        }
    }
}
    
 
 
