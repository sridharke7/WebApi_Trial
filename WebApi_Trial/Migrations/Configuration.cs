namespace WebApi_Trial.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApi_Trial.SchoolDatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "EF6Console.SchoolDatabaseContext";
        }

        protected override void Seed(WebApi_Trial.SchoolDatabaseContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Students.AddOrUpdate(x => x.StudentID,
    new Student() { StudentID = 1, FirstName = "Jane", LastName = "Austen" },
    new Student() { StudentID = 2, FirstName = "Charles", LastName = "Dickens" },
    new Student() { StudentID = 3, FirstName = "Miguel", LastName = "Carvantes" }
    );

            context.Grades.AddOrUpdate(x => x.GradeId,
                new Grade()
                {
                    GradeId = 1,
                    GradeName = "A",
                    Section = "M1",

                },
                new Grade()
                {
                    GradeId = 2,
                    GradeName = "B",
                    Section = "M2",

                },
                new Grade()
                {
                    GradeId = 3,
                    GradeName = "C",
                    Section = "M3",

                }
                );
        }
    }
}
