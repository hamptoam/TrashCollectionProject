namespace TrashCollection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixedErrors1 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Employees");
            AddColumn("dbo.Customers", "Employee_Id", c => c.Int());
            AddColumn("dbo.Employees", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Employees", "FirstName", c => c.String());
            AddPrimaryKey("dbo.Employees", "Id");
            CreateIndex("dbo.Customers", "Employee_Id");
            AddForeignKey("dbo.Customers", "Employee_Id", "dbo.Employees", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "Employee_Id", "dbo.Employees");
            DropIndex("dbo.Customers", new[] { "Employee_Id" });
            DropPrimaryKey("dbo.Employees");
            AlterColumn("dbo.Employees", "FirstName", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Employees", "Id");
            DropColumn("dbo.Customers", "Employee_Id");
            AddPrimaryKey("dbo.Employees", "firstName");
        }
    }
}
