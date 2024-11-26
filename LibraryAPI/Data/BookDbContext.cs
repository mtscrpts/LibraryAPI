using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Data
{
    public class BookDbContext: DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options) { }
        public required DbSet<Book> Books { get; set; }
    }
}
