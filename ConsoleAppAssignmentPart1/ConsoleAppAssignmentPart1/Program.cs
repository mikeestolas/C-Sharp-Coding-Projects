using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleAppAssignmentPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> month = new List<string>() {
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
            Console.WriteLine("Please type any string: ");
            string bm = Convert.ToString(Console.ReadLine());
            
            foreach (string m in month)
            {
                string r = m + bm;   
                
             Console.WriteLine(r);
              
            }
                Console.ReadLine();
            
        }              

    }
}
