namespace MVC5App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Teachers", "Student_Id", "dbo.Students");
            DropIndex("dbo.Teachers", new[] { "Student_Id" });
            CreateIndex("dbo.TeacherAssignedToStudents", "StudentId");
            AddForeignKey("dbo.TeacherAssignedToStudents", "StudentId", "dbo.Students", "Id", cascadeDelete: true);
            DropColumn("dbo.Teachers", "Student_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teachers", "Student_Id", c => c.Int());
            DropForeignKey("dbo.TeacherAssignedToStudents", "StudentId", "dbo.Students");
            DropIndex("dbo.TeacherAssignedToStudents", new[] { "StudentId" });
            CreateIndex("dbo.Teachers", "Student_Id");
            AddForeignKey("dbo.Teachers", "Student_Id", "dbo.Students", "Id");
        }
    }
}
