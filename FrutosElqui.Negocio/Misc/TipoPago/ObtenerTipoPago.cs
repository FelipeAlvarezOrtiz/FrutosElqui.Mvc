using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Persistencia;
using MediatR;

namespace FrutosElqui.Negocio.Misc.TipoPago
{
    public class ObtenerTipoPago
    {
        public record Query : IRequest<Core.Misc.TipoPago>
        {
            public int IdTipoPago { get; set; }
        }

        public class Handler : IRequestHandler<Query, Core.Misc.TipoPago>
        {
            private readonly ApplicationDbContext _context;

            public Handler(ApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<Core.Misc.TipoPago> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.TipoPagos.FindAsync(request.IdTipoPago);
            }
        }
    }
}
