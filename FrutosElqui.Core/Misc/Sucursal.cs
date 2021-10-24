using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FrutosElqui.Core.Misc
{
    public class Sucursal
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdSucursal { get; set; }
        [MaxLength(100)]
        public string NombreSucursal { get; set; }
        [MaxLength(150)]
        public string Calle { get; set; }
        public Comuna Comuna { get; set; }
        public Region Region { get; set; }
        [MaxLength(20)]
        public string NumeroTelefonico { get; set; }
        [MaxLength(50)]
        public string JefeSucursal { get; set; }
        public TipoSucursal TipoSucursal { get; set; }
    }
}
