namespace CarServiceRecords.Common
{
    using CarServiceRecords.Models;

    public interface IDataProvider
    {
        IRepository<User> Users { get; }

        IRepository<Car> Cars { get; }

        IRepository<CarMake> CarMakes { get; }

        IRepository<CarModel> CarModels { get; }

        IRepository<CarService> CarServices { get; }

        IRepository<RepairJob> RepairJobs { get; }

        IRepository<SitePage> SitePages { get; }

        IRepository<Town> Town { get; }

        int SaveChanges();
    }
}