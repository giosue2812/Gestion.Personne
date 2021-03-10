using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Client.Models
{
    public class Person
    {
        public Guid Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public Person(Guid id, string nom,string prenom)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
        }
    }
}
