using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FrutosElqui.Core.Misc
{
    public class Giro
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public int IdGiro { get; set; }
        [MinLength(5, ErrorMessage = "No alcanza el minimo de caracteres."), MaxLength(100, ErrorMessage = "Sobrepasa el limite de caracteres permitido")]
        public string NombreGiro { get; set; }
        [Required]
        public uint IdGiroSii { get; set; }
    }
}
