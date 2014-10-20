namespace CarServiceRecords.Common
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    using CarServiceRecords.Models;

    public interface IDbContext
    {
        //// IDbSets here

        int SaveChanges();

        IDbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
    }
}