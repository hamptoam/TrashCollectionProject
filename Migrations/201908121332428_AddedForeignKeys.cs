namespace TrashCollection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedForeignKeys : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.
                
                ");
            AddColumn("dbo.Customers", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Customers", "ApplicationId", c => c.String(maxLength: 128));
            AddColumn("dbo.Employees", "phoneNumber", c => c.String());
            AddColumn("dbo.Employees", "ApplicationId", c => c.String(maxLength: 128));
            AlterColumn("dbo.Customers", "FirstName", c => c.String());
            AddPrimaryKey("dbo.Customers", "Id");
            CreateIndex("dbo.Customers", "ApplicationId");
            CreateIndex("dbo.Employees", "ApplicationId");
            AddForeignKey("dbo.Customers", "ApplicationId", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Employees", "ApplicationId", "dbo.AspNetUsers", "Id");
            DropColumn("dbo.Employees", "PhoneNumber_Number");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "PhoneNumber_Number", c => c.String(nullable: false));
            DropForeignKey("dbo.Employees", "ApplicationId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Customers", "ApplicationId", "dbo.AspNetUsers");
            DropIndex("dbo.Employees", new[] { "ApplicationId" });
            DropIndex("dbo.Customers", new[] { "ApplicationId" });
            DropPrimaryKey("dbo.Customers");
            AlterColumn("dbo.Customers", "FirstName", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Employees", "ApplicationId");
            DropColumn("dbo.Employees", "phoneNumber");
            DropColumn("dbo.Customers", "ApplicationId");
            DropColumn("dbo.Customers", "Id");
            AddPrimaryKey("dbo.Customers", "FirstName");
        }
    }
}
