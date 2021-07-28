using System;
using System.Collections.Generic;


namespace ArrayAssignment
{
    class Program
    {
        static void Main()
        {
            //1.

            Console.WriteLine("Type a number from 0 - 5, to display your number in string:");
            string[] sArray = new string[] { "Zero", "one", "two", "three", "four", "Five" };
            int FromUser = Convert.ToInt32(Console.ReadLine());
            if (FromUser <=5 )
            {
                Console.WriteLine(sArray[FromUser]);

            }
            else
            {
                   Console.WriteLine("You Typed more than expected, PLease try again!");
            }

            Console.ReadLine();

            //2.
            Console.WriteLine("Type a number from 0 - 5, to reveal how much you win:");
            int[] winArray = new int[] { 2000, 4500, 6000, 10000, 7809, 400 };
            int UserType = Convert.ToInt32(Console.ReadLine());
            if (UserType < 6)
            {
                Console.WriteLine("You win $" + winArray[UserType] + " dollars");
            }
            else
            {
                    Console.WriteLine("You Typed more than expected, PLease try again!");
            }

            Console.ReadLine();

            //4.
            Console.WriteLine("Type a number from 0-3");
            List<string> optionList = new List<string> { "House and Lot", "New BMW", "Muskoka Vacation Package", "A New Iphone" };
            int keyFromUser = Convert.ToInt32(Console.ReadLine());
            if (keyFromUser <= 3)
            {
                Console.WriteLine("You Won a " + optionList[keyFromUser] + "!!!");
            }
            else
            {
                Console.WriteLine("You have typed the wrong number, No Winnings!!!, PLease try again!");
            }

            Console.ReadLine();

        }
    }
}
