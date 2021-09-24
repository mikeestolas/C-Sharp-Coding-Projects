using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionAssignment
{
    public class Employee
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public int ID { get; set; }
        public Employee(string _firstName, string _lastName, int _ID)
        {
            firstname = _firstName;
            lastname = _lastName;
            ID = _ID;
        }

        public Employee()
        {
           
        }
    }
}
