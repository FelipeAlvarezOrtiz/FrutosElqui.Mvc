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
                if (await _context.Medidas
                    .Where(medida => medida.NombreMedida.Equals(request.NombreMedida))
                    .FirstOrDefaultAsync() is not null) throw new Exception("Esa medida ya existe.");
                await _context.Medidas.AddAsync(new Medida()
                {
                    NombreMedida = request.NombreMedida
                }, cancellationToken);
                return await _context.SaveChangesAsync(cancellationToken) > 0
                    ? Unit.Value
                    : throw new Exception("Problema al guardar la medida.");
            }
        }
    }
}
