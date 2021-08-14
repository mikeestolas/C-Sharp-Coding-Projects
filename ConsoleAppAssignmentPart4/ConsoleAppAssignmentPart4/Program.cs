using System;
using System.Collections.Generic;


namespace ConsoleAppAssignmentPart4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] car = {"Toyota", "Mazda", "Honda", "Jeep", "Acura", "Ford"};
            Console.WriteLine("Toyota, Mazda, Honda, Jeep, Acura, Ford \n from the list above type your brand:");
            String c = Console.ReadLine();
            int index = Array.IndexOf(car, c);
            if (index > -1)
            {
                while(true)
                {
                    Console.WriteLine(c + " can be found in index " + index);
                    break;
                }
            }
            Console.WriteLine(c + " is not in the list!");
            Console.ReadLine();
        }
    }
}
