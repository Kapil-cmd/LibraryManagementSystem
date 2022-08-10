using Repository.Entities;
using Repository.Repos.BaseRepo;

namespace Repository.Repos.UserBookRep
{
    public class UserBookRepository : Repository<UserBook>, IUserBookRepository
    {
        public UserBookRepository(BookDbContext db) : base(db)
        {
        }
    }
    public interface IUserBookRepository : IRepository<UserBook> { }
}
