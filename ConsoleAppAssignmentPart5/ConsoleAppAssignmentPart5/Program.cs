using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace ConsoleAppAssignmentPart5
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] fruit = { "Apple", "Banana", "Mango", "Orange", "Apple" };
            Console.WriteLine("Please Type in your Favorite Fruit:");
            String fr = Convert.ToString(Console.ReadLine());
            int f = 0;

            foreach (String fruits in fruit)
               
            {
                if (fr == fruits)
                    f++;

                Console.WriteLine("There are {0}", f + " " + fr + " on the lists...");
             }
            




            
                    Console.WriteLine("Sorry there are no" + fr + " on the list!");
                
                    Console.ReadLine();

        }
    }
}