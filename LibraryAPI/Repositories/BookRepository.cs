using LibraryAPI.Data;

namespace LibraryAPI.Repositories
{
    public interface IBookRepository
    {
        List<Book> GetAll();
        Book GetById(int id);
        Book Add(Book book);
        Book Update(Book book);
        void Delete(int id);
    }

    public class BookRepository : IBookRepository
    {
        private readonly LibraryApiDbContext _context;

        public BookRepository(LibraryApiDbContext context)
        {
            _context = context;
        }

        public List<Book> GetAll()
        {
            return _context.Books.ToList();
        }

        public Book GetById(int id)
        {
            return _context.Books.FirstOrDefault(x => x.BookId == id);
        }

        public Book Add(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
            return book;
        }

        public Book Update(Book book)
        {
            _context.Books.Update(book);
            _context.SaveChanges(true);
            return book;
        }

        public void Delete(int id)
        {
            var book = _context.Books.FirstOrDefault(x => x.BookId == id);
            _context.Books.Remove(book);
            _context.SaveChanges();
        }
    }
}
