using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FrutosElqui.Core.Misc
{
    public class TipoCuenta
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTipoCuenta { get; set; }
        [MinLength(3, ErrorMessage = "No alcanza el minimo de caracteres exigido."), MaxLength(50, ErrorMessage = "Máximo de carácteres sobrepasado.")]
        public string NombreTipoCuenta { get; set; }
    }
}
