using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Occurance
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String :");
            string inputString = Console.ReadLine();

            Console.WriteLine("Enter the letter to count: ");
            char letter = Console.ReadKey().KeyChar;

            int count = CountOccurances(inputString, letter);
            Console.WriteLine($"Number of occurances of '{letter}' in the string: {count}");
            Console.ReadLine();
        }

        static int CountOccurances(string input, char letter)
        {
            int count = 0;
            foreach (char c in input)
            {
                if (c == letter)
                {
                    count++;
                }
            }
            return count;
        }
    }
}

