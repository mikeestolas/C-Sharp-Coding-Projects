using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAssignment
{
    class Program
    {

        //public enum araw
        //{
        //    Monday = 0,    
        //    Tuesday,   
        //    Wednesday,    
        //    Thursday,      
        //    Friday,        
        //    Saturday,       
        //    Sunday        
        //}

        static void Main(string[] args)

        {
            //while (true)
            try
            {
                //DayOfWeek today = DateTime.Today.DayOfWeek;
                Console.WriteLine("Enter the day today:");
                string UserIn = Convert.ToString(Console.ReadLine());
                //int enumVal = Convert.ToInt32(today);

                DayOfWeek today = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), UserIn);
                Console.WriteLine("Have a nice" + today);
                Console.ReadLine();
                isvalid = true;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Please enter an actual day of the week");
            }
            Console.ReadLine();




                    //    if (OneWeek.araw.IsDefined(typeof(araw), UserIn))
                    //        {
                    //        Console.WriteLine(UserIn + " is in the list but today is " + today + "  with enum value of " + enumVal);
                    //        }
                    //    break;  

                    //}
                    //        catch (FormatException ex)
                    //        {
                    //            Console.WriteLine(ex.Message);
                    //            Console.WriteLine("Please enter the correct day today!");
                    //            Console.ReadLine();
                    //    //return;
                    //}
                    //        catch (Exception ex)
                    //        {       
                    //            Console.WriteLine(ex.Message); //general error execption
                    //        }


                    ////}
                    ////else
                    ////{
                    ////          Console.WriteLine("Enum Not Exists");
                    ////}
                    //        finally
                    //        {
                    //            Console.ReadLine();
                    //        }
                }
    }
}
