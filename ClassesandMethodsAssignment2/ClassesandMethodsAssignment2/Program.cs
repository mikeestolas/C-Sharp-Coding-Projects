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

            var operatorObject = new Operator();


            
            Console.WriteLine(operatorObject.Add(10));

            Console.ReadLine();


        }
    }
}
