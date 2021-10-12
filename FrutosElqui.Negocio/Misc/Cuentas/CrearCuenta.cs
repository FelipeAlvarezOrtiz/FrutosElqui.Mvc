using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Core.Misc;
using FrutosElqui.Persistencia;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FrutosElqui.Negocio.Misc.Cuentas
{
    public class CrearCuenta
    {
        public class Command : IRequest
        {
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
                if (await _context.Cuentas
                    .Where(cuenta => cuenta.NombreCuenta.Equals(request.NombreCuenta))
                    .FirstOrDefaultAsync() is not null) throw new Exception("Esa cuenta ya existe.");
                await _context.Cuentas.AddAsync(new Cuenta()
                {
                    NombreCuenta = request.NombreCuenta
                }, cancellationToken);
                return await _context.SaveChangesAsync(cancellationToken) > 0
                    ? Unit.Value
                    : throw new Exception("Problema al guardar la cuenta.");
            }
        }
    }
}
