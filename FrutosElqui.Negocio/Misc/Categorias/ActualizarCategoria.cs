using System;
using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Persistencia;
using MediatR;

namespace FrutosElqui.Negocio.Misc.Categorias
{
    public class ActualizarCategoria
    {
        public class Command : IRequest
        {
            public int IdCategoria { get; set; }
            public string NombreCategoria { get; set; }
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
                var categoriaExistente = await _context.Categorias.FindAsync(request.IdCategoria);
                if (categoriaExistente is null) throw new Exception("El banco a actualizar no existe.");
                categoriaExistente.NombreCategoria = request.NombreCategoria;
                _context.Categorias.Update(categoriaExistente);
                return await _context.SaveChangesAsync() > 0
                    ? Unit.Value 
                    : throw new Exception("Problema al actualizar la categoria");
            }
        }
    }
}