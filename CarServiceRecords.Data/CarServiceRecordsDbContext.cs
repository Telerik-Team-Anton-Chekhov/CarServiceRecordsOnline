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

        public virtual IDbSet<Car> Cars { get; set; }

        public virtual IDbSet<CarMake> CarMakes { get; set; }

        public virtual IDbSet<CarModel> CarModels { get; set; }

        public virtual IDbSet<CarService> CarServices { get; set; }

        public virtual IDbSet<RepairJob> RepairJobs { get; set; }

        public virtual IDbSet<SitePage> SitePages { get; set; }

        public virtual IDbSet<Town> Towns { get; set; }

        public virtual IDbSet<ServiceComments> ServiceComments { get; set; }

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
