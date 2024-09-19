using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce_System2
{
    public class ProductsService
    {
        private List<Product> product;

        public ProductsService()
        {
            product = new List<Product>();
            LoadData();
        }

        public void LoadData()
        {
            product.Add(new Product(1,"Suc",12,120) );
            product.Add(new Product(2, "Sare", 5, 312));
            product.Add(new Product(3, "Paine", 1, 421));
            product.Add(new Product(4, "Mere", 15, 51));
        }

        public bool SearchProduct(string productWanted)
        {
            foreach(Product x in product)
            {
                if(x.Name == productWanted)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Produsul nu este gasit in magazin!");
                }
            }
            return false;
        }

        public string ReturnName(string productName)
        {
            foreach(Product x in product)
            {
                if(x.Name == productName)
                {
                    return x.ProductInfo();
                }
            }
            return null;
        }

        public int ReturnPrice(string productName)
        {
            foreach (Product x in product)
            {
                if (x.Name == productName)
                {
                    return x.Price;
                }
            }
            return -1;
        }

        public void ReduceStock(string stockName)
        {
            foreach (Product x in product)
            {
                if (x.Name == stockName)
                {
                    x.Stock -= 1;
                }
            }
        }
    }
}
