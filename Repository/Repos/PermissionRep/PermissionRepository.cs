using Repository.Entities;
using Repository.Repos.BaseRepo;

namespace Repository.Repos.PermissionRep
{
    public class PermissionRepository : Repository<Permission>, IPermissionRepository
    {
        public PermissionRepository(BookDbContext db) : base(db)
        {
        }
    }
    public interface IPermissionRepository : IRepository<Permission>
    {
    }
}
