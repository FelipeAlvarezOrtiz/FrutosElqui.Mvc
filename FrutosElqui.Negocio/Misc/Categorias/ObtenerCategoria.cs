using System;
using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Core.Misc;
using FrutosElqui.Persistencia;
using MediatR;

namespace FrutosElqui.Negocio.Misc.Categorias
{
    public class ObtenerCategoria
    {
        public class Query : IRequest<Categoria>
        {
            public int IdCategoria { get; set; }
        }

        public class Handler : IRequestHandler<Query, Categoria>
        {
            private readonly ApplicationDbContext _context;

            public Handler(ApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<Categoria> Handle(Query request, CancellationToken cancellationToken)
            {
                if(await _context.Categorias.FindAsync(request.IdCategoria) is null) 
                    throw new Exception("No existen datos para el banco buscado.");
                return await _context.Categorias.FindAsync(request.IdCategoria);
            }
        }
    }
}