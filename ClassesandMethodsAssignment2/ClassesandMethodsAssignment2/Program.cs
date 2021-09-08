using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesandMethodsAssignment2
{
    class Program
    {
        //public static int Data { get; set; }
        static void Main(string[] args)
        {

                Console.WriteLine("Please Enter first number:");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please Enter second number:");
                string b = Console.ReadLine();

                var operatorObject = new Operator();
                 int result = operatorObject.Add(a,b);

            if (b == " ")
            {
                int c = Convert.ToInt32(b);
                Console.WriteLine(operatorObject.Add(c));
            }

            else
            {
                Console.WriteLine(result);

            }

            Console.ReadLine();
            }

        }
    }

