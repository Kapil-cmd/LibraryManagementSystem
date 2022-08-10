using Repository.Entities;
using Repository.Repos.BaseRepo;

namespace Repository.Repos.CategoryRep
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(BookDbContext db) : base(db)
        {
        }
    }
    public interface ICategoryRepository : IRepository<Category>
    {
    }
}
