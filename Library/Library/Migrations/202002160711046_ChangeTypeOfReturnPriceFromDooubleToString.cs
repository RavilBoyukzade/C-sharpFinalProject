namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTypeOfReturnPriceFromDooubleToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "ReturnPrice", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "ReturnPrice", c => c.Double(nullable: false));
        }
    }
}
