using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi_Trial;

namespace WebApi_Trial
{
    public class SchoolDatabaseContext : DbContext
    {
        public SchoolDatabaseContext() : base("SchoolDatabase")
        {
            Database.SetInitializer<SchoolDatabaseContext>(new CreateDatabaseIfNotExists<SchoolDatabaseContext>());
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}
