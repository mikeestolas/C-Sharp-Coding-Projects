
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstFinalAssignment
{
    public class ModelContext: DbContext

    {
        
        public ModelContext() : base ("name=con") { }
        public DbSet<Students> Studlist { get; set; }
    }
}
