using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a class Box that has Length and breadth as its members.
 Write a function that adds 2 box objects and stores in the 3rd. Create a Test class to execute the above.*/



namespace CodebasedTest1
{
     class Box
    {
         public double Length;
        public double Breadth;

        public void Adds(double length,double breadth)
        {
            double Add = length + breadth;
            Console.WriteLine("The value is :"+Add);
        }
    }
    class Test
    {
        static void Main(string[ ] args)
        {
            
            Box box = new Box();
            Console.WriteLine("Enter the Length of the Box :");
            box.Length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Breadth of the Box :");
            box.Breadth = Convert.ToDouble(Console.ReadLine());
            box.Adds(box.Length,box.Breadth);
            Console.ReadLine();
        }
    }
}
