using FrutosElqui.Negocio.Misc.Sucursales;
using FrutosElqui.Negocio.Productos;
using FrutosElqui.Negocio.Proveedores;
using FrutosElqui.Persistencia;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FrutosElqui.Negocio.Inventarios
{
    public class ReducirInventario
    {
        public record Command : IRequest
        {
            public int IdSucursal { get; set; }
            public int IdProducto { get; set; }
            public int Cantidad { get; set; }
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
                var producto = await _mediator.Send(new ObtenerProducto.Query { IdProducto = request.IdProducto }, cancellationToken);
                producto.ProveedorProducto = await _mediator.Send(new ObtenerProveedorPorId.Query
                    { IdProveedor = producto.ProveedorProducto.IdProveedor }, cancellationToken);
                var sucursal = await _mediator.Send(new ObtenerSucursal.Query { IdSucursal = request.IdSucursal }, cancellationToken);
                //obtener el detalle inventario
                var detalleInventario = await _context.Inventarios.Include(inventario => inventario.Sucursal)
                    .Include(inventario => inventario.Producto)
                    .Where(inventario => 
                        ((inventario.Sucursal.IdSucursal == request.IdSucursal) && (inventario.Producto.IdProducto == request.IdProducto)))
                    .FirstOrDefaultAsync(cancellationToken);
                if(detalleInventario.CantidadDisponible <= 0 || detalleInventario is null)
                    throw new Exception("No existe cantidad disponible para ese producto en el inventario.");
                var cantidadNueva = detalleInventario.CantidadDisponible - request.Cantidad;
                if (cantidadNueva < 0)
                    throw new Exception("No puedes vender más de lo que tienes en inventario.");
                detalleInventario.CantidadDisponible = cantidadNueva;

                _context.Inventarios.Update(detalleInventario);

                return await _context.SaveChangesAsync(cancellationToken) > 0
                    ? Unit.Value
                    : throw new Exception("Ha ocurrido un problema al ingresar inventario");
            }
        }
    }
}
