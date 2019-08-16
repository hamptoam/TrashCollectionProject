namespace TrashCollection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeliveryStatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "deliveryStatus", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "deliveryStatus");
        }
    }
}
