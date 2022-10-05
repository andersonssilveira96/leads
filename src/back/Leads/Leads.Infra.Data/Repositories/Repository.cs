using Leads.Domain.Interfaces.Repositories;
using Leads.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;

namespace Leads.Infra.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected LeadContext Db;
        protected DbSet<T> DbSet;

        public Repository(LeadContext context)
        {
            Db = context;
            DbSet = Db.Set<T>();
        }

        public virtual EntityEntry<T> Add(T obj)
        {
            var returnObj = DbSet.Add(obj);
            return returnObj;
        }

        public virtual T GetById(int id)
        {
            var returnObj = DbSet.Find(id);

            if (returnObj != null)
                Db.Entry(returnObj).State = EntityState.Detached;

            return returnObj;
        }

        public virtual IEnumerable<T> GetAll()
        {
            return DbSet.ToList();
        }

        public virtual T Update(T obj)
        {
            var entry = Db.Entry(obj);
            DbSet.Attach(obj);
            entry.State = EntityState.Modified;

            return obj;
        }

        public virtual void Remove(int id)
        {
            DbSet.Remove(DbSet.Find(id));
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
