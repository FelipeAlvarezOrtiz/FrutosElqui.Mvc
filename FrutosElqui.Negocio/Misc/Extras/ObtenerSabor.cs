using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Core.Misc;
using FrutosElqui.Persistencia;
using MediatR;

namespace FrutosElqui.Negocio.Misc.Extras
{
    public class ObtenerSabor
    {
        public record Query : IRequest<Sabor>
        {
            public int IdSabor { get; set; }
        }
        public class Handler : IRequestHandler<Query,Sabor>
        {
            private readonly ApplicationDbContext _context;

            public Handler(ApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<Sabor> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Sabores.FindAsync(request.IdSabor);
            }
        }
    }
}
