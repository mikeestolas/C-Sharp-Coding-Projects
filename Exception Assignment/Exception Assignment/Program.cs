using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Assignment
{
    class Program
    {
        static void Main(string[] args)
            
        {
            while(true)
            try
            {
                
                List<int> num = new List<int>() { 10, 20, 30, 40, 50 };
                List<int> num1 = new List<int>();
                Console.WriteLine("Type a number:");
                int cnum = Convert.ToInt32(Console.ReadLine());
                
                    foreach (int n in num)
                         
                    {
                    
                        int result = n / cnum;
                   
                    Console.WriteLine(n + " divided to " + cnum + " is " + result);
                           
                    }
                    break;   
            }
                catch (FormatException ex)
                    {
                        Console.WriteLine(ex.Message); //error handling
                        Console.WriteLine("Please type a whole number."); //custom message
                        return;
                    }

            
                catch (DivideByZeroException ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Please don't divide by zero");
                    
                    }
                catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message); //general error execption
                    }
            
            finally
            {

                Console.ReadLine();
                    
            }
             

                
            



        }
    }
}
