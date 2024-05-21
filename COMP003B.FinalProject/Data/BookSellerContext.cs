using COMP003B.FinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace COMP003B.FinalProject.Data

{
    public class BookSellerContext : DbContext
    {
        public BookSellerContext(DbContextOptions<BookSellerContext> options)
            : base(options)
        {
        }

        public DbSet<Genre> Genres { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Distributor> Distributors { get; set; }
    }
}
