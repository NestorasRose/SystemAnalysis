namespace Task1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRequiredAndAllowHTML : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Task", "name", c => c.String());
            AlterColumn("dbo.File", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.File", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.Task", "why", c => c.String(nullable: false));
            AlterColumn("dbo.Task", "what", c => c.String(nullable: false));
            AlterColumn("dbo.Task", "how", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Task", "how", c => c.String());
            AlterColumn("dbo.Task", "what", c => c.String());
            AlterColumn("dbo.Task", "why", c => c.String());
            AlterColumn("dbo.File", "Description", c => c.String());
            AlterColumn("dbo.File", "Name", c => c.String());
            DropColumn("dbo.Task", "name");
        }
    }
}
