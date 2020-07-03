namespace Task1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test3 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.File", name: "Task_id", newName: "TaskId");
            RenameIndex(table: "dbo.File", name: "IX_Task_id", newName: "IX_TaskId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.File", name: "IX_TaskId", newName: "IX_Task_id");
            RenameColumn(table: "dbo.File", name: "TaskId", newName: "Task_id");
        }
    }
}
