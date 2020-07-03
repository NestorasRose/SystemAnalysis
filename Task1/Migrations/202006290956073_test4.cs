namespace Task1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.File", "TaskId", "dbo.Task");
            AddForeignKey("dbo.File", "TaskId", "dbo.Task", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.File", "TaskId", "dbo.Task");
            AddForeignKey("dbo.File", "TaskId", "dbo.Task", "id");
        }
    }
}
