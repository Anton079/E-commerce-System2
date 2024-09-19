using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce_System2
{
    public class HistoryOrderService
    {
        private List<Order> _order;

        public HistoryOrderService()
        {
            _order = new List<Order>();
            LoadData();
        }

        public void LoadData()
        {
            try
            {
                using (StreamReader sr = new StreamReader(GetFilePath()))
                {
                    string line = " ";
                    while ((line = sr.ReadLine()) != null)
                    {
                          _order.Add(new Order(line)); 
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public string GetFilePath()
        {
            string currentDirectory = Directory.GetCurrentDirectory();

            string folder = Path.Combine(currentDirectory, "data");

            string file = Path.Combine(folder, "HistoryOrder");

            return file;
        }

        public string ToSaveAll()
        {
            string save = "";

            for (int i = 0; i < _order.Count; i++)
            {
                save += _order[i].ToSave();

                if (i < _order.Count - 1)
                {
                    save += "\n";
                }
            }

            return save;
        }


        public void SaveData()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(GetFilePath()))
                {
                    sw.WriteLine(ToSaveAll());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        //CRUD

        public void AddOrderByIdUser(string historyOrder)
        {
            if(historyOrder != null)
            {
                int newId = GenerateId();

                Order newOrder = new Order(newId ,12 ,"Flavius" ,"Flavius@gmail.com",historyOrder );
                _order.Add(newOrder);
                SaveData();
            }
            
        }

        public void ViewOrderByIdCustomer(int idUser)
        {
            foreach(Order x in _order)
            {
                if(x.IdUser == idUser)
                {
                    Console.WriteLine($"Cosul cu idul{x.Id} cu cumparatorul {x.NameCustomer} contine "+ x.ProductOrder);
                }
            }
        }

        public int GenerateId()
        {
            Random rand = new Random();

            int id = rand.Next(1, 10000000);

            while (FindOrderById(id) != -1)
            {
                id = rand.Next(1, 10000000);
            }


            return id;
        }

        public int FindOrderById(int idWanted)
        {
            for (int i = 0; i < _order.Count; i++)
            {
                if (_order[i].Id == idWanted)
                {
                    return _order[i].Id;
                }
            }
            return -1;
        }

        

    }
}
