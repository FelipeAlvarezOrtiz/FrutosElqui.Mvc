using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FrutosElqui.Core.Misc;
using FrutosElqui.Core.Proveedores;

namespace FrutosElqui.Core.Productos
{
    public class Producto
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProducto { get; set; }
        [MinLength(5, ErrorMessage = "No alcanza el minimo de caracteres."), MaxLength(75, ErrorMessage = "Sobrepasa el limite de caracteres permitido")]
        public string NombreProducto { get; set; }
        [MinLength(5, ErrorMessage = "No alcanza el minimo de caracteres."), MaxLength(100, ErrorMessage = "Sobrepasa el limite de caracteres permitido")]
        public string DescripcionProducto { get; set; }
        public int? PrecioMayorista { get; set; }
        [Required(ErrorMessage = "El precio debe ser ingresado.")]
        public int PrecioTotal { get; set; }
        [Required]
        public int Costo { get; set; }
        [Required] 
        public DateTime FechaCreacionProducto { get; set; } = DateTime.Now;

        [Required, MinLength(10), MaxLength(150)]
        public string NombreBusqueda { get; set; }
        public Sabor SaborProducto { get; set; }
        [Required]
        public Categoria CategoriaProducto { get; set; }
        public Medida MedidaProducto { get; set; }
        [Required(ErrorMessage = "El proveedor es requerido para cada producto.")]
        public Proveedor ProveedorProducto { get; set; }
    }
}
