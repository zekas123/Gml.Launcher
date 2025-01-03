using Microsoft.EntityFrameworkCore;
using Gml.Launcher.Models; // Пространство имен модели UserModel

namespace Gml.Launcher.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<UserModel> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=GmlLauncher.db");
            }
        }
    }
}
