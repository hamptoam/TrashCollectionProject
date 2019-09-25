namespace TrashCollection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class daysofweek : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "dayOfWeek", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "dayOfWeek", c => c.String());
        }
    }
}
