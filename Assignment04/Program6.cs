using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program6_04_
{
    //Create a Class called Doctor with RegnNo, Name, Feescharged as Private members.Allow values to be set and also to display the same.
     class Doctor
    { private int RegNo { get; set; }
        private string Name { get; set; }
        private int FeesCharged { get; set; }

        public void Set()
        {
            RegNo =Convert.ToInt32(  Console.ReadLine());
            Name = Console.ReadLine();
            FeesCharged = Convert.ToInt32(Console.ReadLine());
        }
        public void Get()
        {
            Console.WriteLine("Registration number is : "+RegNo);
            Console.WriteLine("Name is :"+Name);
            Console.WriteLine("Fees charged : "+FeesCharged);
        }
        static void Main(string[] args)
        {
            Doctor d = new Doctor();
            Console.WriteLine("enter registration number,name,Fess charged");
            d.Set();
            d.Get();
            Console.Read();
        }
    }
}
