using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Books
    {
        string Book_Name;
        string Author_Name;
        public Books(string Book_Name, string Author_Name)
        {
            this.Book_Name = Book_Name;
            this.Author_Name = Author_Name;
        }

        public void Display()
        {
            Console.WriteLine($"Book Name: {Book_Name}\t\t\t Author Name: {Author_Name}");
        }
        class BookShelf
        {
            private Books[] Books = new Books[5];

            public Books this[int index]
            {
                get { return Books[index]; }
                set { Books[index] = value; }
            }

        }
        class Program
        {
            static void Main(string[] args)
            {
                BookShelf shelf = new BookShelf();

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Enter details for Book {i + 1}: ");

                    Console.Write("Book Name: ");
                    string Book_Name = Console.ReadLine();

                    Console.WriteLine("Author Name: ");
                    string Author_Name = Console.ReadLine();

                    shelf[i] = new Books(Book_Name, Author_Name);
                }
                Console.WriteLine("\n------------------Books on the Shelf-------------------: ");
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"{i + 1}: ");
                    shelf[i].Display();
                    Console.ReadLine();
                }
            }
        }
    }
}
    
