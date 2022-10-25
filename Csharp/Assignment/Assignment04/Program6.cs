using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program6_04_
{   class class1
    {
        private int RegNo { get; set; }
        private string Name { get; set; }
        private int FeesCharged { get; set; }

        //public void Set()
        //{ }
        public int regno
        {
            get { return RegNo; }
            set { RegNo = value; }

        }
        public string name
        {
            get { return Name; }
            set { Name = value; }

        }
        public int Fcharged
        {
            get { return FeesCharged; }
            set { FeesCharged = value; }

        }




        public void Get()
        {
            Console.WriteLine("Registration number is : " + RegNo);
            Console.WriteLine("Name is :" + Name);
            Console.WriteLine("Fees charged : " + FeesCharged);
        }
    }
    internal class Doctor
    { 
        
            static void Main(string[] args)
        {

            class1 d = new class1();
            d.regno = 123;
            d.name = "Chaithra";
            d.Fcharged = 3000;
            d.Get();
            Console.Read();
        }
    }
}
