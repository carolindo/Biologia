using System.Data.Entity;
using Core.Model;

namespace Core.Data
{
    public class Context : DbContext
    {
        public DbSet<Inscricao> Inscricoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Context, Configuracao>());
        }
    }
}
