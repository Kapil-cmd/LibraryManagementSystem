using Microsoft.AspNetCore.Http;
using Repository.Repos;
using Repository.Repos.AuthorRep;
using Repository.Repos.BookRep;
using Repository.Repos.CategoryRep;
using Repository.Repos.PermissionRep;
using Repository.Repos.RolePermissionRep;
using Repository.Repos.UserRoleRep;

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
        public IAuthorRepository AuthorRepository { get; private set; }
        public ICategoryRepository CategoryRepository { get; private set; }
        public IPermissionRepository PermissionRepository { get; private set; }

        public IRolePermissionRepository RolePermissionrepository { get; private set; }

        public IUserRoleRepository UserRoleRepository { get; private set; }

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
        IAuthorRepository AuthorRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        IPermissionRepository PermissionRepository { get; }
        IRolePermissionRepository RolePermissionrepository { get; }
        IUserRoleRepository UserRoleRepository { get; }
        void Save();
    }
}
