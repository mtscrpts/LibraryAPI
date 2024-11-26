using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Data
{
    public class LibraryApiDbContext: DbContext
    {
        public LibraryApiDbContext(DbContextOptions<LibraryApiDbContext> options) : base(options) { }
        public required DbSet<Category> Categories { get; set; }

        public required DbSet<Book> Books { get; set; }
    }
}
