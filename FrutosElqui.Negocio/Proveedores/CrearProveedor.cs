using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Persistencia;
using MediatR;

namespace FrutosElqui.Negocio.Proveedores
{
    public class CrearProveedor
    {
        public record Command : IRequest
        {
            
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly ApplicationDbContext _context;

            public Handler(ApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                return Unit.Value;
            }
        }

    }
}
