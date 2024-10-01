using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce_System2
{
    public class Cart : IAction
    {
        private HistoryOrderService order;
        private ProductsService products;

        public Cart()
        {
            products = new ProductsService();
            order = new HistoryOrderService();
        }

        public string AddToCart()
        {
            string yourCart = "Cosul tau contine:";
            int yourCartPrice = 0;

            bool continua = true;
            while(continua == true)
            {
                Console.WriteLine("Vrei sa mai adaugi in cos?");
                Console.WriteLine("==========================");
                string raspuns = Console.ReadLine();

                if(raspuns.Equals("Da"))
                {
                    Console.WriteLine("==========================");
                    Console.WriteLine("Ce produse vrei sa adaugi din (Suc, Sare, Paine, Mere) in cos ?");
                    string productWanted = Console.ReadLine();

                    string productName = products.ReturnName(productWanted);
                    int productPrice = products.ReturnPrice(productWanted);

                    if (productName != null)
                    {
                        Console.WriteLine($"Ai adaugat produsul {productName}, cu pretul {productPrice} ");
                        yourCart += ", " + productName + "cu pretul" + productPrice;

                        ProductsService productsService = new ProductsService();

                        productsService.ReduceStock(productName);

                        yourCartPrice += productPrice;
                        Console.WriteLine($"Total la cosul tau pana acum este de {yourCartPrice}");
                        Console.WriteLine("==========================");
                    }
                    else
                    {
                        Console.WriteLine("Produsul nu a fost gasit!");
                    }
                }
                else
                {
                continua = false;
                }
            }
            return yourCart;

        }

        public void CheckOut()
        {
            string yourCart = AddToCart();

            Console.WriteLine("Vrei sa plasezi comanda(Da sau Nu)?");
            string raspuns = Console.ReadLine();

            if (raspuns == "Da")
            {
                order.AddOrderByIdUser(yourCart);
            }
        }

        public void ViewOrderHistory(int idUser)
        {
            order.ViewOrderByIdCustomer(idUser);
        }

        
    }
}
