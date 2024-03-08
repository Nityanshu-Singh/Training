using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static string FirstName, LastName;

        static void Display()
        {
            Console.WriteLine("Enter Your First Name: ");
            FirstName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Your Last Name: ");
            LastName = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Your Name---------> ");
            Console.WriteLine("First Name:- " + FirstName.ToUpper());
            Console.WriteLine("Last Name:- " + LastName.ToUpper());
        }
        static void Main(string[] args)
        {
            Display();
            Console.ReadLine();
        }
    }
}
