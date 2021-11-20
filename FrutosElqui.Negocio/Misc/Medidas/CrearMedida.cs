using FrutosElqui.Persistencia;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FrutosElqui.Negocio.Misc.Medidas
{
    public class CrearMedida
    {
        public record Command : IRequest
        {
            public string NombreMedida { get; set; }
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
                if (await _context.Medidas.Where(x => x.NombreMedida.Equals(request.NombreMedida)).FirstOrDefaultAsync(cancellationToken) is not null)
                    throw new Exception("Ese nombre ya existe en el sistema.");
                await _context.Medidas.AddAsync(new Core.Misc.Medida()
                {
                    NombreMedida = request.NombreMedida
                }, cancellationToken);
                return await _context.SaveChangesAsync(cancellationToken) > 0
                    ? Unit.Value
                    : throw new Exception("Ha ocurrido un error al guardar la medida.");
            }
        }
    }
}
