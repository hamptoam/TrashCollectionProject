namespace TrashCollection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerIsPickedUp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "isPickedUp", c => c.Boolean(nullable: false));
            DropColumn("dbo.Customers", "deliveryStatus");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "deliveryStatus", c => c.String());
            DropColumn("dbo.Customers", "isPickedUp");
        }
    }
}
