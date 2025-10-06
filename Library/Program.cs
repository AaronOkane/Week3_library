using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
     internal class Book
    {
        string Title;
        string Author;
        string ISBN;

        static void Main(string[] args)
        {
            // Create a new instance (object) of the Book class
            // Note how the object name differs from the class name
            Book book = new Book();

            // This information is for one book in our library
            Book mybook = new Book();
            mybook.Title = "C# for beginners";
            mybook.Author = "BillGates";
            mybook.ISBN = "1234";

            // Output the book information to the console
            Console.WriteLine($"Book title: {book.Title}");
            Console.WriteLine($"Book Author: {book.Author}");
            Console.WriteLine($"Book ISBN: {book.ISBN}");


            //add another book
            //c# methods 
            //microsoft
            //345678
        }
    }
}
    
