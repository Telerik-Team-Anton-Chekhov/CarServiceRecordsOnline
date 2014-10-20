namespace CarServiceRecords.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public sealed class Configuration : DbMigrationsConfiguration<CarServiceRecordsDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(CarServiceRecords.Data.CarServiceRecordsDbContext context)
        {
        }
    }
}
