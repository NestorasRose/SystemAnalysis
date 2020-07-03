namespace Task1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.File", "CurrentTaskId", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.File", "CurrentTaskId");
        }
    }
}
