using System;
using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Core.Misc;
using FrutosElqui.Persistencia;
using MediatR;

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
                await _context.Bancos.AddAsync(new Banco()
                {
                    NombreBanco = request.NombreBanco
                });
                return await _context.SaveChangesAsync() > 0
                    ? Unit.Value 
                    : throw new Exception("Problema al guardar el banco");
            }
        }
    }
}