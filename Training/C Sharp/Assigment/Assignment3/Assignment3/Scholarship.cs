﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Scholarship
    {
        static float Fees;
        static int Marks;
        static float sc;
        public static void Merit()
        {
            Console.WriteLine("Enter the Fees Amount:- ");
            Fees = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Marks Percentage:- ");
            Marks = Convert.ToInt32(Console.ReadLine());

        }
        static void Scholar()
        {
            if (Marks >= 70 && Marks <= 80)
            {
                sc = 0.2f * Fees;
                Console.WriteLine("Scholarship Amount:- " + sc);
            }
            else if (Marks > 80 && Marks <= 90)
            {
                sc = (Fees) * 0.3f;
                Console.WriteLine("Scholarship Amount:- " + sc);
            }
            else if (Marks > 90)
            {
                sc = (Fees) * 0.5f;
                Console.WriteLine("Scholarship Amount:- " + sc);
            }
            else
            {
                Console.WriteLine("Not Eligible for Scholarship");
            }
        }
        static void Main(String[] args)
        {
            Merit();
            Scholar();
            Console.ReadLine();
        }
    }
}
