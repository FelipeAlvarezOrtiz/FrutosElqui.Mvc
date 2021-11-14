using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FrutosElqui.Core.Misc;

namespace FrutosElqui.Core.Ventas
{
    public class Venta
    {
        [Key]
        public Guid IdVenta { get; set; }
        public Sucursal Sucursal { get; set; }
        public string NombreUsuarioVenta { get; set; }
        public string RutUsuarioVenta { get; set; }
        public DateTime FechaVenta { get; set; }
        public TipoPago TipoPago { get; set; }
        public int Total { get; set; }
        public int Descuento { get; set; }
        public List<DetalleVenta> DetallesVenta { get; set; }
        public List<OfertasEnVenta> OfertasEnVenta { get; set; }
    }

    public class DetalleVenta
    {
        [Key]
        public Guid IdDetalle { get; set; }
        [MaxLength(150)] public string NombreProducto { get; set; }
        public int IdProducto { get; set; }
        public int IdProveedor { get; set; }
        [MaxLength(150)] public string NombreProveedor { get; set; }
        public int CantidadProducto { get; set; }
        public int TotalProducto { get; set; }
    }

    public class OfertasEnVenta
    {
        [Key]
        public Guid IdOfertasVenta { get; set; }
        public Guid GuidOferta { get; set; }
        [MaxLength(150)] public string NombreOferta { get; set; }
        public int CantidadOferta { get; set; }
    }

}
