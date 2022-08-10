using Repository.Entities;
using Repository.Repos.BaseRepo;

namespace Repository.Repos.UserRep
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(BookDbContext db) : base(db)
        {
        }
    }
    public interface IUserRepository : IRepository<User> { }
}
