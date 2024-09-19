using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce_System2
{
    public class CustomerService
    {
        private List<Customer> customer;

        public CustomerService()
        {
            customer = new List<Customer>();
            LoadData();
        }

        public void LoadData()
        {
            customer.Add(new Customer(1, "Anton", "Str.Primaveri"));
            customer.Add(new Customer(2, "Marius", "Str.Pantelimon"));
            customer.Add(new Customer(3, "Ioan", "Str.Ritmului"));
            customer.Add(new Customer(4, "Oana", "Str.Patimei"));
        }

        public Customer ReturnCustomerById(int idCustomer)
        {
            foreach(Customer x in customer)
            {
                if(x.Id == idCustomer)
                {
                    return x;
                }
                else
                {
                    Console.WriteLine("Customerul nu a fost gasit!");
                }
            }
            return null;
        }

    }
}
