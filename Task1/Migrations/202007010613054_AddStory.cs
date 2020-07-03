namespace Task1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Story",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false),
                        description = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.Task", "StoryId", c => c.Int());
            AlterColumn("dbo.Task", "name", c => c.String(nullable: false));
            CreateIndex("dbo.Task", "StoryId");
            AddForeignKey("dbo.Task", "StoryId", "dbo.Story", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Task", "StoryId", "dbo.Story");
            DropIndex("dbo.Task", new[] { "StoryId" });
            AlterColumn("dbo.Task", "name", c => c.String());
            DropColumn("dbo.Task", "StoryId");
            DropTable("dbo.Story");
        }
    }
}
