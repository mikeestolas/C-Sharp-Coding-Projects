using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Assignment_CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                 
                var stud = new Student()
                {
                    StudentName = "Bruce Lee",
                    DateOfBirth = new DateTime(2020,01,01),
                    Height = 75,
                    Weight = 60,
                    Photo = new Byte[1],
                    
                    
                    
                    
                };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
            Console.WriteLine("Data has been Saved.");
            Console.ReadLine();
        }
    }
}
