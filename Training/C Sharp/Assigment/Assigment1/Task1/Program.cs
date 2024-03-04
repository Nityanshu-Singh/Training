using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write first Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Write second Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine($"{num1} and {num2} are equal");

            }
            else
            {
                Console.WriteLine($"{num1} and {num2} are not equal");
            }
            Program pro = new Program();
            pro.second_ques();
            pro.third_ques();
            pro.forth_ques();
            pro.fifth_ques();
            pro.sixth_ques();
            pro.seventh_ques();
            pro.eighth_ques();
            pro.nineth_ques();
            pro.tenth_eleventh_ques();
            pro.twelve_ques();

            Console.ReadLine();
        }
        public void second_ques()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine($"{num} is a positive number");
            }
            else if (num < 0)
            {
                Console.WriteLine($"{num} is a negative number");
            }
            else
            {
                Console.WriteLine($"{num} is a zero");
            }
            Console.ReadLine();
        }

        public void third_ques()
        {
            Console.WriteLine("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the operation (+, -, *, /): ");
            char operation = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    break;

                case '-':
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    break;

                case '*':
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                    break;

                case '/':
                    if (num2 != 0)
                    {
                        Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero");
                    }
                    break;
                default:
                    Console.WriteLine("Invaild operation");
                    break;
            }
            Console.ReadLine();
        }
        public void forth_ques()
        {
            Console.WriteLine("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Multiplication table of {num}: ");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");

            }
            Console.ReadLine();
        }
        public void fifth_ques()
        {
            Console.WriteLine("Enter the first interger: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second interger: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;

            if (num1 == num2)
            {
                Console.WriteLine($"The triple of the sum is: {sum * 3}");
            }
            else
            {
                Console.WriteLine($"The sum pf the two integers is:{sum}");
            }
            Console.ReadLine();
        }

        public void sixth_ques()
        {
            Console.WriteLine("Enterthe day number: ");
            int dayNumber = Convert.ToInt32(Console.ReadLine());

            string dayName = GetDayName(dayNumber);
            Console.WriteLine($"The name of the day is: {dayName}");
        }

        static string GetDayName(int dayNumber)
        {
            switch (dayNumber)
            {
                case 1:
                    return "Monday";
                case 2:
                    return "Tuesday";
                case 3:
                    return "Wednesday";
                case 4:
                    return "Thursday";
                case 5:
                    return "Friday";
                case 6:
                    return "Saturday";
                case 7:
                    return "Sunday";
                default:
                    return "Invaild day number";
            }
        }

        public void seventh_ques()

        {

            int n;

            Console.WriteLine("Enter the size of an array: ");

            n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)

            {

                Console.WriteLine("Enter numbers:   ");

                arr[i] = Convert.ToInt32(Console.ReadLine());

            }

            int sum = 0;

            for (int i = 0; i < n; i++)

            {

                sum = sum + arr[i];

            }

            Console.WriteLine($"The Total is: {sum}");

            Console.WriteLine($"Average value of Array Elements: {sum / n}");

            Console.WriteLine($"Maximum Element is: {arr.Max()}");

            Console.WriteLine($"Minimum Elemenet is: { arr.Min()}");


        }

        public void eighth_ques()

        {

            int[] marks = new int[10];

            Console.WriteLine("Enter the marks of the 10 students:  ");

            for (int i = 0; i < 10; i++)

            {

                marks[i] = Convert.ToInt32(Console.ReadLine());

            }

            int sum = 0;

            for (int i = 0; i < 10; i++)

            {

                sum += marks[i];

            }

            Console.WriteLine($"The total is {sum}");

            Console.WriteLine($"The Average is {sum / 10}");

            Console.WriteLine($"The Minimum marks is: {marks.Min()}");

            Console.WriteLine($"The Maximum marks is: {marks.Max()}");

            Array.Sort(marks);  // sort funcion -> Ascending order

            Console.WriteLine("The Ascending order: ");

            for (int i = 0; i < marks.Length; i++)

            {

                Console.Write(marks[i] + " ");

            }

            Console.WriteLine();  // for changing line

            Console.WriteLine("The Descending order: ");

            for (int i = marks.Length - 1; i >= 0; i--)

            {

                Console.Write(marks[i] + " ");

            }

        }

        public void nineth_ques()

        {

            int[] arr1 = new int[5] { 1, 2, 3, 4, 5 };

            int[] arr2 = new int[5];

            // Copying...

            for (int i = 0; i < arr1.Length; i++)

            {

                arr2[i] = arr1[i];

            }

            //Display

            for (int i = 0; i < arr2.Length; i++)

            {

                Console.WriteLine(arr2[i]);

            }



        }

        public void tenth_eleventh_ques()

        {

            string s;

            Console.WriteLine("ENter a string: ");

            s = Console.ReadLine();

            Console.WriteLine($"The length of string: {s.Length}");

            // Reverse -> s.reverse -> inbuild function

            char[] c = s.Reverse().ToArray();   //converting array of charater ??

            Console.WriteLine("The Reverse string using inbuild function: ");

            for (int i = 0; i < c.Length; i++)

            {

                Console.Write(c[i]);

            }

            Console.WriteLine();

            // reverse string using loop

            Console.WriteLine("The reverse String is: ");

            for (int i = s.Length - 1; i >= 0; i--)

            {

                Console.Write(s[i] + " ");

            }

        }

        

        public void twelve_ques()

        {
            Console.WriteLine("Enter 1st Word: ");
            String a = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter 2nd Word: ");
            String b = Convert.ToString(Console.ReadLine());
            if (a.Equals(b))
            {
                Console.WriteLine("Words are same...");
            }
            else
            {
                Console.WriteLine("a and b are not same...");
            }
        }

    }
}
