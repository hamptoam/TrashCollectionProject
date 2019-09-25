namespace TrashCollection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatingModels : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.Customers", new[] { "Customer_Id" });
            DropColumn("dbo.Customers", "Customer_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Customer_Id", c => c.Int());
            CreateIndex("dbo.Customers", "Customer_Id");
            AddForeignKey("dbo.Customers", "Customer_Id", "dbo.Customers", "Id");
        }
    }
}
