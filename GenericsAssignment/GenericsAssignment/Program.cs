using System;
using System.Collections.Generic;

namespace GenericsAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {

            Employee<int> empid = new Employee<int>();
            Employee<string> empfn = new Employee<string>();


            empid.things = new List<int>()
            {
                12,
                34,
                20
            };
            empfn.things = new List<string>()
            {
                "Mike",
                "Rocel",
                "Chito"
            };
            foreach (int mm in empid.things)
            {
                Console.WriteLine(mm);
            }
            foreach (string nn in empfn.things)
            {
                Console.WriteLine(nn);
            }
            Console.ReadLine();
        }


    }
}
