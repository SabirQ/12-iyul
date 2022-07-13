using Microsoft.EntityFrameworkCore;
using Task.Models;

namespace Task.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option):base(option)
        {

        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
