using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string firstName = "Michael ";
            String middle = "Payba";
            string lastName = "Estolas";
            string name = firstName + middle + lastName;
            Console.WriteLine(name);
            Console.ReadLine();


            String name1 = "michael estolas";
            name1 = name1.ToUpper();
            Console.WriteLine(name1);
            Console.ReadLine();


            StringBuilder sb = new StringBuilder();
            sb.Append("            When I first brought my cat home from the humane society she was a mangy, \n " +
                "pitiful animal. It cost a lot to adopt her: forty dollars. And then I had to buy litter, \n " +
                "a litterbox, food, and dishes for her to eat out of."); 
            sb.Append("Two days after she came home with me she got taken to the pound by the animal warden. \n " +
                "           There's a leash law for cats in Fort Collins. If they're not in your yard they have to be on a leash. \n " +
                "Anyway, my cat is my best friend. I'm glad I got her. She sleeps under the covers with me when it's cold. \n " +
                "Sometimes she meows a lot in the middle of the night and wakes me up, though. (unfocused)");
            
            
            Console.WriteLine(sb);
            Console.ReadLine();














        }
    }
}
