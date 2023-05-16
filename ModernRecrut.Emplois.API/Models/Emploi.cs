using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ModernRecrut.Emplois.API.Models
{
    public class Emploi
    {
        [Key]
        public int Id { get; set; }
        public string Titre { get; set; }
        public string Description { get; set; }
        public double Salaire { get; set; }
        public DateTime DateDebutAffichage { get; set; }
        public DateTime DateFinAffichage { get; set; }
    }
}
