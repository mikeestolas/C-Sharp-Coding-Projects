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

            Employee<int> emp1 = new Employee<int>()
            {
                ID = 101,
                
            };  
            Employee<string> emp2 = new Employee<string>()
            {
               
                Name = "Priyanka",
                
            };

            emp1.things  = new List<int>();
            emp2.things  = new List<string>();

            //foreach(List<int> i in  )
            //{
            //    Console.WriteLine(i);

            //}
            Console.WriteLine(emp1.ID + emp2.Name);

            
            
            
            
                
            Console.ReadLine();

            
            
            
            


            
            
 
        }
        
    }
}
