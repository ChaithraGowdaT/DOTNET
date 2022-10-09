using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Create an console application to book train tickets. Create a Passanger class with (Name, Age) and
/// write a function called  TicketBooking(int no_of_tickets) that takes no.of tickets to be booked.If the no of tickets is > 2 per booking,
/// raise an user defined exception, and print "cannot book more than 2 tickets".Else Print  "Ticket Booked Successfully". Add a Test class 
/// to call TicketBooking method by accepting all required details. 
/// </summary>

namespace TrainTicketBooking
{
    class Passenger
    {
        public string Name;
        public int Age;
        public int notickets;
        public void TicketBooking(int no_of_tickets)
        {
            if (no_of_tickets > 2)
            {
                throw (new IndexOutOfRangeException("cannot book more than 2 Tickets"));
            }
            else
            {
                Console.WriteLine("Ticket booked successfully");
            }
        }
    }
    class Test
    {
       
        public static void Main(string[] args)
        {
            Passenger passenger = new Passenger();
            Console.WriteLine("Enter the name of the passenger");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter the age of the passenger ");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter no of tickets to be booked ");
            passenger.notickets= Convert.ToInt32(Console.ReadLine());

            try
            {
                passenger.TicketBooking(passenger.notickets);
            }
            catch(IndexOutOfRangeException ie)
            {
                Console.WriteLine(ie.Message);
            }

           
            Console.ReadLine();

        }
    }
}
