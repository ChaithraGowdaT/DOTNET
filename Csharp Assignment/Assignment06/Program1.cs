using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Create a class called Books with BookName and AuthorName members. Instantiate the class through constructor
///and also write a method Display() to display the details. Create an Indexer of Books Object to store 5 books in a class called BookShelf.
///(Hint : Use Composition.Books object inside BookShelf class)
/// </summary>

namespace Program1_06_
{
    class Books
    {
        string BookName;
        string AuthorName;

        public Books(string BookName, string AuthorName)
        {
            this.BookName = BookName;
            this.AuthorName = AuthorName;
        }

        public void Display()
        {
            
                Console.WriteLine(BookName+ " book is written by " +AuthorName);
                Console.WriteLine();
            
        }

    }


    class BookShelf

    {
        Books[] Bookname = new Books[5];
      
        public Books this[int n]
        {
            get { return Bookname[n]; }
            set { Bookname[n] = value; }
        }

        static void Main(string[] args)
        {

            BookShelf book = new BookShelf();
            book[0] = new Books("The Braille edition of the book Exam Warriors", " PM Narendra Modi");
            book[1] = new Books("Believe-What Life and Cricket Taught Me", "Suresh Raina");
            book[2] = new Books("The Christmas Pig","JK Rowling");
            book[3] = new Books("Whereabouts","Jhumpa Lahiri");
            book[4] = new Books("Lal Salam","Smriti Irani");
            for (int j = 0; j < 5; j++)
            {
                book[j].Display();
            }
            

            Console.Read();
        }
    }
}
