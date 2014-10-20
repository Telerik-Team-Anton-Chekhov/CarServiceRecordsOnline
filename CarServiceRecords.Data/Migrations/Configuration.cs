namespace CarServiceRecords.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using CarServiceRecords.Data;

    public sealed class Configuration : DbMigrationsConfiguration<CarServiceRecordsDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(CarServiceRecordsDbContext context)
        {
            // Seed information here
        }
    }
}
