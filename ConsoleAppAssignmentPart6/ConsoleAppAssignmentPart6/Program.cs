using System;
using System.Collections.Generic;


namespace ConsoleAppAssignmentPart6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> gender = new List<string>() { "m", "f", "m", "m", "m", "f", "f", "m", "m", "f" };
            List<string> emptyg = new List<string>();
           
            foreach (string g in gender)
            {
                if (emptyg.Contains(g))
                   
                        Console.WriteLine(g + "This is appeared inthe list already")  ;

                

                else if (!emptyg.Contains(g))
                        Console.WriteLine(g + "This is not yet appeared in the list ");
                emptyg.Add(g);      
            }
            
            Console.ReadLine();
        }

        
    }
}
