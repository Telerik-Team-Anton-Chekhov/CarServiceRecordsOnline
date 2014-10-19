namespace Application.Data.Interfaces
{
    using CarServiceRecords.Models;

    public interface IDataProvider
    {
        IRepository<User> Users { get; }

        //Other Repos Here

        int SaveChanges();
    }
}