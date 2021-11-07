using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Core.Misc;
using FrutosElqui.Persistencia;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FrutosElqui.Negocio.Misc.EgresosDinero
{
    public class ObtenerEgresosDineroEntreFechas
    {
        public record Query : IRequest<List<EgresoDinero>>
        {
            public int IdSucursal { get; set; }
            public DateTime FechaInicio { get; set; }
            public DateTime FechaFin { get; set; }
        }

        public class Handler : IRequestHandler<Query,List<EgresoDinero>>
        {
            private readonly ApplicationDbContext _context;

            public Handler(ApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<List<EgresoDinero>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.EgresosDineros.Include(egreso => egreso.SucursalOrigen)
                    .Where(egreso => egreso.SucursalOrigen.IdSucursal == request.IdSucursal)
                    .Where(
                        egreso => (DateTime.Compare(egreso.FechaEgreso, request.FechaFin) <= 0
                                   && (DateTime.Compare(egreso.FechaEgreso, request.FechaInicio) >= 0)))
                    .ToListAsync(cancellationToken);
            }
        }
    }
}
