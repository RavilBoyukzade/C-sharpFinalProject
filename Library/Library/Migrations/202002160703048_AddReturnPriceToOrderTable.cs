namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReturnPriceToOrderTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "ReturnPrice", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "ReturnPrice");
        }
    }
}
