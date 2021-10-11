using System;
using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Core.Misc;
using FrutosElqui.Persistencia;
using MediatR;

namespace FrutosElqui.Negocio.Misc.Bancos
{
    public class ObtenerBanco
    {
        public class Query : IRequest<Banco>
        {
            public int IdBanco { get; set; }
        }

        public class Handler : IRequestHandler<Query, Banco>
        {
            private readonly ApplicationDbContext _context;

            public Handler(ApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<Banco> Handle(Query request, CancellationToken cancellationToken)
            {
                if(await _context.Bancos.FindAsync(request.IdBanco) is null) 
                    throw new Exception("No existen datos para el banco buscado.");
                return await _context.Bancos.FindAsync(request.IdBanco);
            }
        }
    }
}