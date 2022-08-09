using Microsoft.AspNetCore.Http;
using Repository.Repos;
using Repository.Repos.BookRep;

namespace Repository.Work
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(BookDbContext db,IHttpContextAccessor httpContextAccessor)
        {
            _db = db;
            _httpContextAccessor = httpContextAccessor;
            BookRepository = new BookRepository(_db);
        }
        public BookDbContext _db { get; private set; }
        public IHttpContextAccessor _httpContextAccessor { get; private set; }
        public IBookRepository BookRepository { get; private set; }
        public void Save()
        {
           _db.SaveChanges();
        }
    }
    public interface IUnitOfWork
    {
        public BookDbContext _db { get; }
        IBookRepository BookRepository { get; }
        IHttpContextAccessor _httpContextAccessor { get; }
        void Save();
    }
}
