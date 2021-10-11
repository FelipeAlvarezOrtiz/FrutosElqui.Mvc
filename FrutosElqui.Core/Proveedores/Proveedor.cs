using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FrutosElqui.Core.Misc;

namespace FrutosElqui.Core.Proveedores
{
    public class Proveedor
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public int IdProveedor { get; set; }
        [MinLength(5, ErrorMessage = "No alcanza el minimo de caracteres."), MaxLength(100, ErrorMessage = "Sobrepasa el limite de caracteres permitido")]
        public string NombreProveedor { get; set; }
        [MinLength(5, ErrorMessage = "No alcanza el minimo de caracteres."), MaxLength(100, ErrorMessage = "Sobrepasa el limite de caracteres permitido")]
        public string DireccionProveedor { get; set; }
        [MinLength(9), MaxLength(12)]
        public string RutProveedor { get; set; }
        public int? DiaFacturacion { get; set; }
        [Column(name: "IdBanco")]
        public Banco BancoProveedor { get; set; }
        [Column(name: "IdTipoCuenta")]
        public TipoCuenta TipoCuentaProveedor { get; set; }
        [Column(name: "IdTipoPago")]
        public TipoPago TipoPagoProveedor { get; set; }
        public int NumeroCuenta { get; set; }
        [Column(name: "IdGiro")]
        public Giro GiroProveedor { get; set; }

    }
}
