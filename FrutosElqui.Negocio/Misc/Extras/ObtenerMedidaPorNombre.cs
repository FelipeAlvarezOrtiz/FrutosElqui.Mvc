using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Core.Misc;
using FrutosElqui.Persistencia;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FrutosElqui.Negocio.Misc.Extras
{
    public class ObtenerMedidaPorNombre
    {
        public record Query : IRequest<Medida>
        {
            public string NombreMedida { get; set; }
        }

        public class Handler : IRequestHandler<Query, Medida>
        {
            private readonly ApplicationDbContext _context;

            public Handler(ApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<Medida> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Medidas.Where(medida => medida.NombreMedida.Equals(request.NombreMedida))
                    .FirstOrDefaultAsync(cancellationToken);
            }
        }
    }
}
