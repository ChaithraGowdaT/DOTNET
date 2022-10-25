using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Create an Abstract class Student with Name, StudentId, Grade as members and also an abstract method Boolean Ispassed(grade) 
/// which takes grade as an input and checks whether student passed the course or not. 
/// Create 2 Sub classes Undergraduate and Graduate that inherits all members of the student and overrides Ispassed() method
/// For the UnderGrad class, if the grade is above 70.0, then isPassed returns true, otherwise it returns false. For the Grad class,
/// if the grade is above 80.0, then isPassed returns true, otherwise returns false.

/// </summary>

namespace Program1_05_
{
    abstract class Student
    {

        public string Name;
        public int StudentId;
        public double Grade;

        abstract public bool  Ispaased(double Grade);

    }
    class Undergraduate:Student
    {   
        public override bool Ispaased(double Grade)
        {

            this.Grade = Grade;

            if (Grade > 70.0)
                {
                    Console.WriteLine("student is passed");
                    return true;
                }

                else
                {
                    Console.WriteLine("student is failed ");
                    return true;
                }
            

        }
      

    }
    class Graduate : Student
    {     
        public override bool Ispaased(double Grade)
        {
            this.Grade = Grade;
            if (Grade > 80.0)
            {
                Console.WriteLine("student is passed");
                return true;
            }

            else
            {
                Console.WriteLine("student is failed ");
                return true;
            }
        }        
    }
    class Driver
    { 
        static void Main(string[] args)
        {
            Student student = new Undergraduate();
            Console.WriteLine(  "Enter youe Nmae:");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter student Id: ");
            int StudentId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Grade : ");
            double grd = Convert.ToDouble(Console.ReadLine());
            student.Ispaased(grd);
            Console.Read();
            

        }
    }
}
