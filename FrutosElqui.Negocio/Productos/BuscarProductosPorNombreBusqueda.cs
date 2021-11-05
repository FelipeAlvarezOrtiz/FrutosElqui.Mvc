using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Core.Productos;
using FrutosElqui.Persistencia;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FrutosElqui.Negocio.Productos
{
    public class BuscarProductosPorNombreBusqueda
    {
        public record Query : IRequest<List<Producto>>
        {
            public string NombreBusqueda { get; set; }
        }

        public class Handler : IRequestHandler<Query, List<Producto>>
        {
            private readonly ApplicationDbContext _context;

            public Handler(ApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<List<Producto>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Productos
                    .Where(producto => producto.NombreBusqueda.Contains(request.NombreBusqueda))
                    .Include(producto => producto.CategoriaProducto).Include(producto => producto.MedidaProducto)
                    .Include(producto => producto.SaborProducto).Include(producto => producto.ProveedorProducto)
                    .ToListAsync(cancellationToken);
            }
        }
    }
}
