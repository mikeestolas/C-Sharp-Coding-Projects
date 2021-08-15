using System;
using System.Collections.Generic;


namespace ConsoleAppAssignmentPart6
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] gender = { 'm', 'f', 'm', 'm', 'm', 'f', 'f', 'm', 'm', 'f' };
            int male = 0, female = 0;
            foreach (char g in gender)
            {
                if (g == 'm')
                    male++;
                else if (g == 'f')
                    female++;
            }
            Console.WriteLine("Number of male appeared on the list is  {0}", male + " times....");
            Console.WriteLine("\nNumber of female appeared on the list is  {0}", female + " times....");
            Console.ReadLine();
        }

        
    }
}
