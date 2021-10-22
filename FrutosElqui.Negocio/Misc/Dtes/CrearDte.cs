using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Core.Misc;
using FrutosElqui.Persistencia;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FrutosElqui.Negocio.Misc.Dtes
{
    public class CrearDte
    {
        public record Command : IRequest
        {
            public string NombreDte { get; set; }
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
                if (await _context.DocumentosTributarios.Where(dte => dte.NombreDte.Equals(request.NombreDte))
                    .FirstOrDefaultAsync(cancellationToken) is not null)
                    throw new Exception("Ese dte ya existe.");
                await _context.DocumentosTributarios.AddAsync(new DocumentoTributario()
                {
                    NombreDte = request.NombreDte
                }, cancellationToken);
                return await _context.SaveChangesAsync(cancellationToken) > 0
                    ? Unit.Value
                    : throw new Exception("Problema al guardar el dte");
            }
        }
    }
}
