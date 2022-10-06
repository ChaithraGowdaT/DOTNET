using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Create a class called Saledetails which has data members like Salesno, Productno, Price, dateofsale, Qty, TotalAmount
Create a method called Sales() that takes qty, Price details of the object and updates the TotalAmount as Qty *Price

call the show data method to display the values.
Hint : Use This pointer*/

namespace Program3_04_
{
     class SalesDetails
    {
        public int Saleno;
        public int Productno;
        public int Price;
        public string Dateofsale;
        public int Qty;
        public int TotalAmount; 
       public SalesDetails(int Sno,int Pno,int price,int qty,string Dos)
        {
            this.Saleno = Sno;
            this.Productno = Pno;
            this.Price = price;
            this.Qty = qty;
            this.Dateofsale = Dos;

        }
        public void Sales()
        {
            TotalAmount = Qty * Price;
        }
        public void Show()
        {
            Console.WriteLine("Sale number : "+Saleno);
            Console.WriteLine("Product number : "+Productno);
            Console.WriteLine("Date of sale : "+Dateofsale);
            Console.WriteLine("Quatity : "+Qty);
            Console.WriteLine("Price : "+Price);
            Console.WriteLine("Total amount : "+TotalAmount);
        }
        static void Main(string[] args)
        {
            SalesDetails s1 = new SalesDetails(1234,546,500,5,"25-06-2022");
            s1.Sales();
            s1.Show();
            Console.Read();
            
        }
    }
}
