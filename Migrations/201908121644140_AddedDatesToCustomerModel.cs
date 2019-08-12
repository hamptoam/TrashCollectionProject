namespace TrashCollection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDatesToCustomerModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "startDate", c => c.String());
            AddColumn("dbo.Customers", "endDate", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "endDate");
            DropColumn("dbo.Customers", "startDate");
        }
    }
}
