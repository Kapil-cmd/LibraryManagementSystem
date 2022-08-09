using Repository.Entities;
using Repository.Repos.BaseRepo;

namespace Repository.Repos.BookRep
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        public BookRepository(BookDbContext db) : base(db)
        {
        }
    }
    public interface IBookRepository : IRepository<Book>
    {
    }
}
