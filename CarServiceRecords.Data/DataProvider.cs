namespace CarServiceRecords.Data
{
    using System;
    using System.Collections.Generic;

    using CarServiceRecords.Common;
    using CarServiceRecords.Models;

    public class DataProvider : IDataProvider
    {
        private IDbContext databaseContext;
        private IDictionary<Type, object> createdRepositories;

        public DataProvider(IDbContext context)
        {
            this.databaseContext = context;
            this.createdRepositories = new Dictionary<Type, object>();
        }

        public IRepository<User> Users
        {
            get { return this.GetRepository<User>(); }
        }

        public IRepository<Car> Cars
        {
            get { return this.GetRepository<Car>(); }
        }

        public IRepository<CarMake> CarMakes
        {
            get { return this.GetRepository<CarMake>(); }
        }

        public IRepository<CarModel> CarModels
        {
            get { return this.GetRepository<CarModel>(); }
        }

        public IRepository<CarService> CarServices
        {
            get { return this.GetRepository<CarService>(); }
        }

        public IRepository<RepairJob> RepairJobs
        {
            get { return this.GetRepository<RepairJob>(); }
        }

        public IRepository<SitePage> SitePages
        {
            get { return this.GetRepository<SitePage>(); }
        }

        public IRepository<Town> Town
        {
            get { return this.GetRepository<Town>(); }
        }

        public int SaveChanges()
        {
            return this.databaseContext.SaveChanges();
        }

        private IRepository<T> GetRepository<T>() where T : class
        {
            var typeOfRepository = typeof(T);

            if (!this.createdRepositories.ContainsKey(typeOfRepository))
            {
                var newRepository = Activator.CreateInstance(typeof(Repository<T>), this.databaseContext);
                this.createdRepositories.Add(typeOfRepository, newRepository);
            }

            return (IRepository<T>)this.createdRepositories[typeOfRepository];
        }
    }
}
