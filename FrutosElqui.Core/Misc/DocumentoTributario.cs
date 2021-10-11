using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FrutosElqui.Core.Misc
{
    public class DocumentoTributario
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public int IdDte { get; set; }
        [MinLength(5, ErrorMessage = "No alcanza el minimo de caracteres."), MaxLength(75, ErrorMessage = "Sobrepasa el limite de caracteres permitido")]
        public string NombreDte { get; set; }
    }
}
