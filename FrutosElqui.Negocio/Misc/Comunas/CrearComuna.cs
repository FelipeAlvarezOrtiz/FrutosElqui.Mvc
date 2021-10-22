using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Core.Misc;
using FrutosElqui.Persistencia;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FrutosElqui.Negocio.Misc.Comunas
{
    public class CrearComuna
    {
        public record Command : IRequest
        {
            public string NombreComuna { get; set; }
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
                if (await _context.Comunas
                    .Where(comuna => comuna.NombreComuna.Equals(request.NombreComuna))
                    .FirstOrDefaultAsync() is not null) throw new Exception("Esa comuna ya existe.");
                await _context.Comunas.AddAsync(new Comuna()
                {
                    NombreComuna = request.NombreComuna
                }, cancellationToken);
                return await _context.SaveChangesAsync(cancellationToken) > 0
                    ? Unit.Value
                    : throw new Exception("Problema al guardar la comuna.");
            }
        }
    }
}
