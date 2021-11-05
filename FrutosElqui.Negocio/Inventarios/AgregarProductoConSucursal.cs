using System;
using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Core.Misc;
using FrutosElqui.Negocio.Misc.Sucursales;
using FrutosElqui.Negocio.Productos;
using FrutosElqui.Negocio.Proveedores;
using FrutosElqui.Persistencia;
using MediatR;

namespace FrutosElqui.Negocio.Inventarios
{
    public class AgregarProductoConSucursal
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
                var producto = await _mediator.Send(new ObtenerProducto.Query { IdProducto = request.IdProducto });
                producto.ProveedorProducto = await _mediator.Send(new ObtenerProveedorPorId.Query
                    { IdProveedor = producto.ProveedorProducto.IdProveedor });
                var sucursal = await _mediator.Send(new ObtenerSucursal.Query { IdSucursal = request.IdSucursal });
                
                await _context.Inventarios.AddAsync(new DetalleInventarios()
                {
                    Sucursal = sucursal,
                    Producto = producto,
                    CantidadDisponible = request.Cantidad
                },cancellationToken);

                return await _context.SaveChangesAsync(cancellationToken) > 0
                    ? Unit.Value
                    : throw new Exception("Ha ocurrido un problema al ingresar inventario");
            }
        }
    }
}
