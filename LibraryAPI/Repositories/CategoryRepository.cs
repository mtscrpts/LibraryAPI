using LibraryAPI.Data;

namespace LibraryAPI.Repositories
{
    public interface ICategoryRepository
    {
        List<Category> GetAll();
        Category GetById(int id);
        Category Add(Category category);
        Category Update(Category category);
        void Delete(int id);
    }

    public class CategoryRepository : ICategoryRepository
    {
        private readonly LibraryApiDbContext _context;

        public CategoryRepository(LibraryApiDbContext context)
        {
            _context = context;
        }

        public List<Category> GetAll()
        {
            return _context.Categories.ToList();
        }

        public Category GetById(int id)
        {
            return _context.Categories.FirstOrDefault(x => x.CategoryId == id);
        }

        public Category Add(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return category;
        }

        public Category Update(Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges(true);
            return category;
        }

        public void Delete(int id)
        {
            var category = _context.Categories.FirstOrDefault(x => x.CategoryId == id);
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }
    }
}
