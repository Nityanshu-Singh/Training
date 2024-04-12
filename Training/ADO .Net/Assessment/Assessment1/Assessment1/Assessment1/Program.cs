using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1
{
    class Program
    {
        static DataClasses1DataContext db = new DataClasses1DataContext();
        static void Main(string[] args)
        {

            InsertEmployee();
            ShowEmployee();


            Console.Read();
        }
        public static void InsertEmployee()
        {

            Console.WriteLine("Enter Employee Details: ");
            Console.WriteLine("Enter Employee Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Employee's Salary: ");
            int salary = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Type: ");
            char emptype = char.Parse(Console.ReadLine());

            Console.WriteLine("**********************************************************************");

            // insert the values by help of stored procedure-----
            db.AddEmployee(name, salary, emptype);
        }
        public static void ShowEmployee()
        {
            List<Employee_Detail> employee_Details = db.Employee_Detail.ToList();
            var e = employee_Details;
            foreach (var i in e)
            {
                Console.WriteLine($"Employee No: {i.EmpNo} Employee Name: {i.EmpName} Salary: {i.EmpSal} Employee Type: {i.Emptype}");
            }
        }
    }
}