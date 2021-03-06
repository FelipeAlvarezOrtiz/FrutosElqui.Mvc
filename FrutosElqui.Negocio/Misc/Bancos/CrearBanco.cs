using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Core.Misc;
using FrutosElqui.Persistencia;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FrutosElqui.Negocio.Misc.Bancos
{
    public class CrearBanco
    {
        public class Command : IRequest
        {
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
                if (await _context.Bancos.Where(banco => banco.NombreBanco.Equals(request.NombreBanco))
                    .FirstOrDefaultAsync(cancellationToken) is not null)
                    throw new Exception("Ese banco ya existe.");
                await _context.Bancos.AddAsync(new Banco()
                {
                    NombreBanco = request.NombreBanco
                }, cancellationToken);
                return await _context.SaveChangesAsync(cancellationToken) > 0
                    ? Unit.Value 
                    : throw new Exception("Problema al guardar el banco");
            }
        }
    }
}