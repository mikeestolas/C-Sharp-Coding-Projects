using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Guess a number?");
            //int number = Convert.ToInt32(Console.ReadLine());
            //bool isGuesed = number == 12;




            //while (!isGuesed)
            //{
            //    switch (number)
            //    {
            //        case 62:
            //            Console.WriteLine("You guessed 62. Try again.");
            //            Console.WriteLine("Guess a number?");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 29:
            //            Console.WriteLine("Yu guessed 29. Try again.");
            //            Console.WriteLine("Guess a number?");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 55:
            //            Console.WriteLine("You guessed 55. Try again.");
            //            Console.WriteLine("Guess a number?");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 12:
            //            Console.WriteLine("You guessed the number 12. That is correct!");
            //            isGuesed = true;
            //            break;
            //        default:
            //            Console.WriteLine("You are wrong.");
            //            Console.WriteLine("Guess a number?");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;


            Console.WriteLine("Guess a number?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuesed = number == 12;

            do
            {

                switch (number)
                {
                    case 62:
                        Console.WriteLine("You guessed 62. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("Yu guessed 29. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 55:
                        Console.WriteLine("You guessed 55. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("You guessed the number 12. That is correct!");
                        isGuesed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            while (!isGuesed);

            Console.ReadLine();
        }
    }
}
