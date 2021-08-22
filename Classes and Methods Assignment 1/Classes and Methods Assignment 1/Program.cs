using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Methods_Assignment_1
{
    class Program
    {
        public static int Data { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int userValue = Convert.ToInt32(Console.ReadLine());

            var operatorObject = new Operator();

            
            
            
            int result = operatorObject. Add(userValue, 4);
            int result1 = operatorObject.Subtract(result, 2);
            int result2 = operatorObject.Divide(result1, 2);
            double result3 = operatorObject.Decimal(result2, 1.5);


            Console.WriteLine("If you add " + userValue + " to 4 the answer is:" + result);
            Console.WriteLine("Subtracted 2 from " + result + " is: " + result1);
            Console.WriteLine("Divided by 2 from " + result1 + " is: " + result2);
            Console.WriteLine("Multiply to 7 " + result3);


            //Console.WriteLine("Please enter a decimal numbers:");
            //double userDecimalValue = Convert.ToDouble(Console.ReadLine());

        
        

        
            
            
            Console.ReadLine();
        }

    }
}
