using Repository.Entities;
using Repository.Repos.BaseRepo;

namespace Repository.Repos.RolePermissionRep
{
    public class RolePermissionRepository : Repository<RolePermission>, IRolePermissionRepository
    {
        public RolePermissionRepository(BookDbContext db) : base(db)
        {
        }
    }
    public interface IRolePermissionRepository : IRepository<RolePermission> { }
}
