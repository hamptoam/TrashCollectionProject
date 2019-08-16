namespace TrashCollection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedZipCodeToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "zipCode", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "zipCode");
        }
    }
}
