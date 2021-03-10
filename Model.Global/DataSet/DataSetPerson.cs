using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Global.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Global.DataSet
{
    public class DataSetPerson : IEntityTypeConfiguration<Person>
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
