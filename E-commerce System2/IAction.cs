using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce_System2
{
    public interface IAction
    {
        string AddToCart();

        void CheckOut();

        void ViewOrderHistory(int idUser);
    }
}