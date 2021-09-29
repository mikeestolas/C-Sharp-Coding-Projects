using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DatetimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int userIn = Convert.ToInt32(Console.ReadLine());
            DateTime dateTime = new DateTime(2021, 10, 1, userIn, 0, 0);
            Console.WriteLine(dateTime);

            
            Console.ReadLine();



        }
    }
}
