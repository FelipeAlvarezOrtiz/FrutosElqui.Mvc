using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Core.Misc;
using FrutosElqui.Persistencia;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FrutosElqui.Negocio.Misc.Bancos
{
    public class ListaDeBancos
    {
        public class Query : IRequest<List<Banco>>{}

        public class Handler : IRequestHandler<Query, List<Banco>>
        {
            private readonly ApplicationDbContext _context;

            public Handler(ApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<List<Banco>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Bancos.ToListAsync(cancellationToken);
            }
        }
    }
}