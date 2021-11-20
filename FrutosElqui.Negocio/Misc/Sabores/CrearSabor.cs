using FrutosElqui.Persistencia;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FrutosElqui.Negocio.Misc.Sabores
{
    public class CrearSabor
    {
        public record Command : IRequest
        {
            public string NombreSabor { get; set; }
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
                if (await _context.Sabores.Where(x => x.NombreSabor.Equals(request.NombreSabor)).FirstOrDefaultAsync(cancellationToken) is not null)
                    throw new Exception("Ese nombre ya existe en el sistema.");
                await _context.Sabores.AddAsync(new Core.Misc.Sabor()
                {
                    NombreSabor = request.NombreSabor
                },cancellationToken);
                return await _context.SaveChangesAsync(cancellationToken) > 0 
                    ? Unit.Value 
                    : throw new Exception("Ha ocurrido un error al guardar el sabor.");
            }
        }
    }
}
