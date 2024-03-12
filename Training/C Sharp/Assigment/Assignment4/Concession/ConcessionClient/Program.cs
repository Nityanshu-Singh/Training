using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Concession;

namespace ConcessionClient
{
    class Program
    {
        static int TotalFare = 500;
        static string Name;
        static int Age;

        public string _Name { get; set; } 

        public int _Age { get; set; }
        
        static void Main(string[] args)
        {
            Program pro = new Program();
            Console.WriteLine("Enter the Name of the Passenger:- ");
            pro._Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the Age of the Passenger:- ");
            pro._Age = Convert.ToInt32(Console.ReadLine());
            TicketConcession tc = new TicketConcession();

            TicketConcession.CalculateConcession(pro._Age, pro._Name);
            Console.ReadLine();

        }
    }
}
