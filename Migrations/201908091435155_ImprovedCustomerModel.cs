namespace TrashCollection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImprovedCustomerModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "pickUpAddress", c => c.String());
            AddColumn("dbo.Customers", "billingAddress", c => c.String());
            AddColumn("dbo.Customers", "dayOfWeek", c => c.String());
            AddColumn("dbo.Customers", "phoneNumber", c => c.String());
            DropColumn("dbo.Customers", "Address");
            DropColumn("dbo.Customers", "timeandDayPreference");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "timeandDayPreference", c => c.DateTime(nullable: false));
            AddColumn("dbo.Customers", "Address", c => c.String());
            DropColumn("dbo.Customers", "phoneNumber");
            DropColumn("dbo.Customers", "dayOfWeek");
            DropColumn("dbo.Customers", "billingAddress");
            DropColumn("dbo.Customers", "pickUpAddress");
        }
    }
}
