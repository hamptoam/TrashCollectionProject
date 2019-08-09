namespace TrashCollection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeesandCustomers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "timeandDayPreference", c => c.DateTime(nullable: false));
            AddColumn("dbo.Employees", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "Email");
            DropColumn("dbo.Customers", "timeandDayPreference");
        }
    }
}
