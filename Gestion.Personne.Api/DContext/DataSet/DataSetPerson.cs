using Gestion.Personne.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestion.Personne.Api.DContext.DataSet
{
    public class DataSetPerson: IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasData(
                new Person
                {
                    Id = Guid.NewGuid(),
                    Nom = "Liuzzo",
                    Prenom = "Giosue"
                },
                new Person
                {
                    Id = Guid.NewGuid(),
                    Nom = "Natale",
                    Prenom = "Elisa"
                }
            );
        }
    }
}
