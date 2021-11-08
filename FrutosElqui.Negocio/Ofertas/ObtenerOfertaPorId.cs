using System;
using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Core.Ofertas;
using FrutosElqui.Persistencia;
using MediatR;

namespace FrutosElqui.Negocio.Ofertas
{
    public class ObtenerOfertaPorId
    {
        public record Query : IRequest<Oferta>
        {
            public Guid GuidOferta { get; set; }
        }

        public class Handler : IRequestHandler<Query,Oferta>
        {
            private readonly ApplicationDbContext _context;

            public Handler(ApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<Oferta> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Ofertas.FindAsync(request.GuidOferta);
            }
        }
    }
}
