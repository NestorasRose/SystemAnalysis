namespace Task1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedFileMVC : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.File", "Task_id", "dbo.Task");
            DropIndex("dbo.File", new[] { "Task_id" });
            AddColumn("dbo.File", "Task_id1", c => c.Int());
            AlterColumn("dbo.File", "Task_id", c => c.Int(nullable: false));
            CreateIndex("dbo.File", "Task_id1");
            AddForeignKey("dbo.File", "Task_id1", "dbo.Task", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.File", "Task_id1", "dbo.Task");
            DropIndex("dbo.File", new[] { "Task_id1" });
            AlterColumn("dbo.File", "Task_id", c => c.Int());
            DropColumn("dbo.File", "Task_id1");
            CreateIndex("dbo.File", "Task_id");
            AddForeignKey("dbo.File", "Task_id", "dbo.Task", "id");
        }
    }
}
