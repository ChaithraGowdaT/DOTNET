using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2_04_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string : ");
            string str = Console.ReadLine();
            Console.WriteLine("Enter Character to be count in a string : ");
            char sc = Convert.ToChar( Console.ReadLine());
            int freq = str.Count(f => (f == sc));
            Console.WriteLine("{0} appears, {1} times",sc,freq);
            Console.Read();
        }
        
          
  
        
    }
}


       
    