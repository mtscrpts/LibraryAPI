using LibraryAPI.Data;

namespace LibraryAPI.Repositories
{
    public interface IUserRepository
    {
        User ValidateUser(string username, string password);
        void Dispose();
        User GetById(int id);
    }
    public class UserRepository: IDisposable, IUserRepository
    {
        private readonly LibraryApiDbContext _context;

        public UserRepository(LibraryApiDbContext context)
        {
            _context = context;
        }

        public User ValidateUser(string name, string password)
        {
            return _context.Users.FirstOrDefault(user =>
            user.Name == name && user.Password == password);
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public User GetById(int id)
        {
            return _context.Users.FirstOrDefault(x => x.UserId == id);
        }
    }
}
