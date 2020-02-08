namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserAndPersonAndBookDataAnnontionsAdd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Status", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Books", "BookName", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Books", "AuthorFullName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Books", "WriteDate", c => c.DateTime(storeType: "date"));
            AlterColumn("dbo.Books", "Genre", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.People", "ReciveDate", c => c.DateTime(storeType: "date"));
            AlterColumn("dbo.People", "DeadlineDate", c => c.DateTime(storeType: "date"));
            AlterColumn("dbo.Users", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Users", "Surname", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Users", "Email", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Email", c => c.String());
            AlterColumn("dbo.Users", "Surname", c => c.String());
            AlterColumn("dbo.Users", "Name", c => c.String());
            AlterColumn("dbo.People", "DeadlineDate", c => c.DateTime());
            AlterColumn("dbo.People", "ReciveDate", c => c.DateTime());
            AlterColumn("dbo.Books", "Genre", c => c.String());
            AlterColumn("dbo.Books", "WriteDate", c => c.DateTime());
            AlterColumn("dbo.Books", "AuthorFullName", c => c.String());
            AlterColumn("dbo.Books", "BookName", c => c.String());
            DropColumn("dbo.Users", "Status");
        }
    }
}
