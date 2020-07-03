namespace Task1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTaskCascadeOnDelete : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Task", "StoryId", "dbo.Story");
            AddForeignKey("dbo.Task", "StoryId", "dbo.Story", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Task", "StoryId", "dbo.Story");
            AddForeignKey("dbo.Task", "StoryId", "dbo.Story", "id");
        }
    }
}
