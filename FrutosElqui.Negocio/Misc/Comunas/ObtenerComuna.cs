using System;
using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Core.Misc;
using FrutosElqui.Persistencia;
using MediatR;

namespace FrutosElqui.Negocio.Misc.Comunas
{
    public class ObtenerComuna
    {
        public record Query : IRequest<Comuna>
        {
            public int IdComuna { get; set; }
        }

        public class Handler : IRequestHandler<Query, Comuna>
        {
            private readonly ApplicationDbContext _context;

            public Handler(ApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<Comuna> Handle(Query request, CancellationToken cancellationToken)
            {
                if (await _context.Comunas.FindAsync(request.IdComuna) is null)
                    throw new Exception("No existen datos para la comuna buscada.");
                return await _context.Comunas.FindAsync(request.IdComuna);
            }
        }
    }
}
