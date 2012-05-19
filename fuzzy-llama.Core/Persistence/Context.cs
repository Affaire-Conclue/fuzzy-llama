using System.Data.Entity;
using fuzzy_llama.Core.Models;

namespace fuzzy_llama.Core.Persistence
{
    public class Context : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Context, Configuration>());
        }
    }
}
