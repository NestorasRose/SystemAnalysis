namespace Task1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStoryDiagram : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Story", "diagram", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Story", "diagram");
        }
    }
}
