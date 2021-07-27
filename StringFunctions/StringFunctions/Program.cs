using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string firstName = "Michael ";
            String middle = "Payba";
            string lastName = "Estolas";
            string name = firstName + middle + lastName;
            Console.WriteLine(name);
            Console.ReadLine();


            String name1 = "michael estolas";
            name1 = name1.ToUpper();
            Console.WriteLine(name1);
            Console.ReadLine();


            StringBuilder sb = new StringBuilder();
            sb.Append("The quick"); 
            sb.Append("brown fox"); 
            sb.Append("just sat over");
            sb.Append("the lazy dog!");
            Console.WriteLine(sb);
            Console.ReadLine();














        }
    }
}
