namespace TrashCollection.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TrashCollection.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TrashCollection.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TrashCollection.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Customers.AddOrUpdate(x => x.CustomerId,
              new Customer() { CustomerId = 1040, FirstName = "Amelia", LastName = "Hampton", Email = "testtest@test.com", dayOfWeek = DayOfWeek.Wednesday, pickupDate = new DateTime(2019, 09, 25), oneTimePickUpDate = new DateTime(2019, 09, 25), Latitude = "", Longitutde = "", Address1 = "1928 e Trowbridge St", Address2 = "", City = "Milwaukee", State = "Wisconsin", Zip = "53207", Country = "United States" }
              );

        }
    }
}
