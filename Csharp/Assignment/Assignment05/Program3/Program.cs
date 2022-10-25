using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Concession;


namespace Program3_05_
{
    internal class Program
    {
       static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Console.WriteLine("Enter name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age : ");
            class1.Age = Convert.ToInt32(Console.ReadLine());

            class1.CalculateConcession(class1.Age);
            Console.Read();

        }
    }
}
