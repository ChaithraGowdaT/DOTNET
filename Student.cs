﻿/*2.Create a class called student which has data members like rollno, name, class, Semester, branch, int[] marks = new int marks [5] (marks of 5 subjects )

-Pass the details of student like rollno, name, class, SEM, branch in constructor
- For marks write a method called GetMarks() and give marks for all 5 subjects
-Write a method called displayresult, which should calculate the average marks
-If marks of any one subject is less than 35 print result as failed
-If marks of all subject is >35 but average is < 50 then also print result as failed
-If avg > 50 then print result as passed.
-Write a DisplayData() method to display all values.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3._1
{
     class Student

    {
        public int Rollno , Class , Semester,sub1,sub2,sub3,sub4,sub5 ;
        public string name, branch;

        public   Student(string nme,int cls,int sem,string brn, int Rn)
        {
            Console.WriteLine("enter the name of the student : ");
            nme = Console.ReadLine();
            Console.WriteLine("enter the class of the student : ");
            cls = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("enter the semester  : ");
            sem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the Branch : ");
            brn = Console.ReadLine();
            Console.WriteLine("enter the Roll No of the student : ");
            Rn = Convert.ToInt32(Console.ReadLine());
            Rollno = Rn;
            name = nme;
            Class = cls;
            Semester = sem;
            branch = brn;
        }

        public void Getmarks()
        {
            Console.WriteLine("Enter thw marks of 5 subjects : ");
             sub1 = Convert.ToInt32(Console.ReadLine());
             sub2 = Convert.ToInt32(Console.ReadLine());
             sub3 = Convert.ToInt32(Console.ReadLine());
             sub4 = Convert.ToInt32(Console.ReadLine());
             sub5 = Convert.ToInt32(Console.ReadLine());
            int[] marks = new int[5];
            marks[0] = sub1;
            marks[1] = sub2;
            marks[2] = sub3;
            marks[3] = sub4;
            marks[4] = sub5;
      
        }
        public void DisplayResults()
        { 
            int sum;
            float avg = 0.0F;
            sum = sub1 + sub2 + sub3 + sub4 + sub5;
            avg = (float)sum / 5;
            if (sub1 < 35)
            {
                Console.WriteLine("student is failed ");
            }
            else if (sub2 < 35)
            {
                Console.WriteLine("Student is failed ");
            }
            else if (sub3 < 35)
            {
                Console.WriteLine("Student is failed ");
            }
            else if (sub4 < 35)
            {
                Console.WriteLine("Student is failed ");
            }
            else if  (sub5 < 35)
            {
                Console.WriteLine("Student is failed ");
            }
            else if (sum>35 && avg <50)
            {
                Console.WriteLine("Student is failed ");
            }
            else if (avg>50)
            {
                Console.WriteLine("Student is passed");
            }
            
         

        }
        static void Main(string[] args)
        {
            Student student = new Student("",0,0,"",0);
            student.Getmarks();
            student.DisplayResults();
            Console.ReadLine();
           

        }
    }
}
