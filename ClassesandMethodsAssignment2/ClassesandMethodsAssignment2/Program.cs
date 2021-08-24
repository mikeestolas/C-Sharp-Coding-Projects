using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesandMethodsAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Please Enter first number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter second number:");
            int b = Convert.ToInt32(Console.ReadLine());

            //int a = 100;
            //int b = 200;
            int ret;
            NumberManipulator n = new NumberManipulator();

            
            ret = n.FindMax(a, b);
            Console.WriteLine("Max value is : {0}", ret);
            Console.ReadLine();
        }
    }
}
