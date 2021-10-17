using System;
using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Persistencia;
using MediatR;

namespace FrutosElqui.Negocio.Misc.Bancos
{
    public class ActualizarBanco
    {
        public record Command : IRequest
        {
            public int IdBanco { get; set; }
            public string NombreBanco { get; set; }
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
                var bancoExistente = await _context.Bancos.FindAsync(request.IdBanco);
                if (bancoExistente is null) throw new Exception("El banco a actualizar no existe.");
                bancoExistente.NombreBanco = request.NombreBanco;
                _context.Bancos.Update(bancoExistente);
                return await _context.SaveChangesAsync() > 0
                    ? Unit.Value 
                    : throw new Exception("Problema al guardar el banco");
            }
        }
    }
}