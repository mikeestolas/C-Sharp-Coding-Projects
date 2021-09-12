using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAssignment
{
    class Employee : Person
    {
        public static int id = 1212;
        public override void SayName()
        {

            base.SayName();
            Console.WriteLine("Employee ID: {0}", id);
            //Console.WriteLine("FirstName: {0}", FirstName);
            //Console.WriteLine("LastName: {0}", LastName);
            Console.ReadLine();

        }
    }
}
