using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Number Amount = new Number();
            Amount.x = 10.5m;
            Amount.y = 20.6m;
            decimal sum = Amount.x + Amount.y;
            Console.WriteLine("The sum is {0}", sum);
            Console.ReadLine();
        }

        public struct Number
        {
            public decimal x;
            public decimal y;
        }

    }
}
