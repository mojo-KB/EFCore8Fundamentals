using Microsoft.EntityFrameworkCore;
using PublisherDomain;

namespace PublisherData : DbContext
{
    public class PubContext:
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = PubIntroDatabase");
        }
    }
}
