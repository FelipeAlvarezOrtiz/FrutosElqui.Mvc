using MediatR;

namespace FrutosElqui.Negocio.Productos
{
    public class CrearProducto
    {
        public record Command : IRequest
        {
            public string NombreProducto { get; set; }
            public string DescripcionProducto { get; set; }
            public int PrecioMayorista { get; set; }
            public int PrecioTotal { get; set; }

            public int Categoria { get; set; }

            public int Medida { get; set; }

            public int Proveedor { get; set; }
        }


        
    }
}
