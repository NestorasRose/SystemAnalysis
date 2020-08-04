namespace Task1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStoryIteration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Story", "iteration", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Story", "iteration");
        }
    }
}
