using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Core.Misc;
using FrutosElqui.Persistencia;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FrutosElqui.Negocio.Misc.Extras
{
    public class ListaSabores
    {
        public record Query : IRequest<List<Sabor>> { }

        public class Handler : IRequestHandler<Query, List<Sabor>>
        {
            private readonly ApplicationDbContext _context;

            public Handler(ApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<List<Sabor>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Sabores.ToListAsync(cancellationToken);
            }
        }
    }
}
