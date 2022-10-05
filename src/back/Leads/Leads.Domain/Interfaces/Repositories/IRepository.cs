using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;

namespace Leads.Domain.Interfaces.Repositories
{
    public interface IRepository<T> : IDisposable where T : class
    {
        EntityEntry<T> Add(T obj);
        T GetById(int id);
        IEnumerable<T> GetAll();
        T Update(T obj);
        void Remove(int id);
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        int SaveChanges();
    }
}
