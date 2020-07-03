namespace Task1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.File", "Description", c => c.String());
            DropColumn("dbo.File", "Desc");
        }
        
        public override void Down()
        {
            AddColumn("dbo.File", "Desc", c => c.String());
            DropColumn("dbo.File", "Description");
        }
    }
}
