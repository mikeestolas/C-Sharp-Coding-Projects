using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment2
{
    class mcStart
    {
        public static void Main(string[] args)
        {
            mcCalculator mcCal = new mcCalculator(50);
            mcCal.add(12, 23);
            mcCal.displayiOutVal();
            mcCal.subtract(24, 4);
            mcCal.displayiOutVal();
            mcCal.Multiply(12, 3);
            mcCal.displayiOutVal();
            mcCal.Devide(8, 2);
            mcCal.displayiOutVal();
            Console.ReadLine();


        }


    }

    
}