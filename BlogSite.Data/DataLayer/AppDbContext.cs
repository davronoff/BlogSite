using BlogSite.Domain;
using Microsoft.EntityFrameworkCore;

namespace BlogSite.Data.DataLayer
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
             : base(options)
        {

        }
        public DbSet<Post> posts { get; set; }
        public DbSet<Comment> comments { get; set; } 
    }
}
