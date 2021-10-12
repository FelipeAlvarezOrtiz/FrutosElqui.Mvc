using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Core.Misc;
using FrutosElqui.Persistencia;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FrutosElqui.Negocio.Misc.Comunas
{
    public class ListaDeComunas
    {
        public class Query : IRequest<List<Comuna>> { }

        public class Handler : IRequestHandler<Query, List<Comuna>>
        {
            private readonly ApplicationDbContext _context;

            public Handler(ApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<List<Comuna>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Comunas.ToListAsync(cancellationToken);
            }
        }
    }
}
