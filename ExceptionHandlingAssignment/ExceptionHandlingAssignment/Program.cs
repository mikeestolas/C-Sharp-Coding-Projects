using System;

namespace ExceptionHandlingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Please type your Age :");
                int xAge = Convert.ToInt32(Console.ReadLine());

                var age = DateTime.Today.Year - xAge;

                if (xAge <= 0) throw new("Number must be positive and non zero");

                
                Console.WriteLine(d);
                Console.WriteLine("you were born on year : " + age);
            }
            

            catch (Exception ex)
            {
                
                Console.WriteLine(ex.Message + "\nYour have entered Invalid number");
               
            }
            



        }
    }
}
    

