using System;
using System.ComponentModel.DataAnnotations;
using FrutosElqui.Core.Clientes;
using FrutosElqui.Core.Misc;

namespace FrutosElqui.Core.Cotizaciones
{
    public class Cotizacion
    {
        [Key]
        public Guid IdCotizacion { get; set; }
        public Cliente Cliente { get; set; }
        public TipoPago TipoPago { get; set; }
        public EstadoCotizacion Estado { get; set; }
        public int RutTrabajador { get; set; }
        [MaxLength(100)]
        public string NombreCotizacion { get; set; }
        public int Descuento { get; set; }
        public DateTime UltimaActualizacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int NumeroSeguimiento { get; set; }
        public int CajasEnRuta { get; set; }
        public Courrier CourrierAsignado { get; set; }
        public DateTime FechaEntregaEstimada { get; set; }
    }
}
