using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
///Create a structure 
///struct Books
///private string title;
///private string author;
///private string subject;
///private int book_id;
///Include 2 methods called GetValues() and ShowValues() to accept and display details.
///create a Class called TestStructures that invokes the above methods of the structure to accept and display the details of the book
/// </summary>

namespace Program1_06_
{

    public struct Books
    {
        string title;
        string author;
        string subject;
        int book_id;


        public void GetValues()
        {
            Console.WriteLine("Enter the title of the book : ");
            title = Console.ReadLine();
            Console.WriteLine("Enter the author of the book : ");
            author = Console.ReadLine();
            Console.WriteLine("Enter the subject : ");
            subject = Console.ReadLine();
            Console.WriteLine("Enter the book ID : ");
            book_id = Convert.ToInt32(Console.ReadLine());


        }
        public void ShowValues()
        {
            Console.WriteLine("Title of the book : " + title);
            Console.WriteLine("Author of the book is: " + author);
            Console.WriteLine("subject : " + subject);
            Console.WriteLine("Book Id is : " + book_id);
        }
    }



    class TestStructures
    {

        static void Main(string[] args)
        {
            Books books = new Books();
            books.GetValues();
            books.ShowValues();
            Console.Read();
        }
    }
}
