using FrutosElqui.Core.Ventas;
using FrutosElqui.Persistencia;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FrutosElqui.Negocio.Ventas
{
    public class ObtenerVentasDelProveedor
    {
        public record Query : IRequest<List<Venta>>
        {
            public int IdProveedor { get; set; }
            public int IdSucursal { get; set; }
            public DateTime FechaDesde { get; set; }
            public DateTime FechaHasta { get; set; }
        }

        public class Handler : IRequestHandler<Query, List<Venta>>
        {
            private readonly ApplicationDbContext _context;

            public Handler(ApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<List<Venta>> Handle(Query request, CancellationToken cancellationToken)
            {
                var listaVentas = await _context.Ventas.Include(venta => venta.Sucursal)
                    .Where(venta => venta.Sucursal.IdSucursal == request.IdSucursal)
                    .Where(venta => (DateTime.Compare(venta.FechaVenta, request.FechaHasta) <= 0
                                     && (DateTime.Compare(venta.FechaVenta, request.FechaDesde) >= 0)))
                    .Include(venta => venta.OfertasEnVenta)
                    .Include(venta => venta.DetallesVenta)
                    .ToListAsync(cancellationToken);
                var ventaProveedores = new List<Venta>();
                foreach(var venta in listaVentas)
                {
                    foreach (var detalle in venta.DetallesVenta)
                    {
                        if (detalle.IdProveedor != request.IdProveedor) continue;
                        if (ventaProveedores.Contains(venta)) continue;
                        ventaProveedores.Add(venta);
                    }
                }
                return ventaProveedores;
            }
        }
    }
}
