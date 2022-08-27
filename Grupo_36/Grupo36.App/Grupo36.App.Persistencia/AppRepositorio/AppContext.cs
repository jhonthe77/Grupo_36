using Microsoft.EntityFrameworkCore;
using Grupo36.App.Dominio;

namespace Grupo36.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = DataGrupo36");

            }
        }
    }
}