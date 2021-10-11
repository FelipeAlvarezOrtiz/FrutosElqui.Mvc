using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FrutosElqui.Core.Misc
{
    public class TipoSucursal
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTipoSucursal { get; set; }
        [MinLength(5, ErrorMessage = "No alcanza el minimo de caracteres."), MaxLength(50, ErrorMessage = "Sobrepasa el limite de caracteres permitido")]
        public string NombreTipoSucursal { get; set; }
    }
}
