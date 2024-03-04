using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class SaleDetails
    {
        public int Salesno;
        public int Productno;
        public int Price;
        public string Dateofsales;
        public int Qty;
        static int TotalAmount;

        SaleDetails(int Sales_No, int Product_No, int Price, int Quantity, string Date_of_sales)
        {
         this.Salesno = Sales_No;
        this.Productno = Product_No;
        this.Price = Price;
        this.Dateofsales = Date_of_sales;
        this.Qty = Quantity;
    }

        void Sales()
        {
            int TotalAmount = Qty * Price;
            Console.WriteLine("Total Amount of product: Rs." + TotalAmount);
        }

        void Show_Details()
        {
            Console.WriteLine("Product Details:---------------- ");
            Console.WriteLine("Sales No: " + Salesno);
            Console.WriteLine("Product No: " + Productno);
            Console.WriteLine("Price: Rs." + Price);
            Console.WriteLine("Quantity: " + Qty);
            Console.WriteLine("Date: " + Dateofsales);
        }
        static void Main(String[] args)
        {
            SaleDetails pt = new SaleDetails(228, 123, 99, 04, "03/03/2024");
            pt.Show_Details();
            Console.WriteLine("\n");
            pt.Sales();
            Console.ReadLine();
        }
    }
}
