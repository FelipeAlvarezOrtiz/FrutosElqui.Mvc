using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Core.Misc;
using FrutosElqui.Persistencia;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FrutosElqui.Negocio.Misc.Giros
{
    public class CrearGiro
    {
        public class Command : IRequest
        {
            public string NombreGiro { get; set; }
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
                if (await _context.Giros.Where(giro => giro.NombreGiro.Equals(request.NombreGiro))
                    .FirstOrDefaultAsync(cancellationToken) is not null)
                    throw new Exception("Ese giro ya existe.");
                await _context.Giros.AddAsync(new Giro()
                {
                    NombreGiro = request.NombreGiro
                }, cancellationToken);
                return await _context.SaveChangesAsync(cancellationToken) > 0
                    ? Unit.Value
                    : throw new Exception("Problema al guardar el giro");
            }
        }
    }
}
