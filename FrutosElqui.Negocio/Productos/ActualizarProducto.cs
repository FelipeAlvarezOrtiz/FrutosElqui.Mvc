using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Negocio.Misc.Categorias;
using FrutosElqui.Negocio.Misc.Extras;
using FrutosElqui.Negocio.Proveedores;
using FrutosElqui.Persistencia;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FrutosElqui.Negocio.Productos
{
    public class ActualizarProducto
    {
        public record Command : IRequest
        {
            public int IdProducto { get; set; }
            public string NombreProducto { get; set; }
            public string DescripcionProducto { get; set; }
            public int PrecioMayorista { get; set; }
            public int PrecioTotal { get; set; }
            public int Costo { get; set; }
            public int Categoria { get; set; }

            public int Medida { get; set; }

            public int Proveedor { get; set; }
            public int Sabor { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly ApplicationDbContext _context;
            private readonly IMediator _mediator;
            public Handler(ApplicationDbContext context, IMediator mediator)
            {
                _context = context;
                _mediator = mediator;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                if (await _context.Productos.FindAsync(request.IdProducto) is null)
                    throw new Exception("El producto a actualizar no existe");
                
                var categoria = await _mediator.Send(new ObtenerCategoria.Query { IdCategoria = request.Categoria });
                var medida = await _mediator.Send(new ObtenerMedida.Query { IdMedida = request.Medida });
                var proveedor = await _mediator.Send(new ObtenerProveedorPorId.Query { IdProveedor = request.Proveedor });
                var sabor = await _mediator.Send(new ObtenerSabor.Query { IdSabor = request.Sabor });
                
                var producto = await _context.Productos.Where(producto => producto.IdProducto == request.IdProducto)
                    .Include(producto => producto.CategoriaProducto).Include(producto => producto.MedidaProducto)
                    .Include(producto => producto.SaborProducto).Include(producto => producto.ProveedorProducto).FirstOrDefaultAsync(cancellationToken);

                producto.NombreProducto = request.NombreProducto;
                producto.MedidaProducto = medida;
                producto.PrecioTotal = request.PrecioTotal;
                producto.Costo = request.Costo;
                producto.PrecioMayorista = request.PrecioMayorista;
                producto.SaborProducto = sabor;
                producto.ProveedorProducto = proveedor;
                producto.CategoriaProducto = categoria;
                producto.DescripcionProducto = request.DescripcionProducto;

                _context.Productos.Update(producto);
                return await _context.SaveChangesAsync(cancellationToken) > 0
                    ? Unit.Value
                    : throw new Exception("Ha ocurrido un error al actualizar el producto");
            }
        }
    }
}
