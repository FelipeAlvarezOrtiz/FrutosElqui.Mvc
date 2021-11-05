using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Core.Misc;
using FrutosElqui.Negocio.Misc.Sucursales;
using FrutosElqui.Persistencia;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FrutosElqui.Negocio.Inventarios
{
    public class ObtenerInventariosDeSucursal
    {
        public record Query : IRequest<List<DetalleInventarios>>
        {
            public int IdSucursal { get; set; }
        }

        public class Handler : IRequestHandler<Query,List<DetalleInventarios>>
        {
            private readonly ApplicationDbContext _context;
            private readonly IMediator _mediator;

            public Handler(ApplicationDbContext context, IMediator mediator)
            {
                _context = context;
                _mediator = mediator;
            }

            public async Task<List<DetalleInventarios>> Handle(Query request, CancellationToken cancellationToken)
            {
                var sucursal = await _mediator.Send(new ObtenerSucursal.Query { IdSucursal = request.IdSucursal });
                if (sucursal is null) throw new Exception("Esa sucursal no existe");
                return await _context.Inventarios.Include(inv => inv.Sucursal)
                    .Where(inv => inv.Sucursal.IdSucursal == request.IdSucursal).Include(inv => inv.Producto)
                    .ThenInclude(producto => producto.ProveedorProducto).ToListAsync(cancellationToken);
            }
        }
    }
}
