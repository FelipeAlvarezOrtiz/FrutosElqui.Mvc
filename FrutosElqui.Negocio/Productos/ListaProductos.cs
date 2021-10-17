using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Core.Productos;
using FrutosElqui.Persistencia;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FrutosElqui.Negocio.Productos
{
    public class ListaProductos
    {
        public record Query : IRequest<List<Producto>> { }

        public class Handler : IRequestHandler<Query, List<Producto>>
        {
            private readonly ApplicationDbContext _context;

            public Handler(ApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<List<Producto>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Productos.Include(producto => producto.CategoriaProducto)
                    .Include(producto => producto.MedidaProducto)
                    .Include(producto => producto.SaborProducto).Include(producto => producto.ProveedorProducto)
                    .ToListAsync(cancellationToken);
            }
        }
    }
}
