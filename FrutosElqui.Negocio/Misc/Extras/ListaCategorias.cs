using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Core.Misc;
using FrutosElqui.Persistencia;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FrutosElqui.Negocio.Misc.Extras
{
    public class ListaCategorias
    {
        public record Query : IRequest<List<Categoria>> { }

        public class Handler : IRequestHandler<Query, List<Categoria>>
        {
            private readonly ApplicationDbContext _context;

            public Handler(ApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<List<Categoria>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Categorias.ToListAsync(cancellationToken);
            }
        }
    }
}
