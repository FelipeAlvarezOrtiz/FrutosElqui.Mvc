using System;
using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Persistencia;
using MediatR;

namespace FrutosElqui.Negocio.Misc.Comunas
{
    public class ActualizarComuna
    {
        public class Command : IRequest
        {
            public int IdComuna { get; set; }
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
                var comunaExistente = await _context.Comunas.FindAsync(request.IdComuna);
                if (comunaExistente is null) throw new Exception("La comuna a actualizar no existe.");
                comunaExistente.NombreComuna = request.NombreComuna;
                _context.Comunas.Update(comunaExistente);
                return await _context.SaveChangesAsync(cancellationToken) > 0
                    ? Unit.Value
                    : throw new Exception("Problema al actualizar la comuna.");
            }
        }
    }
}
