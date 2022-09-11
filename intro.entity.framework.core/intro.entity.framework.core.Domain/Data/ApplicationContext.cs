using Microsoft.EntityFrameworkCore;

namespace Intro.Entity.Framework.Core.Domain.Data
{
    public class ApplicationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Data Source=RODRIGO-G15\SQLEXPRESS");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly);
        }
    }
}
