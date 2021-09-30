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
            DateTime d1 = DateTime.Now;
            Console.WriteLine("Current time: " + DateTime.Now);
            DateTime dt1 = d1.AddHours(userIn);
            Console.WriteLine("after adding your number is : " + dt1);

            
            Console.ReadLine();



        }
    }
}
