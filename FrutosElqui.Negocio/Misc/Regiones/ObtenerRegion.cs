using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Core.Misc;
using FrutosElqui.Persistencia;
using MediatR;

namespace FrutosElqui.Negocio.Misc.Regiones
{
    public class ObtenerRegion
    {
        public record Query : IRequest<Region>
        {
            public int IdRegion { get; set; }
        }

        public class Handler : IRequestHandler<Query, Region>
        {
            private readonly ApplicationDbContext _context;

            public Handler(ApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<Region> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Regiones.FindAsync(request.IdRegion);
            }
        }
    }
}
