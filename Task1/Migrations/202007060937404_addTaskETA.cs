namespace Task1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTaskETA : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Task", "eta", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Task", "eta");
        }
    }
}
