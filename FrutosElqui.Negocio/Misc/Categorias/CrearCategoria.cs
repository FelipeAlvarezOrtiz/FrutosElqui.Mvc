using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Core.Misc;
using FrutosElqui.Persistencia;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FrutosElqui.Negocio.Misc.Categorias
{
    public class CrearCategoria
    {
        public class Command : IRequest
        {
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
                if (await _context.Categorias
                    .Where(categoria => categoria.NombreCategoria.Equals(request.NombreCategoria))
                    .FirstOrDefaultAsync() is not null) throw new Exception("Esa categoría ya existe.");
                await _context.Categorias.AddAsync(new Categoria()
                {
                    NombreCategoria = request.NombreCategoria
                });
                return await _context.SaveChangesAsync() > 0
                    ? Unit.Value 
                    : throw new Exception("Problema al guardar la categoria");
            }
        }
    }
}