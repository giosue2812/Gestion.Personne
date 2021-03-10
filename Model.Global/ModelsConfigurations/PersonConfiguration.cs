using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Global.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Global.ModelsConfigurations
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
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
