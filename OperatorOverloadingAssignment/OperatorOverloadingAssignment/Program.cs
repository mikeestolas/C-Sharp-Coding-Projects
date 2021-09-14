using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingAssignment
{
    class Program
    {
         static void Main(string[]args)
        {
           Employee example1 = new Employee();
            

            example1.FirstName = "Michael";
            example1.LastName = "Estolas";
            example1.ID = 24923;

            Employee example2 = new Employee();
            example2.FirstName = "Rocel";
            example2.LastName = "Bermudez";
            example2.ID = 39292;

            if (example1 == example2)
            {
                Console.WriteLine("Employee1 is equal to Employee2");
            }
            else
            {
                Console.WriteLine("Employee1 is not equal to Employee2");
            }
            Console.ReadLine();

            
        }
        
    }
}
