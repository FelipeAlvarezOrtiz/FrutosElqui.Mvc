using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Core.Misc;
using FrutosElqui.Persistencia;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FrutosElqui.Negocio.Misc.Sectores
{
    public class ListaSectores
    {
        public class Query : IRequest<List<Sector>> { }

        public class Handler : IRequestHandler<Query, List<Sector>>
        {
            private readonly ApplicationDbContext _context;

            public Handler(ApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<List<Sector>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Sectores.ToListAsync(cancellationToken);
            }
        }
    }
}
