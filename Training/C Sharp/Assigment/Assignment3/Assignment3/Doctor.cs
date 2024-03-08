using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Doctor
     {
        static int Reg_no;
        static string Name;
        static int Fees_Charged;

        public string _Name
        {
            get { return Name; }
            set { Name = value; }
        }
        public int _FeesCharged
        {
            get { return Fees_Charged; }
            set { Fees_Charged = value; }
        }
        public int _Reg_no
        {
            get { return Reg_no; }
            set { Reg_no = value; }
        }

        public static void Display()
        {
            Console.Write("Enter Registration Number:- ");
            Reg_no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter Name:- ");
            Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter Fees:- ");
            Fees_Charged = Convert.ToInt32(Console.ReadLine());
        }
        public void properties()
        {
            Console.WriteLine("-----Display Details------\n");

            Doctor doct = new Doctor();
            doct._Reg_no = Reg_no;
            doct._Name = Name;
            Console.WriteLine("Registration Number:- " + doct._Reg_no);
            Console.WriteLine("Name:- " + doct._Name);
            Console.WriteLine("Fees:- " + doct._FeesCharged);
            doct._FeesCharged = Fees_Charged;
            Console.Read();
        }
        static void Main(String[] args)
        {
            Display();
            Doctor ds = new Doctor();
            ds.properties();
            Console.ReadLine();
        }
    }
}