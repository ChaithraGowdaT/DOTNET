using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Create a class called Scholarship which has int Totalmarks and float fees as fields and a function Public float Merit(int m, float f) 
   that takes Totalmarks and fees as an input.
 
If the given marks is >= 70 and <=80, then calculate scholarship amount as 20% of the fees
If the given mark is > 80 and <=90, then calculate scholarship amount as 30% of the fees
If the given mark is >90, then calculate scholarship amount as 50% of the fees.
In all the cases return the Scholarship amount*/

namespace Program5_04_
{
    class Scholarship
    {
        public int Totalmarks;
        public float Fees;
        public double  Scholarshipamt;

        public  float Merit(int m,float f)
        {
            if(m>=70 && m<=80)
            {
                Scholarshipamt = f*0.2;
                Console.WriteLine("Schlorship amount is : " + Scholarshipamt);
                
            }
          
             else if (m>80  && m<= 90)
            {
                Scholarshipamt = f * 0.3;
                Console.WriteLine("Schlorship amount is : "+Scholarshipamt);
               
            }
            else if (m >90)
            {
                Scholarshipamt = f * 0.5;
                Console.WriteLine("Schlorship amount is : " + Scholarshipamt);
    
            }
            else

            {
                Console.WriteLine("Not eligible for scholar ship");
                Console.WriteLine("Schlorship amount is : " + Scholarshipamt);
             
            }

           return (float)Scholarshipamt;
        }
        
        static void Main(string[] args)
        {   
            Scholarship a = new Scholarship();
            Console.WriteLine("Enter total marks = ");
            a.Totalmarks = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter the fees = ");
            a.Fees = Convert.ToInt32(Console.ReadLine());
            a.Merit(a.Totalmarks,a.Fees);
            Console.Read();
        }
    }
}
