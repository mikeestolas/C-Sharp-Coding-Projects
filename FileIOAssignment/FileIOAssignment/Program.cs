using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FileIOAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter a number:");
            string userIn = Console.ReadLine();
           


            File.WriteAllText(@"C:\Users\Admin\OneDrive - Sysco Corporation\Desktop\Logs\log.txt", userIn);

            Console.WriteLine("You have enter " + userIn);

            string text = System.IO.File.ReadAllText(@"C:\Users\Admin\OneDrive - Sysco Corporation\Desktop\Logs\log.txt");
            Console.WriteLine("coming from the text file: " + text);
            Console.ReadLine();



        }
    }
}
