using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FrutosElqui.Core.Cotizaciones
{
    public class EstadoCotizacion
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEstadoCotizacion { get; set; }
        [MaxLength(100)]
        public string NombreEstadoCotizacion { get; set; }
    }
}
