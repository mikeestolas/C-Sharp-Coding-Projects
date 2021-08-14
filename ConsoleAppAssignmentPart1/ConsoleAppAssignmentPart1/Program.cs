using System;
using System.Collections.Generic;


namespace ConsoleAppAssignmentPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] month = {
             "January",
             "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"};

            Console.WriteLine("Please Enter your month of birth:");
            String bm = Convert.ToString(Console.ReadLine());
            int index = Array.IndexOf(month, bm);
            if (index > -1)
                
            foreach (string months in month)

                {
                    
                    

            if (index > -1)
            {

                Console.WriteLine(bm + " is found in index " + index);
                        Console.WriteLine(months);

                    }
            else
            {
                Console.WriteLine("Value not found");
            }

        }
        Console.ReadLine();

        }


    }
}
