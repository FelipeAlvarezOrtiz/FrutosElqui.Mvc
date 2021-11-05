using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Core.Misc;
using FrutosElqui.Persistencia;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FrutosElqui.Negocio.Misc.Sucursales
{
    public class ObtenerSucursal
    {
        public record Query : IRequest<Sucursal>
        {
            public int IdSucursal { get; set; }
        }

        public class Handler : IRequestHandler<Query, Sucursal>
        {
            private readonly ApplicationDbContext _context;
            private readonly IMediator _mediator;

            public Handler(IMediator mediator, ApplicationDbContext context)
            {
                _mediator = mediator;
                _context = context;
            }

            public async Task<Sucursal> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Sucursales.Where(sucursal => sucursal.IdSucursal == request.IdSucursal)
                    .Include(sucursal => sucursal.Region)
                    .Include(sucursal => sucursal.Comuna).Include(sucursal => sucursal.TipoSucursal)
                    .FirstOrDefaultAsync(cancellationToken);
            }
        }
    }
}
