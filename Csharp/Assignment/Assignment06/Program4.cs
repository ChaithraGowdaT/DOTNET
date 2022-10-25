using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Create a simple Stationery application to add items and display added items using Generic List collections
namespace Program_4_06_
{
    class Stationary
    {
        int No;
        string Name;
        double Price;

        public Stationary(int no, string name, double pri)
        {
            No = no;
            Name = name;
            Price = pri;
        }

        public  string ToString()
        {
            return String.Format($" {No} . Name of the item is :{Name}, and price of Rs.{Price}");


        }
    }

    class Dricver
    {
        static void Main(string[] args)
        {
            List<Stationary> emplist = new List<Stationary>();
            emplist.Add(new Stationary(1, "Pencil", 10));
            emplist.Add(new Stationary(2, "Book", 50));
            emplist.Add(new Stationary(3, "Bag", 1000));
            emplist.Add(new Stationary(4, "Box", 100));
            emplist.Add(new Stationary(5, "Table", 2000));
            emplist.Add(new Stationary(6, "Chair", 1500));


            foreach (Stationary e in emplist)
            {
                Console.WriteLine(e.ToString());
            }
            Console.Read();
        }
    }


}