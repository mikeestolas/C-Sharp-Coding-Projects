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

            Console.ReadLine();

            
        }
        
    }
}
