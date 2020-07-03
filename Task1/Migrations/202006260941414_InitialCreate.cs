namespace Task1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.File",
                c => new
                    {
                        FileType = c.Int(nullable: false),
                        Name = c.String(),
                        Desc = c.String(),
                        Task_id = c.Int(),
                    })
                .PrimaryKey(t => t.FileType)
                .ForeignKey("dbo.Task", t => t.Task_id)
                .Index(t => t.Task_id);
            
            CreateTable(
                "dbo.Task",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        why = c.String(),
                        what = c.String(),
                        how = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.File", "Task_id", "dbo.Task");
            DropIndex("dbo.File", new[] { "Task_id" });
            DropTable("dbo.Task");
            DropTable("dbo.File");
        }
    }
}
