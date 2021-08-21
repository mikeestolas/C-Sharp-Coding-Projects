using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment
{
    class Program
    {
        public static int Data { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int userValue = Convert.ToInt32(Console.ReadLine());

            var operatorObject = new Operator();
            int result = operatorObject.Add(userValue, 4);
            result = operatorObject.Subtract(result, 2);
            result = operatorObject.Divide(result, 2);

            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
