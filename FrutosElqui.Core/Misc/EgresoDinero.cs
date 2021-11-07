using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FrutosElqui.Core.Misc
{
    public class EgresoDinero
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEgreso { get; set; }
        public DateTime FechaEgreso { get; set; }
        public int CantidadEgresada { get; set; }
        [MaxLength(250)]
        public string Observacion { get; set; }
        public Sucursal SucursalOrigen { get; set; }
    }
}
