using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Create a Class called Products with Productid, Product Name, Price. Accept 10 Products, sort them based on the price, and display the sorted Products

namespace Progarm3_06_
{
     class Driven
    {
        int[] Pid = new int[10];
        string[] Pnme = new string[10];
        double[] Pp = new double[10];
        static void Main(string[] args)
        {
            Driven prd = new Driven();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0} Enter the product Id: ", i + 1);
                prd.Pid[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("{0} Enter the product Name: ", i + 1);
                prd.Pnme[i] = Console.ReadLine();


                Console.WriteLine("{0} Enter the product Price: ", i + 1);
                prd.Pp[i] = Convert.ToDouble(Console.ReadLine());
            }

                List<Products> products = new List<Products>
                {

                new Products { Pdt_Id = prd.Pid[0], Pdt_Name = prd.Pnme[0], Pdt_Price = prd.Pp[0]},
                new Products { Pdt_Id = prd.Pid[1], Pdt_Name = prd.Pnme[1], Pdt_Price = prd.Pp[1] },
                new Products { Pdt_Id = prd.Pid[2], Pdt_Name = prd.Pnme[2], Pdt_Price = prd.Pp[2] },
                new Products { Pdt_Id = prd.Pid[3], Pdt_Name = prd.Pnme[3], Pdt_Price = prd.Pp[3] },
                new Products { Pdt_Id = prd.Pid[4], Pdt_Name = prd.Pnme[4], Pdt_Price = prd.Pp[4] },
                new Products { Pdt_Id = prd.Pid[5], Pdt_Name = prd.Pnme[5], Pdt_Price = prd.Pp[5] },
                new Products { Pdt_Id = prd.Pid[6], Pdt_Name = prd.Pnme[6], Pdt_Price = prd.Pp[6] },
                new Products { Pdt_Id = prd.Pid[7], Pdt_Name = prd.Pnme[7], Pdt_Price = prd.Pp[7] },
                new Products { Pdt_Id = prd.Pid[8], Pdt_Name = prd.Pnme[8], Pdt_Price = prd.Pp[8] },
               new Products { Pdt_Id = prd.Pid[9], Pdt_Name = prd.Pnme[9], Pdt_Price = prd.Pp[9] }


                };
                Display(products);
                Console.Read();
            }
        public static void Display(List<Products> products)
        {
            var value = products.OrderBy(a => a.Pdt_Price).ToList();
            foreach (var v in value)
            {
                Console.WriteLine("product Id is {0} : Product Name is {1} : price is Rs. {2}", v.Pdt_Id, v.Pdt_Name, v.Pdt_Price);
            }
        }
    }
      

    

    

    public class Products
    {
        public int Pdt_Id { get; set; }
        public string Pdt_Name { get; set; }
        public double Pdt_Price { get; set; }

        
    }
}
