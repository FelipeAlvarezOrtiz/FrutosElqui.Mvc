using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FrutosElqui.Core.Productos;

namespace FrutosElqui.Core.Misc
{
    public class DetalleInventarios
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdDetalleInventario { get; set; }
        public Sucursal Sucursal { get; set; }
        public Producto Producto { get; set; }
        public int CantidadDisponible { get; set; }
    }
}
