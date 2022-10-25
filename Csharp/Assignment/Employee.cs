using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    class Employee
    {
        public int EmployeeId;
        public string FirstName;
        public string LastName;
        public string Title;
        public DateTime DOB;
        public DateTime DOJ;
        public string City;

        public Employee(int Eid, string Fn, string Ln, string Tit, string dob, string doj, string city)
        {
            EmployeeId = Eid;
            FirstName = Fn;
            LastName = Ln;
            Title = Tit;
            DOB = Convert.ToDateTime(dob);
            DOJ = Convert.ToDateTime(doj);
            City = city;

        }
        //a.Display detail of all the employee
        public string DisplayEmp()
        {
            Console.WriteLine("Employee Id         Firstname    Lastname     Title       DOB         DOJ       City ");
            return String.Format($" {EmployeeId}             {FirstName}        {LastName}         {Title}  {DOB.Date.ToShortDateString()}  {DOJ.Date.ToShortDateString()}  {City}");

        }

    }



    class Driver
    {
        static void Main(string[] args)
        {

            List<Employee> Emp = new List<Employee>();
            Emp.Add(new Employee(1001, "Malcolm", "Daruwalla", "Manager", "16/11/1984", "8/6/2011", "Mumbai"));
            Emp.Add(new Employee(1002, "Asdin", "Dhalla", "AsstManager", "20/08/1984", "7/7/2012", "Mumbai"));
            Emp.Add(new Employee(1003, "Madhavi", "Oza", "Consultant", "14/11/1987", "12/4/2015", "Pune"));
            Emp.Add(new Employee(1004, "Saba", "Shaikh", "SE", "3/6/1990", "2/2/2016", "Pune"));
            Emp.Add(new Employee(1005, "Nazia", "Shaikh", "SE", "8/3/1991", "2/2/2016", "Mumbai"));
            Emp.Add(new Employee(1006, "Amit", "Pathak", "Consultant", "7/11/1989", "8/8/2014", "Chennai"));
            Emp.Add(new Employee(1007, "Vijay", "Natrajan", "Consultant", "2/12/1989", "1/6/2015", "Mumbai"));
            Emp.Add(new Employee(1008, "Rahul", "Dubey", "Associate", "11/11/1993", "6/11/2014", "Chennai"));
            Emp.Add(new Employee(1009, "Suresh", "Mistry", "Associate", "12/8/1992", "3/12/2014", "Chennai"));
            Emp.Add(new Employee(1010, "Sumit", "Shah", "Manager", "12/4/1991", "2/1/2016", "Pune"));


            //a.Display detail of all the employee

            foreach (Employee e in Emp)
            {
                Console.WriteLine(e.DisplayEmp());
            }

            //b.Display details of all the employee whose location is not Mumbai
            IEnumerable<Employee> result = from a in Emp
                                           where a.City != "Mumbai"
                                           select a;
            foreach (Employee z in result)
            {
                Console.WriteLine(z.DisplayEmp());
            }

            //c.Display details of all the employee whose title is AsstManager
            var titl = Emp.Where(b => b.Title.Equals("AsstManager"));
            foreach (Employee y in titl)
            {
                Console.WriteLine(y.DisplayEmp());
            }

            //d. Display details of all the employee whose Last Name start with S
            var last = Emp.Where(c => c.LastName.StartsWith("S"));
            foreach (Employee x in last)
            {
                Console.WriteLine(x.DisplayEmp());
            }

            ////e.Display a list of all the employee who have joined before 1 / 1 / 2015 
            List<Employee> eml = (from d in Emp
                                  where d.DOB > DateTime.Parse("1/1/1990")
                                  select d).ToList();
            foreach (Employee w in eml)
            {
                Console.WriteLine(w.DisplayEmp());
            }

            //f. Display a list of all the employee whose date of birth is after 1/1/1990 

            List<Employee> empl = (from h in Emp
                                   where h.DOB > DateTime.Parse("1/1/1990")
                                   select h).ToList();
            foreach (Employee k in empl)
            {
                Console.WriteLine(k.DisplayEmp());
            }

            //g. Display a list of all the employee whose designation is Consultant and Associate
            IEnumerable<Employee> ca = from f in Emp
                                       where (f.Title == "Consultant" || f.Title == "Associate")
                                       select f;
            foreach (Employee u in ca)
            {
                Console.WriteLine(u.DisplayEmp());
            }

            ////h.Display total number of employees
            Console.WriteLine("Number of employees = " + Emp.Count);

            /////i.Display total number of employees belonging to “Chennai”
            IEnumerable<Employee> che = from i in Emp
                                        where i.City == "Chennai"
                                        select i;
            foreach (Employee w in che)
            {
                Console.WriteLine(w.DisplayEmp());
            }

            //j. Display highest employee id from the list
            Console.WriteLine("Hight employee ID = " + Emp.Max(g => g.EmployeeId));

            //k.Display total number of employee who have joined after 1 / 1 / 2015
            List<Employee> emp = (from j in Emp
                                  where j.DOJ > DateTime.Parse("1/1/2015")
                                  select j).ToList();
            foreach (Employee o in emp)
            {
                Console.WriteLine(o.DisplayEmp());
            }

            //l. Display total number of employee whose designation is not “Associate”
            IEnumerable<Employee> Asso = from k in Emp
                                         where k.Title != "Associate"
                                         select k;
            foreach (Employee t in Asso)
            {
                Console.WriteLine(t.DisplayEmp());
            }

            //m. Display total number of employee based on City
            var city = Emp.GroupBy(r => r.City);
            foreach (var s in city)
            {
                Console.WriteLine("{1} employee are based on {0}  ", s.Key, s.Count());
            }

            //n.Display total number of employee based on city and title
            //var ct = from e in Emp.GroupBy(x => new { x.City, x.Title })
            //         .OrderBy(y => y.Key.City).ThenBy(y => y.Key.Title)
            //         .Select(y => new
            //         {
            //             City = y.Key.City,
            //             Title = y.Key.Title
            //         });
            var N1 = Emp.GroupBy(n => n.City);
            var N2 = Emp.GroupBy(n => n.Title);
            Console.WriteLine("Based on City");
            foreach (var n1 in N1)
            {
                Console.WriteLine("{1} Employee are based on {0}  ", n1.Key, n1.Count());
            }
            Console.WriteLine("based on Title");
            foreach (var n2 in N2)
            {
                Console.WriteLine("{1} Employee are based on {0}  ", n2.Key, n2.Count());
            }



            //o.Display total number of employee who is youngest in the list
            Console.WriteLine("youngest one : "+Emp.Max(d => d.DOB));
           
        
            Console.Read();
        }
    }
}
