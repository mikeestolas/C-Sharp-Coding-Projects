using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsAssignmentSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //while Loop:

            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine("C# For Loop: Iteration {0}", i);
                i++;
            }

            Console.ReadLine();



            //do while loop:

            int mmm = 1, n = 5, product;

            do
            {
                product = mmm * i;
                Console.WriteLine("{0} * {1} = {2}", n, i, product);
                i++;
            } while (i <= 10);
            Console.ReadLine();
        }
    }
}
