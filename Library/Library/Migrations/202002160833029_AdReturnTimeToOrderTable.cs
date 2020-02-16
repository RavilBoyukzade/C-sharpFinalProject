namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdReturnTimeToOrderTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "ReturnTime", c => c.DateTime(nullable: false, storeType: "date"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "ReturnTime");
        }
    }
}
