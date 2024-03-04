using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test("Python", 1));
            Console.WriteLine(test("Python", 0));
            Console.WriteLine(test("Python", 4));
            Console.ReadLine();
            }

            public static string test(string str, int n)
            {
               
                return str.Remove(n, 1); // Remove the char at index 'n' and return the modified string

            }
            

           
}
    }
