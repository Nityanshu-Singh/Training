using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2
{
    abstract class Student
    {
        public string Name { get; set; }
        public int StudentId { get; set; }
        public double Grade { get; set; }

        public abstract bool IsPassed(double grade);
    }

    class Undergraduate : Student
    {
        public override bool IsPassed(double grade)
        {
            return grade > 70;
        }
    }

    class Graduate : Student
    {
        public override bool IsPassed(double grade)
        {

            return grade > 80;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter details for Undergraduate Student: ");
            Undergraduate ug = new Undergraduate();
            Console.WriteLine("Name: ");
            ug.Name = Console.ReadLine();
            Console.WriteLine("Student Id: ");
            ug.StudentId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Grade: ");
            ug.Grade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter details for Graduate Student: ");
            Graduate gr = new Graduate();
            Console.WriteLine("Name: ");
            gr.Name = Console.ReadLine();
            Console.WriteLine("Student Id: ");
            gr.StudentId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Grade: ");
            gr.Grade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Undergraduate Passed: " + ug.IsPassed(ug.Grade));
            Console.WriteLine("Graduate Passed: " + gr.IsPassed(gr.Grade));

            Console.ReadLine();
        }
        
    }
}
