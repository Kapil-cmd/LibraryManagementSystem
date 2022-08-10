using Repository.Entities;
using Repository.Repos.BaseRepo;

namespace Repository.Repos.UserRoleRep
{
    public class UserRoleRepository : Repository<UserRole>, IUserRoleRepository
    {
        public UserRoleRepository(BookDbContext db) : base(db)
        {
        }
    }
    public interface IUserRoleRepository : IRepository<UserRole> { }
}
