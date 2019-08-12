namespace TrashCollection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedBalanceInformation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "oneTimePickUpDate", c => c.String());
            DropColumn("dbo.Customers", "balance");
            DropColumn("dbo.Customers", "startDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "startDate", c => c.String());
            AddColumn("dbo.Customers", "balance", c => c.String());
            DropColumn("dbo.Customers", "oneTimePickUpDate");
        }
    }
}
