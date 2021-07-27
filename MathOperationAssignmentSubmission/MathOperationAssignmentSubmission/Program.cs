using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperationAssignmentSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Math Operation Assignment Submission
            //1.
            Console.WriteLine("Please type any number from 1000 - 9999: ");
            String numFromUser = Console.ReadLine();
            int num1 = Convert.ToInt32(numFromUser);
            int num2 = 50;
            int Total = num1 * num2;
            Console.WriteLine("The total of your number when multiplied to 50 is equal to:" + Total);
            Console.ReadLine();


            //2.
            Console.WriteLine("Please type any number from 1 - 100: ");
            String numFromUser2 = Console.ReadLine();
            int num3 = Convert.ToInt32(numFromUser2);
            int num4 = 25;
            int Total1 = num3 + num4;
            Console.WriteLine("The total of your number when Added to 25 is equal to:" + Total1);
            Console.ReadLine();


            //3.
            Console.WriteLine("Please type any decimal number from 1 - 100: ");
            string numFromUser3 = Console.ReadLine();
            float num5 = float.Parse(numFromUser3);
            double num6 = 12.5;
            Double Total2 = num5 / num6;
            Console.WriteLine("The total of your number when divided to 12.5 is equal to:" + Total2);
            Console.ReadLine();


            //4.
            Console.WriteLine("Please type any number from 1 - 100: ");
            String numFromUser4 = Console.ReadLine();
            int num7 = Convert.ToInt32(numFromUser4);
            int num8 = 50;
            bool Result = num7 > num8;
            Console.WriteLine("Is your number Grater than 50?:" + Result);
            Console.ReadLine();


            //5.
            Console.WriteLine("Please type any number from 1 - 100: ");
            String numFromUser5 = Console.ReadLine();
            int num9 = Convert.ToInt32(numFromUser5);
            int num10 = 7;
            int remainder = num9 % num10;
            Console.WriteLine("your number devided to 7 has a remainder of:" + remainder);
            Console.ReadLine();
        }
    }
}
