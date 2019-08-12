namespace TrashCollection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCustomerBalance : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "balance", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "balance");
        }
    }
}
