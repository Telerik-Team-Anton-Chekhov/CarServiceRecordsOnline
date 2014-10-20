namespace CarServiceRecords.Common
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    using CarServiceRecords.Models;

    public interface IDbContext
    {
        IDbSet<Car> Cars { get; set; }

        IDbSet<CarMake> CarMakes { get; set; }

        IDbSet<CarModel> CarModels { get; set; }

        IDbSet<CarService> CarServices { get; set; }

        IDbSet<RepairJob> RepairJobs { get; set; }

        IDbSet<SitePage> SitePages { get; set; }

        IDbSet<Town> Towns { get; set; }

        IDbSet<ServiceComments> ServiceComments { get; set; }

        int SaveChanges();

        IDbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
    }
}