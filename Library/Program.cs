using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3Library
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
            Book Mybook = new Book();

            // This information is for one book in our library
            Mybook.Title = "C# for beginners";
            Mybook.Author = "BillGates";
            Mybook.ISBN = "12345678";

            // Output the book information to the console
            Console.WriteLine($"Book title: {Mybook.Title}");
            Console.WriteLine($"Book Author: {Mybook.Author}");
            Console.WriteLine($"Book ISBN: {Mybook.ISBN}");


            // Book object 2
            Book Mybook2 = new Book();
            Mybook2.Title = "C# Methods";
            Mybook2.Author = "Microsoft";
            Mybook2.ISBN = "3456778";


            //Output for object 2
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Book title: {Mybook2.Title}");
            Console.WriteLine($"Book Author {Mybook2.Author}");
            Console.WriteLine($"Book ISBN: {Mybook2.ISBN}");


        }

    }
}
    
