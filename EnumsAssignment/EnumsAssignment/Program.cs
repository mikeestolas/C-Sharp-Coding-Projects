using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAssignment
{
    class Program
    {
        
        public enum araw
        {
            Monday,    // 0
            Tuesday,   // 1
            Wednesday,    // 6
            Thursday,      // 7
            Friday,        // 8
            Saturday,       // 9
            Sunday        // 10
        }
        public string UserIn { get; set; }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the day today:");
            string UserIn = Convert.ToString(Console.ReadLine());

            

            DayOfWeek today = DateTime.Today.DayOfWeek;
            Console.WriteLine("Today is {0}",
                today);

            if (UserIn ==  )



            
            {
                Console.WriteLine("Testing lang");
            }




            Console.ReadLine();
        }
        

        //         enum araw
        //      {
        //          Monday = 1,
        //          Tuesday,
        //          Wednesday,
        //          Thursday,
        //          Friday,
        //          Saturday,
        //          Sunday
        //      }
        //      static void Main(string[] args)
        //      {

        //          Console.WriteLine("Enter the day today:");
        //              string UserIn = Convert.ToString(Console.ReadLine());

        //              int daynum = (int) araw







        //}
    }
}
