using Repository.Entities;
using Repository.Repos.BaseRepo;

namespace Repository.Repos.AuthorRep
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(BookDbContext db) : base(db)
        {
        }
    }
    public interface IAuthorRepository : IRepository<Author>
    {
    }
}
