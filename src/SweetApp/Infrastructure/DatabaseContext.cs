using Microsoft.EntityFrameworkCore;
using SweetApp.Domain.Models;

namespace SweetApp.Infrastructure
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Data Source=localhost,1401;Initial Catalog=SweetApp;Integrated Security=False;User Id=sa;Password=2dd73426-d37a-4fd2-89e9-92f2a8f1a526;Pooling=False");
    }
}
