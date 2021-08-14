using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignmentPart5
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] clo = {"Mens", "Ladies", "Kids", "Infants"};
            Console.WriteLine("Mens\n Ladies \n Kids \n Infants \n\t In the categories above type what you are looking for?: ");
            string cat = Convert.ToString(Console.ReadLine());
            int index = Array.FindIndex(clo, x => x == cat);
            if (index > -1)
                while (true)
                {


                    Console.WriteLine("{0} found in the array at index {1}", cat, index);
                    Console.ReadLine();
                    break;
                }



            else
            {
                Console.WriteLine("we dont have that kind of category");

            }
            Console.WriteLine();
            

        }

    }
}