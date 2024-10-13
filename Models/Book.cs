using System.Xml.Linq;

namespace WebApplication051024_Books.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
