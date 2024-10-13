namespace WebApplication051024_Books.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
