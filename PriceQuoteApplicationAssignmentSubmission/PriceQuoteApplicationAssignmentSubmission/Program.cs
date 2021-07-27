using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceQuoteApplicationAssignmentSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight.");
            int weight = Convert.ToInt32(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else if (weight < 50)
            {
                Console.WriteLine("Please enter the package width:");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package Height:");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter Package Lenth:");
                int lenght = Convert.ToInt32(Console.ReadLine());

                int total = (width + height + lenght);

                if (total > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");

                }
                else
                {

                    int Mul3 = (width * height * lenght);
                    int Tot_Mul3_w = (Mul3 * weight / 100);
                    Console.WriteLine("your Price qoute is: " + "$" + Tot_Mul3_w);
                }
                Console.ReadLine();



            }
        }
    }
}
