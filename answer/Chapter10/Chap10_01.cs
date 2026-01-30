using System;

namespace Chap10_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var sale = new Sale
            {
                ProductName = "商品A",
                UnitPrice = 1300,
                Quantity = 4
            };
            Console.WriteLine(sale.ProductName);
            Console.WriteLine(sale.UnitPrice);
            Console.WriteLine(sale.Quantity);
        }
    }

    class Sale
    {
        private int _unitPrice;
        private int _quantity;
        private string _productName;

        public string ProductName
        {
            get { return _productName; }  // このように1行に書くこともできる
            set { _productName = value; }
        }

        public int UnitPrice
        {
            get { return _unitPrice; }
            set { _unitPrice = value; }
        }

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
    }
}
