using Gestion.Personne.Api.DContext.DataSet;
using Gestion.Personne.Api.Models;
using Gestion.Personne.Api.ModelsConfigurations;
using Microsoft.EntityFrameworkCore;

namespace Gestion.Personne.Api.DContext
{
    public class DataContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source=DBGestionPersonne");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PersonneConfiguration());
            modelBuilder.ApplyConfiguration(new DataSetPerson());
        }

        public DbSet<Person> ListPersonnes { get; set; }
    }
}
