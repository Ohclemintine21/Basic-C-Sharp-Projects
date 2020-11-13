using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApp.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("StudentDatabase")
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
