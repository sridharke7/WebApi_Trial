namespace WebApi_Trial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Grades",
                c => new
                    {
                        GradeId = c.Int(nullable: false, identity: true),
                        GradeName = c.String(),
                        Section = c.String(),
                    })
                .PrimaryKey(t => t.GradeId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Grade_GradeId = c.Int(),
                    })
                .PrimaryKey(t => t.StudentID)
                .ForeignKey("dbo.Grades", t => t.Grade_GradeId)
                .Index(t => t.Grade_GradeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "Grade_GradeId", "dbo.Grades");
            DropIndex("dbo.Students", new[] { "Grade_GradeId" });
            DropTable("dbo.Students");
            DropTable("dbo.Grades");
        }
    }
}
