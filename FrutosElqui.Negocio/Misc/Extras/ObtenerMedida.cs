using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Core.Misc;
using FrutosElqui.Persistencia;
using MediatR;

namespace FrutosElqui.Negocio.Misc.Extras
{
    public class ObtenerMedida
    {
        public record Query : IRequest<Medida>
        {
            public int IdMedida { get; set; }
        }

        public class Handler : IRequestHandler<Query,Medida>
        {
            private readonly ApplicationDbContext _context;

            public Handler(ApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<Medida> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Medidas.FindAsync(request.IdMedida);
            }

        }
    }
}
