using learningDependencyInjection.Models;
using Microsoft.EntityFrameworkCore;

namespace learningDependencyInjection.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("name=learningDb");
        }
        public DbSet<User> Users { get; set; }
    }
}
