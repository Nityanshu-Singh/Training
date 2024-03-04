using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program2
    {
        public static void Main (string [] args)
        {
            Console.WriteLine(test1("abcd"));
            Console.WriteLine(test1("a"));
            Console.WriteLine(test1("xy"));
            Console.ReadLine();
        }
        public static string test1(string str)
        {
            return str.Length > 1 ? str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1) : str;
        }

    }
}
