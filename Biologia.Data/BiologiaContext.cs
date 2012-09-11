using System.Data.Entity;

namespace Biologia.Data
{
    public class BiologiaContext : DbContext
    {
        private string _schemaName = string.Empty;
        public BiologiaContext(string connectionName, string schemaName)
            : base(connectionName)
        {
            _schemaName = schemaName;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<BiologiaContext>(new CreateDatabaseIfNotExists<BiologiaContext>());

            modelBuilder.Entity<Inscricao>().ToTable("Inscricao", _schemaName);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Inscricao> Inscricoes { get; set; }
    }
}
