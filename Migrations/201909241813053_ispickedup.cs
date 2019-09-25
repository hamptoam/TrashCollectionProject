namespace TrashCollection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ispickedup : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "isPickedUp", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "isPickedUp");
        }
    }
}
