using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FrutosElqui.Core.Productos;

namespace FrutosElqui.Core.Ofertas
{
    public class Oferta
    {
        [Key]
        public Guid GuidOferta { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdOferta { get; set; }
        public DateTime FechaCreacion { get; set; }
        public List<DetalleOferta> ProductosEnOferta { get; set; }
        public int PrecioOferta { get; set; }
        [MaxLength(200)]
        public string NombreOferta { get; set; }
    }

    public class DetalleOferta
    {
        [Key]
        public Guid GuidDetalle { get; set; }
        public Producto Producto { get; set; }
        public int CantidadProducto { get; set; }
    }
}
