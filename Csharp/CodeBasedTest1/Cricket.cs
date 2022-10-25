using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// CodeBased Test 1

///Solve the below 2 questions in VS 2019 and push it into your Github.

///1. Write a program to find the Sum and the Average points scored by the teams in the IPL. 
///Create a Class called Cricket that has a function called Pointscalculation(int no_of_matches) 
///that takes no.of matches as input and accepts that many scores from the user. The function should then 
///display the Average and Sum of the scores.

///35 mts

///2. Write a class Box that has Length and breadth as its members.
///Write a function that adds 2 box objects and stores in the 3rd. Create a Test class to execute the above.

/// </summary>

namespace CodebasedTest1
{
    class Cricket
    {
        Cricket cricket = new Cricket();



        public static List<int> PointsCalculation(int no_of_matches)
        {
            int average;
            int sum = 0;



            List<int> scores = new List<int>();



            for (int i = 1; i <= no_of_matches; i++)
            {
                Console.WriteLine("Enter the score for match {0}: ", i);
                int marks = Convert.ToInt32(Console.ReadLine());
                scores.Add(marks);
            }



            foreach (int s in scores)
            {
                sum = sum + s;
            }



            void Avgcal(int Total, int match)
            {
                Console.WriteLine("The Total score of all matches are: " + sum);
                average = sum / no_of_matches;
                Console.WriteLine("The avg score is: " + average);
            }



            Avgcal(sum, no_of_matches);



            return scores.ToList();
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number of matches: ");
            int match = Convert.ToInt32(Console.ReadLine());
            Cricket.PointsCalculation(match);
            Console.ReadKey();
        }
    }
}