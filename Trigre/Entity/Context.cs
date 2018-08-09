using System;
using System.Data.Entity;
namespace Trigre.Entity
{
    public class Context : DbContext
    {
        public Context(): base("name=ConexaoUsuarios")
        { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<Context>(new CreateDatabaseIfNotExists<Context>());
        }
        public DbSet<Bot> Bot { get; set; }
        public DbSet<User> Usuarios { get; set; }
    }
}
