using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Core.Misc;
using FrutosElqui.Persistencia;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FrutosElqui.Negocio.Misc.IngresosDinero
{
    public class ObtenerIngresosDineroEntreFechas
    {
        public record Query : IRequest<List<IngresoDinero>>
        {
            public int IdSucursal { get; set; }
            public DateTime FechaInicio { get; set; }
            public DateTime FechaFin { get; set; }
        }

        public class Handler : IRequestHandler<Query,List<IngresoDinero>>
        {
            private readonly ApplicationDbContext _context;

            public Handler(ApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<List<IngresoDinero>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.IngresosDineros.Include(ingreso => ingreso.SucursalOrigen)
                    .Where(ingreso => ingreso.SucursalOrigen.IdSucursal == request.IdSucursal)
                    .Where(
                        ingreso => (DateTime.Compare(ingreso.FechaIngreso, request.FechaFin) <= 0
                                    && (DateTime.Compare(ingreso.FechaIngreso, request.FechaInicio) >= 0)))
                    .ToListAsync(cancellationToken);
            }
        }
    }
}
