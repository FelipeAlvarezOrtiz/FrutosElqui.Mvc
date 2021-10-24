using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Core.Misc;
using FrutosElqui.Persistencia;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FrutosElqui.Negocio.Misc.Extras
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
                if (await _context.Sabores
                    .Where(sabor => sabor.NombreSabor.Equals(request.NombreSabor))
                    .FirstOrDefaultAsync() is not null) throw new Exception("Ese sector ya existe.");
                await _context.Sabores.AddAsync(new Sabor()
                {
                    NombreSabor = request.NombreSabor
                }, cancellationToken);
                return await _context.SaveChangesAsync(cancellationToken) > 0
                    ? Unit.Value
                    : throw new Exception("Problema al guardar el sabor.");
            }
        }
    }
}
