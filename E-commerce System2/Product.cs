using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce_System2
{
    public class Product
    {
        private int _id;
        private string _name;
        private int _price;
        private int _stock;

        public Product(int id, string name, int price, int stock)
        {
            _id = id;
            _name = name;
            _price = price;
            _stock = stock;
        }

        public Product(string proprietati)
        {
            string[] token = proprietati.Split(',');

            _id = Int32.Parse(token[0]);
            _name = token[1];
            _price = Int32.Parse(token[2]);
            _stock = Int32.Parse(token[3]);
        }

        public int Id { get { return _id; } set { _id = value; } }

        public string Name { get { return _name; } set { _name = value; } }

        public int Price { get { return _price; } set { _price = value; } }

        public int Stock { get { return _stock; } set { _stock = value; } }

        

        public string ProductInfo()
        {
            string text = " ";

            text += "Id: " + Id + "\n";
            text += "Name: " + Name + "\n";
            text += "Price: " + Price + "\n";
            text += "Stock: " + Stock + "\n";
            return text;
        }

        public string ToSave()
        {
            return Id + "," + Name + "," + Price + "," + Stock;
        }
    }
}
