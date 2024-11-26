using Microsoft.AspNetCore.DataProtection.KeyManagement;

namespace LibraryAPI.Data
{
    public class Book
    {
        public int BookId { get; set; }
        public int CategoryId { get; set; }
        public required string Title { get; set; }
        public string? Description { get; set; }
        public string? Author { get; set; }
        public string? Cover { get; set; }

        public Double? Price { get; set; }
    }
}
