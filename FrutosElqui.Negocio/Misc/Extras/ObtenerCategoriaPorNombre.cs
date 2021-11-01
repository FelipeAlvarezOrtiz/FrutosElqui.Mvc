using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Core.Misc;
using FrutosElqui.Persistencia;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FrutosElqui.Negocio.Misc.Extras
{
    public class ObtenerCategoriaPorNombre
    {
        public record Query : IRequest<Categoria>
        {
            public string NombreCategoria { get; set; }
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
                return await _context.Categorias.Where(categoria => categoria.NombreCategoria.Equals(request.NombreCategoria))
                    .FirstOrDefaultAsync(cancellationToken);
            }
        }
    }
}
