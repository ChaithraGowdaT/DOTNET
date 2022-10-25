using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concession
{
    public class Class1
    {
        public int concession;
        public int totalfare = 500;
        public int Age;
        public int CalculateConcession(int age)
        {
            if (age <= 5)
            {
                Console.WriteLine(" Little champs - Free ticket ");
            }
            else if (age >= 60)
            {
                concession = totalfare * 30 / 100;
                int sub = totalfare - concession;
                Console.WriteLine("Senior citizen Rs.{0}",sub);

            }
            else
                Console.WriteLine("Ticket Booked Rs.{0} ",totalfare);
            return age;
        }
    }
}
