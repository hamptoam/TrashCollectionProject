namespace TrashCollection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMigrationAddedListToEmployeeModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "Employee_Id", "dbo.Employees");
            AddColumn("dbo.Customers", "Employee_Id1", c => c.Int());
            CreateIndex("dbo.Customers", "Employee_Id1");
            AddForeignKey("dbo.Customers", "Employee_Id", "dbo.Employees", "Id");
            AddForeignKey("dbo.Customers", "Employee_Id1", "dbo.Employees", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "Employee_Id1", "dbo.Employees");
            DropForeignKey("dbo.Customers", "Employee_Id", "dbo.Employees");
            DropIndex("dbo.Customers", new[] { "Employee_Id1" });
            DropColumn("dbo.Customers", "Employee_Id1");
            AddForeignKey("dbo.Customers", "Employee_Id", "dbo.Employees", "Id");
        }
    }
}
