using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Core.Misc;
using FrutosElqui.Persistencia;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FrutosElqui.Negocio.Misc.Sucursales
{
    public class ObtenerSucursales
    {
        public record Query : IRequest<List<Sucursal>> { }

        public class Handler : IRequestHandler<Query,List<Sucursal>>
        {
            private readonly ApplicationDbContext _context;
            public Handler(ApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<List<Sucursal>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Sucursales.Include(sucursal => sucursal.Region)
                    .Include(sucursal => sucursal.Comuna).Include(sucursal => sucursal.TipoSucursal)
                    .ToListAsync(cancellationToken);
            }
        }
    }
}
