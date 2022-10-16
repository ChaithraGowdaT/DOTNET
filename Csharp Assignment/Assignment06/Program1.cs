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
        string[] BookName = new string[5];
        string[] AuthorName = new string[5];

        public string this[int N]
        { 
                get { string temp = BookName[N]; return temp; }
                set { BookName[N] = value; }
            
        }
        public string this[long S]
        {
            get
            {
                string temp = AuthorName[S];
                return temp;
            }
            set { AuthorName[S] = value; }
        }

        public void Display()
        {   for (int i = 0; i < 5; i++)
            {
                    Console.WriteLine("Book name: {0} & Author name:{1}", BookName[i], AuthorName[i]);
                    Console.WriteLine();
            }
        }

    }
    

     class BookShelf

    { 
        Books book;
        public static void SetBooks(Books book)
        {

            //filling data to book names
            book[0] = "The Braille edition of the book Exam Warriors";
            book[1] = "Believe-What Life and Cricket Taught Me";
            book[2] = "The Christmas Pig";
            book[3] = "Whereabouts";
            book[4] = "Lal Salam";
            //filling data to author names
            book[0L] = "PM Narendra Modi";
            book[1L] = "Suresh Raina";
            book[2L] = "JK Rowling";
            book[3L] = "Jhumpa Lahiri";
            book[4L] = "Smriti Irani";
            book.Display();
        }


        public BookShelf()
        {
            book = new Books();
            SetBooks(book);
        }


        }
    class DriverClass
    {
        static void Main(string[] args)
        {
            BookShelf bookS = new BookShelf();
            Console.Read();
        }
    }



    
}
