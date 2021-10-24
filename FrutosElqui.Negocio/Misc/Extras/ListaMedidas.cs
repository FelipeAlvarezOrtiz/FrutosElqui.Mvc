using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Core.Misc;
using FrutosElqui.Persistencia;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FrutosElqui.Negocio.Misc.Extras
{
    public class ListaMedidas
    {
        public record Query : IRequest<List<Medida>> { }

        public class Handler : IRequestHandler<Query, List<Medida>>
        {
            private readonly ApplicationDbContext _context;

            public Handler(ApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<List<Medida>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Medidas.ToListAsync(cancellationToken);
            }
        }
    }
}
