namespace TrashCollection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ErrorFix : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "pickupDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Customers", "oneTimePickUpDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "oneTimePickUpDate", c => c.String());
            AlterColumn("dbo.Customers", "pickupDate", c => c.String());
        }
    }
}
