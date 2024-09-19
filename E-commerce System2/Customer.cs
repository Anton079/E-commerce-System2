using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce_System2
{
    public class Customer
    {
        private int _id;
        private string _name;
        private string _shippingAddress;

        public Customer(int id, string name, string shippingAddress )
        {
            _id = id;
            _name = name;
            _shippingAddress = shippingAddress;
        }

        public Customer(string proprietati)
        {
            string[] token = proprietati.Split(',');

            _id = Int32.Parse(token[0]);
            _name = token[1];
            _shippingAddress = token[2];
        }

        public int Id { get { return _id; } set { _id = value; } }

        public string Name { get { return _name; } set { _name = value; } }

        public string ShippingAddress { get { return _shippingAddress; } set { _shippingAddress = value; } }


        public string CustomerInfo()
        {
            string text = " ";

            text += "Id " + Id + "\n";
            text += "Name " + Name + "\n";
            text += "Shipping Address: " + ShippingAddress + "\n";
            return text;
        }

        public string ToSave()
        {
            return Id + "," + Name + "," + ShippingAddress;
        }
    }
}
