using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Student
    {
        // Data members/fields
        public int RollNo;
        public string Name;
        public string StudentClass;
        public string Semester;
        public string Branch;
        public int[] Marks = new int[5];

        // Constructor
        public Student(int rollNo, string name, string studentClass, string semester, string branch)
        {
            RollNo = rollNo;
            Name = name;
            StudentClass = studentClass;
            Semester = semester;
            Branch = branch;
        }

        // Method to input marks for all 5 subjects
        public void GetMarks()
        {
            Console.WriteLine("Enter marks for 5 subjects:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Subject {i + 1}: ");
                Marks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Method to calculate the average marks
        public double calculateAverage()
        {
            double sum = 0;
            foreach (int mark in Marks)
            {
                sum += mark;
            }
            return sum / 5;
        }


        public void Displayresult()
        {
            bool anySubjectFailed = false;
            foreach (int mark in Marks)
            {
                if (mark < 35)
                {
                    anySubjectFailed = true;
                }
            }

            if (anySubjectFailed)
            {
                Console.WriteLine("Result: Failed");
            }
            else
            {
                double average = calculateAverage();
                Console.WriteLine($"Average Marks: {average}");

                if (average < 32)
                {
                    Console.WriteLine("Result: Failed");
                }
                else
                {
                    Console.WriteLine("Result: Passed");

                }


            }
        }
        // Method to display all values
        public void DisplayData()
        {
            Console.WriteLine($"Roll No: {RollNo}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"studentClass: {StudentClass}");
            Console.WriteLine($"Semester: {Semester}");
            Console.WriteLine($"Branch: {Branch}");
            Console.WriteLine("Marks:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Subject {i + 1}: {Marks[i]}");
            }

        }
    }
    class Program1
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(1,"Nityanshu","btech","4","CSE");
            student1.GetMarks(); // Input marks for 5 subjects.
            student1.Displayresult(); // Calculate average marks and display result.
            student1.DisplayData(); // Display all data of the student.
            Console.ReadLine();
        }
    }
}

    