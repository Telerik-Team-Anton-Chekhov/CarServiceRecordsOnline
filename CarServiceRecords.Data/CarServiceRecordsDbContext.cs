namespace CarServiceRecords.Data
{
    using System.Data.Entity;

    using CarServiceRecords.Common;
    using CarServiceRecords.Data.Migrations;
    using CarServiceRecords.Models;
    
    using Microsoft.AspNet.Identity.EntityFramework;

    public class CarServiceRecordsDbContext : IdentityDbContext<User>, IDbContext
    {
        public CarServiceRecordsDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<CarServiceRecordsDbContext, Configuration>());
        }

        public static CarServiceRecordsDbContext Create()
        {
            return new CarServiceRecordsDbContext();
        }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }
    }
}
