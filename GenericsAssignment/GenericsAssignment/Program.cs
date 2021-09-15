using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
          
            Employee emp1 = new Employee()
            {
                ID = 101,
                Name = "Pranaya",
                Gender = "Male",
                Salary = 5000,
                Things = "Beautiful"
            };
            Employee emp2 = new Employee()
            {
                ID = 102,
                Name = "Priyanka",
                Gender = "Female",
                Salary = 7000,
                Things = "Faithful"
            };
            Employee emp3 = new Employee()
            {
                ID = 103,
                Name = "Anurag",
                Gender = "Male",
                Salary = 5500,
                Things = "Honest"
            };
            Employee emp4 = new Employee()
            {
                ID = 104,
                Name = "Sambit",
                Gender = "Male",
                Salary = 6500,
                Things = "Punctual"
            };

            
            List<Employee> listEmployees = new List<Employee>();

            listEmployees.Add(emp1);
            listEmployees.Add(emp2);
            listEmployees.Add(emp3);
            listEmployees.Add(emp4);


            Employee emp = listEmployees[0];

            foreach (Employee e in listEmployees)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Gender = {2}, Salary = {3}, Things = {4}",
                        e.ID, e.Name, e.Gender, e.Salary, e.Things);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
        
    }
}
