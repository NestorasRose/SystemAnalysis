namespace Task1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveTaskID : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.File", new[] { "Task_id1" });
            DropColumn("dbo.File", "Task_id");
            RenameColumn(table: "dbo.File", name: "Task_id1", newName: "Task_id");
            AlterColumn("dbo.File", "Task_id", c => c.Int());
            CreateIndex("dbo.File", "Task_id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.File", new[] { "Task_id" });
            AlterColumn("dbo.File", "Task_id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.File", name: "Task_id", newName: "Task_id1");
            AddColumn("dbo.File", "Task_id", c => c.Int(nullable: false));
            CreateIndex("dbo.File", "Task_id1");
        }
    }
}
