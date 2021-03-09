using Gestion.Personne.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestion.Personne.Api.ModelsConfigurations
{
    public class PersonneConfiguration: IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.Property(x => x.Id)
                .HasDefaultValueSql("NEWID()");

            builder.HasKey("Id");

            builder.Property(nameof(Person.Nom))
                .IsRequired();

            builder.Property(nameof(Person.Prenom))
                .IsRequired();
        }
    }
}
