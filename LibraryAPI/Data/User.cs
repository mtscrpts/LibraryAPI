using Microsoft.AspNetCore.DataProtection.KeyManagement;

namespace LibraryAPI.Data
{
    public class User
    {
        public int UserId { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }
        public string? Email { get; set; }
    }
}
