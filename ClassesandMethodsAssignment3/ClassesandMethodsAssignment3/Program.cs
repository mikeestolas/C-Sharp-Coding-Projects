using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesandMethodsAssignment3
{
    class Program
    {
        static int Sum(int num1, int num2)
        {
            int total;
            total = num1 + num2;
            return total;
        }

        static void Main(string[] args)
        {

            Console.Write("\n\nFunction to calculate the sum of two numbers :\n");
            Console.Write("--------------------------------------------------\n");
            Console.Write("Enter a number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            int z = Sum(n1,100);
            Console.WriteLine("\nThe sum of two numbers is : {0} \n", z);
            Console.WriteLine("Second number is = " + n2);
            Console.ReadLine();
        }
        
        
    }
}
