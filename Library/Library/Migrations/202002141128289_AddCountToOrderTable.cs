namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCountToOrderTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Count", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "Count");
        }
    }
}
