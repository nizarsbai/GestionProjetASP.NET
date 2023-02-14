using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GestionProjet.Services.ProjectAPI.Models
{
        [Table("Employes")]
        public class Employe
        {
            [Key]
            public int employeId { get; set; }
            [Required, StringLength(25)]
            public string firstname { get; set; }
            [Required, StringLength(25)]
            public string lastname { get; set; }
            [Required, StringLength(25)]
            public string gender { get; set; }
            [Required, StringLength(255)]
            public string description { get; set; }
            [Required]
            public double salaire { get; set; }
            [Required, StringLength(255)]
            public string iamageURL { get; set; }




        }
    }

