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

        public static bool operator ==(Employee employee, Employee employee2)
        {
            if (employee.ID == employee2.ID)
                return true;
            else
                return false;

          
            //return employee.ID == employee2.ID;
        }

        public static bool operator !=(Employee employee, Employee employee2)
        {
            return employee.ID != employee2.ID;
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

