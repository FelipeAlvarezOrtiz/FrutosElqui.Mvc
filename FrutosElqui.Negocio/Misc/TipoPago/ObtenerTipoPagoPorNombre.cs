using FrutosElqui.Persistencia;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FrutosElqui.Negocio.Misc.TipoPago
{
    public class ObtenerTipoPagoPorNombre
    {
        public record Query : IRequest<Core.Misc.TipoPago>
        {
            public string NombreTipoPago { get; set; }
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
                return await _context.TipoPagos.Where(tipoPago => 
                        tipoPago.NombreTipoPago.Equals(request.NombreTipoPago))
                        .FirstOrDefaultAsync(cancellationToken);
            }
        }
    }
}
