
using EngineerApi.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace EngineerApi.Core
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
            : base(options)
        {
        }
        public DbSet<Engineer> Engineer { get; set; }
    }
}
