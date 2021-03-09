using System.ComponentModel.DataAnnotations;

namespace Gestion.Personne.Api.Models.Form
{
    public class PersonForm
    {
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Prenom { get; set; }
    }
}
