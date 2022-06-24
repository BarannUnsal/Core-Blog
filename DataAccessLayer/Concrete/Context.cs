using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("User ID=postgres;Password=eminem3434;Host=localhost;Port=5432;Database=CoreBlogDb;");
        }
        public DbSet<About> Abouts{ get; set; }
        public DbSet<Blog> Blogs{ get; set; }
        public DbSet<Writer> Writers{ get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; } 
    }
}
