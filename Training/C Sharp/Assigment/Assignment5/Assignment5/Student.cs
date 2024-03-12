using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public interface IStudent
    {
        int Student_Id { get; set; }
        string Student_Name { get; set; }
        void Display_Details();
    }

    public class Day_scholar : IStudent
    {
        public int Student_Id { get; set; }
        public string Student_Name { get; set; }
        public void Display_Details()
        {
            Console.WriteLine("\nDayscholor Student Details:- ");
            Console.WriteLine("Student Id:- " + Student_Id  + " Student Name:- " + Student_Name);
        }
    }

    public class Resident : IStudent
    {
        public int Student_Id { get; set; }
        public string Student_Name { get; set; }

        public void Display_Details()
        {
            Console.WriteLine("\nResident Student Details:- ");
            Console.WriteLine("Student Id:- " + Student_Id + " Student Name:- " + Student_Name);
        }
    }
    class Student
    {
        public static void Show_Student()
        {

            Console.WriteLine("Enter the id: ");
            Day_scholar d1 = new Day_scholar();
            d1.Student_Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Name: ");
            d1.Student_Name = Convert.ToString(Console.ReadLine());
            d1.Display_Details();

            Console.WriteLine();

            Console.WriteLine("Enter the Id: ");
            Resident r1 = new Resident();
            r1.Student_Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Name: ");
            r1.Student_Name = Convert.ToString(Console.ReadLine());
            r1.Display_Details();


        }
        static void Main(string[] args)
        {
            Show_Student();
            Console.ReadLine();
        }
    }
}
