using System;
using System.Collections.Generic;
using System.Text;

namespace MandatoryAssignment1
{
    public class Bookcalss
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Book Library");
            //  List<Book> books = new List<Book>()
            //  {

            //};
            Book obj = new Book("Social", "newAuthor",34,"0123456789123");
             new Book("Science", "newAut", 94, "7123456789123");
             new Book("Maths", "OldAuthor", 64, "0123456789876");

            Console.ReadLine();
        }
         

    }
}
