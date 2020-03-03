using System;

namespace _13AbstractClasses
{
    class Program
    {
        abstract class Book
        {

            protected String title;
            protected String author;

            public Book(String t, String a)
            {
                title = t;
                author = a;
            }
            public abstract void display();
        }

        class MyBook : Book
        {
            private string myTitle;
            private string myAuthor;
            private int myPrice;

            public MyBook(string title, string author, int price) : base(title, author)
            {
                myTitle = title;
                myAuthor = author;
                myPrice = price;
            }

            public override void display()
            {
                Console.WriteLine("Title: " + myTitle);
                Console.WriteLine("Author: " + myAuthor);
                Console.WriteLine("Price: " + myPrice);
            }
        }

        static void Main(String[] args)
        {
            Console.WriteLine("Title");
            String title = Console.ReadLine();
            Console.WriteLine("Author");
            String author = Console.ReadLine();
            Console.WriteLine("Price");
            int price = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            // creates an instance of myBook based on console input
            Book new_novel = new MyBook(title, author, price);

            // prints the desired data to the console via the display method
            new_novel.display();
        }
    }
}
