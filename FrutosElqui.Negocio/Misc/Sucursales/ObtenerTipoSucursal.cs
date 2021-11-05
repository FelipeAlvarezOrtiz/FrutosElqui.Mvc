using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Core.Misc;
using FrutosElqui.Persistencia;
using MediatR;

namespace FrutosElqui.Negocio.Misc.Sucursales
{
    public class ObtenerTipoSucursal
    {
        public record Query : IRequest<TipoSucursal>
        {
            public int IdTipoSucursal { get; set; }
        }

        public class Handler : IRequestHandler<Query, TipoSucursal>
        {
            private readonly ApplicationDbContext _context;

            public Handler(ApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<TipoSucursal> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.TipoSucursales.FindAsync(request.IdTipoSucursal);
            }
        }
    }
}
