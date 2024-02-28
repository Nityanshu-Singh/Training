using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine(test("Python", 1));
            //Console.WriteLine(test("Python", 0));
            //Console.WriteLine(test("Python", 4));
            Console.WriteLine(test("Python", 1));
            Console.WriteLine(test1("abcd"));

            test2();
            Console.ReadLine();
        }

        public static string test(string str, int n)
        {
            return str.Remove(n, 1); // Remove the char at index 'n' and return the modified string

        }
        public static string test1(string str)
        {
            return str.Length > 1
                ? str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1)
                : str;
        }

        public static void test2()
            {
                int num1, num2, num3;
                Console.Write("\n\n");
                Console.Write("Find the greatest of three number: ");
                Console.Write("--------------------------");
                Console.Write("\n\n");

                Console.Write("Input the 1st number: ");
                num1=Convert.ToInt32(Console.ReadLine());

                Console.Write("Input the 2nd number: ");
                num2=Convert.ToInt32(Console.ReadLine());

                Console.Write("Input the 3rd number: ");
                num3=Convert.ToInt32(Console.ReadLine());

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
            }
        }

    }
 
