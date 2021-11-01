using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Core.Misc;
using FrutosElqui.Persistencia;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FrutosElqui.Negocio.Misc.Extras
{
    public class ObtenerSaborPorNombre
    {
        public record Query : IRequest<Sabor>
        {
            public string NombreSabor { get; set; }
        }

        public class Handler : IRequestHandler<Query, Sabor>
        {
            private readonly ApplicationDbContext _context;

            public Handler(ApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<Sabor> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Sabores.Where(sabor => sabor.NombreSabor.Equals(request.NombreSabor))
                    .FirstOrDefaultAsync(cancellationToken);
            }
        }
    }
}
