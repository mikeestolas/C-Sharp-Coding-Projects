using System;
using System.Collections.Generic;

namespace ConsoleAppAssignmentPart3
{
    class Program
    {
        static void Main(string[] args)
        {

            //iterating the loop in a “<=” operator
            string[] colors = new string[5];
            colors[0] = "red";
            colors[1] = "green";
            colors[2] = "pink";
            colors[3] = "purple";
            colors[4] = "orange";
            
            for (int i = 0; i <= colors.Length -1; i++)
                {
                string color = colors[i];
                Console.WriteLine(color);
            }
            for (int i = 0; i < colors.Length - 1; i++)
            {
                string color = colors[i];
                Console.WriteLine(" ");
                Console.WriteLine(color);
            }

                Console.ReadLine();
                
        }
    }
}
