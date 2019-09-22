namespace TrashCollection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixingexception : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "pickupDate", c => c.DateTime());
            AlterColumn("dbo.Customers", "oneTimePickUpDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "oneTimePickUpDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Customers", "pickupDate", c => c.DateTime(nullable: false));
        }
    }
}
