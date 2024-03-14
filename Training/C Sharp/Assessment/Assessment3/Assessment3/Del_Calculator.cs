using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3
{
    public delegate int Calculation(int a, int b);
    class Del_Calculator
    {
        static int Addition(int a, int b)
        {
            return a + b;
        }
        static int Subtraction(int a, int b)
        {
            return a - b;
        }
        static int Multiplication(int a, int b)
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            Calculation add = Addition;
            Calculation subtract = Subtraction;
            Calculation multiple = Multiplication;

            Console.WriteLine("Enter two numbers which you want to Add,Substract and Multiple--");
            Console.WriteLine("Enter the First number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Enter the Second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int resultAdd = add(num1, num2);
            Console.WriteLine($"Addition: {num1} + {num2} = {resultAdd}");

            int resultSubtract = subtract(num1, num2);
            Console.WriteLine($"Substraction: {num1} - {num2} = {resultSubtract}");

            int resultMultiple = multiple(num1, num2);
            Console.WriteLine($"Multiplication: {num1} * {num2} = {resultMultiple}");

            Console.ReadLine();

        }

    }
}
