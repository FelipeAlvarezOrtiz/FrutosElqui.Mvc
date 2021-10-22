using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Core.Misc;
using FrutosElqui.Persistencia;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FrutosElqui.Negocio.Misc.Giros
{
    public class ListaGiros
    {
        public class Query : IRequest<List<Giro>> { }

        public class Handler : IRequestHandler<Query, List<Giro>>
        {
            private readonly ApplicationDbContext _context;

            public Handler(ApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<List<Giro>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Giros.ToListAsync(cancellationToken);
            }
        }
    }
}
