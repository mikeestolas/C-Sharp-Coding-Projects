using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingAssignment
{
    public class Employee : Person
    {


        public int ID { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }

        public static bool operator ==(Employee employee1, Employee employee2)
        {
            if (employee1.ID == employee2.ID)
                return true;
            //Console.WriteLine("Employee1 is equal to Employee2" + );
            else
                return false;
            
        }



        public static bool operator !=(Employee employee1, Employee employee2)

        {
            return employee1.ID != employee2.ID;
            //Console.WriteLine("Employee1 is not equal to Employee2");
        }

        public override bool Equals(object obj)
        {
            var emp = obj as Employee;
            if (emp == null)
                return false;

            return this.ID.Equals(emp.ID);

        }
        







    }
}

