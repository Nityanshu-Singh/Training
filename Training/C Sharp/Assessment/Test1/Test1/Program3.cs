using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program3
    {
        public static void Main(string [] args)
        {


            int num1, num2, num3;


            Console.Write("Input the 1st number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the 2nd number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the 3rd number: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("The 1st number is greatest");
                }
                else
                {
                    Console.WriteLine("The 3rd number is greatest");
                }
            }
            else if (num2 > num3)
            {
                Console.Write("The 2nd number is greatest");
            }
            else
            {
                Console.Write("The 3rd number is greatest");
            }
            Console.ReadLine();

            }
        }
    }
