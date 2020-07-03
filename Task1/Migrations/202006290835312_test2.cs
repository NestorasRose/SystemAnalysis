namespace Task1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.File", "CurrentTaskId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.File", "CurrentTaskId", c => c.Int());
        }
    }
}
