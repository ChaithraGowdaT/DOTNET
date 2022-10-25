using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 4. Create an Interface IStudent with int StudentId and string Name as Properties, void ShowDetails() as its method.
/// Create 2 classes Dayscholar and Resident that implements the interface Properties and Methods.ShowDetails() should show DaysScholar details
///  and Resident Details accordingly.
/// </summary>

namespace Program4_05_
{
    interface IStudent
    {
        int StudentId { get; set; }
        string Name { get; set; }

       

    }

    class Dayscholar : IStudent
    {
        public int Age { get; set; }

        public int Stuid1;
        public string nme1;
        public int StudentId
        {
            get { return Stuid1; }
            set { Stuid1 = value; }
        }
        public string Name
        {
            get { return nme1; }
            set { nme1 = value; }
        }
         public void ShowDetails()
        {
            Console.WriteLine("{0} student id and name is {1} of age {2} is Dayscholar",Stuid1,nme1,Age);
        }
    }
    class Resident:IStudent
    {
        public int Age2 { get; set; }

        public int Stuid2;
        public string nme2;
        public int StudentId
        {
            get { return Stuid2; }
            set { Stuid2 = value; }
        }
        public string Name
        {
            get { return nme2; }
            set { nme2 = value; }
        }
        public void ShowDetails()
        {
            Console.WriteLine("{0} student id and name is {1} of age {2} is Resident", Stuid2, nme2, Age2);
        }
    }



    class IDriverclass
    {
        static void Main(string[] args)
        {
            Dayscholar dayscholar = new Dayscholar();
            dayscholar.nme1 = "chaithra";
            dayscholar.Stuid1 = 20345;
            dayscholar.Age = 25;
            dayscholar.ShowDetails();
            Resident resident = new Resident();
            resident.nme2 = "raghu";
            resident.Stuid2 = 4567;
            resident.Age2 = 32;
            resident.ShowDetails();
            Console.Read();
        }

    }
}