using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Core.Misc;
using FrutosElqui.Persistencia;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FrutosElqui.Negocio.Misc.Dtes
{
    public class ListaDtes
    {
        public class Query : IRequest<List<DocumentoTributario>> { }

        public class Handler : IRequestHandler<Query, List<DocumentoTributario>>
        {
            private readonly ApplicationDbContext _context;

            public Handler(ApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<List<DocumentoTributario>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.DocumentosTributarios.ToListAsync(cancellationToken);
            }
        }
    }
}
