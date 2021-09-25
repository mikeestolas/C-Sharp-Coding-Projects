using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAssignment
{
    

    public class Employee<T>
    {
        public int empid { get; set; }
        public string empfn { get; set; }
        public List<T> things;

    }
    

    



}
    

