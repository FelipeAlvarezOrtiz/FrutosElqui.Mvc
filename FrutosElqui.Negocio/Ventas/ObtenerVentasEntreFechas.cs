using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Core.Ventas;
using FrutosElqui.Persistencia;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FrutosElqui.Negocio.Ventas
{
    public class ObtenerVentasEntreFechas
    {
        public record Query : IRequest<List<Venta>>
        {
            public DateTime FechaDesde { get; set; }
            public DateTime FechaHasta { get; set; }
            public int IdSucursal { get; set; }
        }

        public class Handler : IRequestHandler<Query,List<Venta>>
        {
            private readonly ApplicationDbContext _context;
            private readonly IMediator _mediator;

            public Handler(ApplicationDbContext context, IMediator mediator)
            {
                _context = context;
                _mediator = mediator;
            }

            public async Task<List<Venta>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Ventas.Include(venta => venta.Sucursal)
                    .Where(venta => venta.Sucursal.IdSucursal == request.IdSucursal)
                    .Where(venta => (DateTime.Compare(venta.FechaVenta, request.FechaHasta) <= 0
                                     && (DateTime.Compare(venta.FechaVenta, request.FechaDesde) >= 0)))
                    .Include(venta => venta.OfertasEnVenta)
                    .Include(venta => venta.DetallesVenta)
                    .ToListAsync(cancellationToken);
            }
        }
    }
}
