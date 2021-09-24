using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Employees = new List<Employee>();
            List<string> firstnames = new List<string>()
{
    "Joe", "Jeff", "Joe", "Kate", "Ann", "Rocel", "Mike", "Chito", "Susan", "Bearozz"
};

            List<string> lastnames = new List<string>()
{
    "Jackson", "Smith", "Miller", "Turner", "Johnson", "Bermudez", "Estolas", "Yanoc", "Bala", "Hemmatti"
};

            List<int> IDs = new List<int>()
{
    34, 54, 4, 2, 43, 1, 3, 45, 54, 15
};

            List<int> indexes = new List<int>()
{
    0, 1, 2, 3, 4, 5, 6, 7, 8, 9
};

            foreach (int index in indexes)
            {
                Employee Employeeobject = new Employee();
                Employeeobject.firstname = firstnames[index];
                Employeeobject.lastname = lastnames[index];
                Employeeobject.ID = IDs[index];
                Employees.Add(Employeeobject);
              
            }
            
            foreach ( var empl in Employees) 

            {
                
                if (empl.firstname == "Joe")//Using a foreach loop, create a new list of all employees with the first name "Joe
                {
                    
                    Console.WriteLine(  empl.firstname + " " + empl.lastname + " " + empl.ID);
                    
                }
                
            }

            Console.WriteLine();

            var empl2 = Employees.FindAll(m => m.firstname == "Joe"); //Perform the same action again, but this time with a lambda expression.
            foreach (var emp2 in empl2)
            {
                Console.WriteLine(emp2.firstname + " " + emp2.lastname + " " + emp2.ID);
            }

            Console.WriteLine();

            var id = Employees.FindAll(d => d.ID > 5); //Using a lambda expression, make a list of all employees with an Id number greater than 5.
            foreach (var idm in id)
            {
                
                    Console.WriteLine(idm.firstname + " " + idm.lastname + " " + idm.ID);
                

            }
            Console.WriteLine();

            foreach (Employee Employee in Employees)
            {
                
                Console.WriteLine(Employee.firstname + " " + Employee.lastname + " " + Employee.ID);
            }

            Console.ReadLine();
        }
    }
}
