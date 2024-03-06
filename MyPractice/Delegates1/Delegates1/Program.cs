using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates1
{
    public delegate void Calculation(int a, int b);
    class Program
    {
       public static void Addition(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Addition result is: {0}", result);
        }public static void Subtraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("Subtraction result is: {0}", result);
        }public static void Multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("Multiplication result is: {0}", result);
        }public static void Division(int a, int b)
        {
            int result = a / b;
            Console.WriteLine("Division result is: {0}", result);
        }
        static void Main(string[] args)
        {
            Calculation obj = new Calculation(Program.Addition);
            obj.Invoke(20, 10);
            obj = Subtraction;
            obj(40 , 10);
            obj = Multiplication;
            obj(8 , 4);
            obj = Division;
            obj(64, 4);
            Console.ReadLine();
        }
    }
}
