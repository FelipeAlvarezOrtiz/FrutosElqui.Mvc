using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Core.Misc;
using FrutosElqui.Persistencia;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FrutosElqui.Negocio.Misc.Regiones
{
    public class ListaDeRegiones
    {
        public record Query : IRequest<List<Region>> { }

        public class Handler : IRequestHandler<Query,List<Region>>
        {
            private readonly ApplicationDbContext _context;

            public Handler(ApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<List<Region>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Regiones.ToListAsync(cancellationToken);
            }
        }
    }
}
