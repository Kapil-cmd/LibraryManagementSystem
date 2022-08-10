using Repository.Entities;
using Repository.Repos.BaseRepo;

namespace Repository.Repos.RoleRep
{
    public class RoleRepository : Repository<Role>, IRoleRepository
    {
        public RoleRepository(BookDbContext db) : base(db)
        {
        }
    }
    public interface IRoleRepository : IRepository<Role> { }
}
