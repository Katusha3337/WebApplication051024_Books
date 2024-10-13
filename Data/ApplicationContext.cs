using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApplication051024_Books.Models;

namespace WebApplication051024_Books.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
