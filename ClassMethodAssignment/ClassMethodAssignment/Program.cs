using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    class Program
    {
        static void Main(string[] ar)
        {

            Console.WriteLine("Enter a number:");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int q, s,  a = userInput;

            divide ob = new divide();
           

            divide.Math_Calc(a,  out q, out s);
            

            Console.WriteLine("The quotient after dividing {0} by {1}: {2} ,  adding adding 2 : {3}", a, 2, q, s);
            
            Console.ReadLine();
        }
    }
}
