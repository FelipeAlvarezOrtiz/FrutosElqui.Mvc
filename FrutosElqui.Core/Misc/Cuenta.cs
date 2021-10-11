using System;
using System.ComponentModel.DataAnnotations;

namespace FrutosElqui.Core.Misc
{
    public class Cuenta
    {
        [Key]
        public Guid IdCuenta { get; set; }
        [MinLength(10), MaxLength(100)]
        public string NombreCuenta { get; set; }
        [MaxLength(200)]
        public string DescripcionCuenta { get; set; }
        [MaxLength(100)]
        public string CicloFacturacion { get; set; }
        [Range(1, 31, ErrorMessage = "El día debe estar entre los rangos válidos.")]
        public int DiaFacturacion { get; set; }
        [Required]
        public uint MontoDeclarado { get; set; }
    }
}
