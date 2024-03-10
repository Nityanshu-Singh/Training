using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concession
{
    public class TicketConcession
    {
        public const double TotalFare = 500;

        public static void CalculateConcession(int age, string name)
        {
            if (age <= 5)
            {
                Console.WriteLine($"Little Champs- Free Ticket for {name} ({age} years old) \n Ticket Status- Booked");
            }
            else if (age > 60)
            {
                double concessionAmount = TotalFare * 0.30;
                double discountedFare = TotalFare - concessionAmount;
                Console.WriteLine($"Senior Citizen - Discounted Fare: (discountedFare:C2} for {name} ({age} years old) \n Ticket Status- Booked");
            }
            else
            {
                Console.WriteLine($"Ticket Booked - Fare: {TotalFare:C2} for {name} ({age} years old) \n Ticket Status- Booked");
            }
        }
    }
}
