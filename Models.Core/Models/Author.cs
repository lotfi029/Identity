namespace Models.Core.Models
{
    public class Author
    {
        public required string AuthorId { get; set; }
        public required string Name { get; set;}
        public DateOnly BD { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
