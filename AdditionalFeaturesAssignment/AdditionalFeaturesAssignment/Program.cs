using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AdditionalFeaturesAssignment
{
    class Program
    {

        public class Student
        {
            int id;
            string name;
            string city;

            Student(int id, string name)
            {
                this.id = id;
                this.name = name;
            }
            Student(int id, string name, string city)
            {
                this.id = id;
                this.name = name;

                this.city = city;
            }

            void display()
            {
                Console.Out.WriteLine("id: " + id + " name :" + name + " city: " + city);
            }

            public static void Main(string[] args)
            {
                var s = new Student(1, "Mike");
                s.display();
                Student s2 = new Student(2, "Mike", "Manila");
                s2.display();
                Console.ReadLine();

            }



            //static void Main(string[] args)
            //{
            //    //// Constant variables
            //    //const string name = "Michael Estolas";
            //    //const string location = "Earth";
            //    //const int age = 32;

            //    //var string name2 = "Rocel Bermudez";

            //    //// This will throw compile time error
            //    ////name = "Rohini Alavala";
            //    //Console.WriteLine("Name: {0}", name);
            //    //Console.WriteLine("Location: {0}", location);
            //    //Console.WriteLine("Age: {0}", age);
            //    //Console.WriteLine("\nPress Enter Key to Exit..");
            //    //Console.ReadLine();


        }


    }
}
