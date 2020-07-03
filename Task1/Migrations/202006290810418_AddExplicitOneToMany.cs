namespace Task1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddExplicitOneToMany : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.File");
            AddColumn("dbo.File", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.File", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.File");
            DropColumn("dbo.File", "Id");
            AddPrimaryKey("dbo.File", "FileType");
        }
    }
}
