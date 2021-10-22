using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Core.Misc;
using FrutosElqui.Persistencia;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FrutosElqui.Negocio.Misc.Sectores
{
    public class CrearSector
    {
        public record Command : IRequest
        {
            public string NombreSector { get; set; }
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
                if (await _context.Sectores
                    .Where(sector => sector.NombreSector.Equals(request.NombreSector))
                    .FirstOrDefaultAsync() is not null) throw new Exception("Ese sector ya existe.");
                await _context.Sectores.AddAsync(new Sector()
                {
                    NombreSector = request.NombreSector
                }, cancellationToken);
                return await _context.SaveChangesAsync(cancellationToken) > 0
                    ? Unit.Value
                    : throw new Exception("Problema al guardar el sector.");
            }
        }
    }
}
