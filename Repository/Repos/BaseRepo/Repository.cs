using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Repository.Repos.BaseRepo
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly BookDbContext _db;
        private DbSet<T> dbSet;

        public Repository(BookDbContext db)
        {
            _db = db;
            dbSet = _db.Set<T>();
        }
        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public bool Any(Expression<Func<T, bool>> filter)
        {
            return dbSet.Any(filter);
        }

        public IEnumerable<T> GetAll()
        {
            return dbSet.AsEnumerable();
        }
        public T GetFirstOrDefault(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = dbSet;

            query = query.Where(filter);
            return query.FirstOrDefault();
        }
        public void Update(T entity)
        {
            dbSet.Update(entity);
        }
        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }
        public void RemoveRange(IEnumerable<T> entity)
        {
            dbSet.RemoveRange(entity);
        }
        public async Task<T> GetById<TId>(TId id)
        {
            return await _db.Set<T>().FindAsync(id);
        }
    }
    public interface IRepository <T> where T : class
    {
        T GetFirstOrDefault(Expression<Func<T, bool>> filter);
        Task<T> GetById<TId>(TId id);
        IEnumerable<T> GetAll();
        bool Any(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entity);
    }
}
