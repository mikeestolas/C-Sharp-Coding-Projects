using System;
using System.Collections.Generic;


namespace ConsoleAppAssignmentPart6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fruit = new List<string>() { "Apple", "Banana", "Mango", "Orange", "Grapes", "Apple" };
            List<string> appeared = new List<string>();


            foreach (string fruits in fruit)
            {
                if (fruits == "Apple")
                {
                    appeared.Add(fruits);

                    Console.WriteLine(fruits);
                    Console.WriteLine("There are " + (appeared.Count) + " in the list!");

                }

            }

            Console.ReadLine();
        }
    }
}
