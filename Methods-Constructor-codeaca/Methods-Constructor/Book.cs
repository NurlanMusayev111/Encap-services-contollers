using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Constructor
{
    internal class Book
    {
        public string name;
        public string author;
        //public Book(string title)
        //{
        //    Console.WriteLine(title);
        //}

        //public Book(int num)
        //{
        //    Console.WriteLine(num + 10);
        //}


        public Book(string bookname, string bookauthor)
        {
            name = bookname;
            author = bookauthor;
        }


        public Book() : this(5)
        {
            Console.WriteLine("Empty");
        }

        public Book(int a) : this(a, "salam")
        {
            Console.WriteLine(a);
        }

        public Book(int a, string b)
        {
            Console.WriteLine(a + "/" + b);
        }

        public string GetFullData()
        {
            return name + " " + author;
        }
    }


}

