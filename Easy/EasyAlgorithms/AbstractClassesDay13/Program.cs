using System;
using System.Collections.Generic;

namespace AbstractClassesDay13
{
    abstract class Book
    {

        protected string title;
        protected string author;

        public Book(string t, string a)
        {
            title = t;
            author = a;
        }
        public abstract void display();


    }

    class MyBook : Book
    {
        protected string title;
        protected string author;
        protected int price;

        public MyBook(string title, string author, int price) : base(title, author)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }

        public override void display()
        {
            Console.WriteLine(string.Format("Title: {0}", title));
            Console.WriteLine(string.Format("Author: {0}", author));
            Console.WriteLine(string.Format("Price: {0}", price));
        }
    }

    class Program
    {
        static void Main(String[] args)
        {
            String title = Console.ReadLine();
            String author = Console.ReadLine();
            int price = Int32.Parse(Console.ReadLine());
            Book new_novel = new MyBook(title, author, price);
            new_novel.display();
        }
    }
}
