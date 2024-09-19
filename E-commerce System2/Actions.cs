using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce_System2
{
    public class Actions
    {
        public virtual string AddToCart()
        {
            Console.WriteLine("Base");
            return null;
        }

        public virtual void CheckOut()
        {
            Console.WriteLine("Base");
        }

        public virtual void ViewOrderHistory(int idUser)
        {
            Console.WriteLine("Base");
        }
    }
}
