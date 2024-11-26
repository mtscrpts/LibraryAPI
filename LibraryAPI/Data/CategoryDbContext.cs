using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Data
{
    public class CategoryDbContext: DbContext
    {
        public CategoryDbContext(DbContextOptions<CategoryDbContext> options) : base(options) { }

        public required DbSet<Category> Category { get; set; }
    }
}
