using System;
using System.ComponentModel.DataAnnotations;
using FrutosElqui.Core.Misc;
using FrutosElqui.Core.Productos;

namespace FrutosElqui.Core.Cotizaciones
{
    public class DetalleCotizacion
    {
        [Key]
        public Guid IdDetalleCotizacion { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public Sucursal SucursalOrigen { get; set; }
    }
}
