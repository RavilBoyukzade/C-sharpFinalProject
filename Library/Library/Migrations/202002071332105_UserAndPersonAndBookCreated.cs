namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserAndPersonAndBookCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookName = c.String(),
                        AuthorFullName = c.String(),
                        WriteDate = c.DateTime(),
                        Genre = c.String(),
                        Count = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Surname = c.String(nullable: false, maxLength: 50),
                        PhoneNumber = c.Int(nullable: false),
                        BookId = c.Int(nullable: false),
                        LibraryCode = c.String(nullable: false, maxLength: 20),
                        ReciveDate = c.DateTime(),
                        DeadlineDate = c.DateTime(),
                        BookCount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Email = c.String(),
                        Password = c.Int(nullable: false),
                        Level = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.People");
            DropTable("dbo.Books");
        }
    }
}
