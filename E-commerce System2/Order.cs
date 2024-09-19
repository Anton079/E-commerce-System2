using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce_System2
{
    public class Order
    {
        private int _id;
        private int _idUser;
        private string _nameCustomer;
        private string _emailCustomer;
        private string _productsOrder;

        public Order( int id, int idUser, string nameCustomer, string emailCustomer, string productsOrder)
        {
            _id = id;
            _idUser = idUser;
            _nameCustomer = nameCustomer;
            _emailCustomer = emailCustomer;
            _productsOrder = productsOrder;
        }

        public Order(string proprietati)
        {
            string[] token = proprietati.Split(',');

            _id = Int32.Parse(token[0]);
            _idUser = Int32.Parse(token[1]);
            _nameCustomer = token[2];
            _emailCustomer = token[3];
            _productsOrder = token[4];
        }

        public int Id { get { return _id; } set { _id = value; } }

        public int IdUser { get { return _idUser; } set { _idUser = value; } } 

        public string NameCustomer { get { return _nameCustomer; } set { _nameCustomer = value; } }

        public string EmailCustomer { get { return _emailCustomer; } set { _emailCustomer = value; } }

        public string ProductOrder { get { return _productsOrder; } set { _productsOrder = value; } }

        public string HistoryOrderInfo()
        {
            string text = " ";

            text += "Id " + Id + "\n";
            text += "IdUser " + IdUser + "\n0";
            text += "Name Customer " + NameCustomer + "\n";
            text += " Email Customer " + EmailCustomer + "\n";
            text += "Product Order " + ProductOrder + "\n";
            return text;
        }

        public string ToSave()
        {
            return Id + "," + IdUser + "," + NameCustomer + "," + EmailCustomer + "," + ProductOrder;
        }

    }
}
