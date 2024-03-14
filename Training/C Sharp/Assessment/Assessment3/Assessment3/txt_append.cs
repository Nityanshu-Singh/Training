using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assessment3
{
    class txt_append
    {
        static void Main(string[] args)
        {
            string filePath = "Text.txt";

            try
            {
                Console.WriteLine("Enter text to Append: ");
                string textToAppend = Console.ReadLine();

                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(textToAppend);
                }
                Console.WriteLine("Text appended successfully...");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                Console.ReadLine();
            }
        }
    }
}
