using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1_04_
{  
    class Program
    {
        public static void Display()
        {

            Console.WriteLine(" Enter the First name : ");
            string Firstname = Console.ReadLine();
            Console.WriteLine(" Enter the Last name : ");
            string Lastname = Console.ReadLine();
            Console.WriteLine("***Before Converting First & Last name***");
            Console.WriteLine(Firstname );
            Console.WriteLine(Lastname);
            Console.WriteLine("***After Converting First & Last name to upper case***");
            Console.WriteLine(Firstname.ToUpper());
            Console.WriteLine(Lastname.ToUpper());


        }
        static void Main(string[] args)
        {
            Program.Display();
            Console.Read();
        }
    }
}
