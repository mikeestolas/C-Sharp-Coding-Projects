﻿using System;
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

            foreach (string months in month)
   
            {
              Console.WriteLine(months + bm);
                //append()
             }
            else
            {
                Console.WriteLine("Value not found");
            }

        
        Console.ReadLine();

        }


    }
}
