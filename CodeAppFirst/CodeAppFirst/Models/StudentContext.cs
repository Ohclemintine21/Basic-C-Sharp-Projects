using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CodeAppFirst.Models;
using System.Threading.Tasks;

namespace CodeAppFirst.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("StudentDatabase")
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}