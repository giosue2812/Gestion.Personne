using Microsoft.EntityFrameworkCore;
using Model.Global.DataSet;
using Model.Global.Models;
using Model.Global.ModelsConfigurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Global
{
    public class DataContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source=DBGestionPersonne");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PersonConfiguration());
            modelBuilder.ApplyConfiguration(new DataSetPerson());
        }
        public DbSet<Person> ListPersons { get; set; }
    }
}
