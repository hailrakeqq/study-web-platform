using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using study_web_platform.Entities;

namespace study_web_platform
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }
    }
}