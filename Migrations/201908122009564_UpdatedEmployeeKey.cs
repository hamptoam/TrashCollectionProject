namespace TrashCollection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedEmployeeKey : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "employeeAddress", c => c.String());
            DropColumn("dbo.Employees", "Address");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "Address", c => c.String());
            DropColumn("dbo.Employees", "employeeAddress");
        }
    }
}
