namespace TrashCollection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPickUpDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "pickupDate", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "pickupDate");
        }
    }
}
