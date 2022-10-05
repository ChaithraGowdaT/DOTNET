using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Create a class called Customer with Customerid, Name, Age, Phone, City. Write a constructor with no arguments 
    and another constructor with all information.Write a method called DisplayCustomer(),
    
    which is called directly without any object. Also  include destructor*/

namespace Program4_04_
{
     class Customer
    {
        public int Customerid;
        public string Name;
        public int Age;
        public long Phone;
        public string City;
        public Customer()
        {

        }
        public Customer(int Cid,string nme,int age,long phone,string city)
        {
            Customerid = Cid;
            Name = nme;
            Age = age;
            Phone = phone;
            City = city;
        }
        public void DisplayDetails()
        {
            Console.WriteLine("customer id = "+Customerid);
            Console.WriteLine("customer name = " + Name);
            Console.WriteLine("customer age = " + Age);
            Console.WriteLine("Phone = " + Phone);
            Console.WriteLine("city = " + City);
 
        }
        ~Customer()
        {
            
        }

        
        static void Main(string[] args)
        {
            Customer c = new Customer(102,"Chaithra",25,8060232810,"Bangalore");
            c.DisplayDetails();
            Console.Read();

        }
    }
}
