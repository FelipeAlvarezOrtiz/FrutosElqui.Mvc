using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FrutosElqui.Core.Misc
{
    public class IngresoDinero
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdIngreso { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int CantidadIngresado { get; set; }
        [MaxLength(250)]
        public string Observacion { get; set; }
        public Sucursal SucursalOrigen { get; set; }
    }
}
