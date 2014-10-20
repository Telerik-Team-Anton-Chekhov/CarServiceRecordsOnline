namespace CarServiceRecords.Common
{
    using CarServiceRecords.Models;

    public interface IDataProvider
    {
        IRepository<User> Users { get; }

        //// Other Repos Here

        int SaveChanges();
    }
}