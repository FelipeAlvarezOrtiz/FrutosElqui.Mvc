using System;
using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Persistencia;
using MediatR;

namespace FrutosElqui.Negocio.Misc.Cuentas
{
    public class ActualizarCuenta
    {
        public class Command : IRequest
        {
            public int IdCuenta { get; set; }
            public string NombreCuenta { get; set; }
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
                var cuentaExistente = await _context.Cuentas.FindAsync(request.IdCuenta);
                if (cuentaExistente is null) throw new Exception($"La cuenta {request.NombreCuenta} a actualizar no existe.");
                cuentaExistente.NombreCuenta = request.NombreCuenta;
                _context.Cuentas.Update(cuentaExistente);
                return await _context.SaveChangesAsync(cancellationToken) > 0
                    ? Unit.Value
                    : throw new Exception("Problema al actualizar la cuenta.");
            }
        }
    }
}
