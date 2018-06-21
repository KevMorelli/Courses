namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBInitial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.News",
                c => new
                    {
                        NewID = c.String(nullable: false, maxLength: 128),
                        Title = c.String(nullable: false, maxLength: 200),
                        Description = c.String(nullable: false, maxLength: 200),
                        CreationDate = c.DateTime(),
                        EditionDate = c.DateTime(),
                        CreatedBy_Username = c.String(nullable: false, maxLength: 50),
                        EditedBy_Username = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.NewID)
                .ForeignKey("dbo.Users", t => t.CreatedBy_Username, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.EditedBy_Username)
                .Index(t => t.CreatedBy_Username)
                .Index(t => t.EditedBy_Username);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Username);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.News", "EditedBy_Username", "dbo.Users");
            DropForeignKey("dbo.News", "CreatedBy_Username", "dbo.Users");
            DropIndex("dbo.News", new[] { "EditedBy_Username" });
            DropIndex("dbo.News", new[] { "CreatedBy_Username" });
            DropTable("dbo.Users");
            DropTable("dbo.News");
        }
    }
}
