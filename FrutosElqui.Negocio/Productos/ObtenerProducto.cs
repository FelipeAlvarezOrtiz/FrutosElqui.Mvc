using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Core.Productos;
using FrutosElqui.Persistencia;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FrutosElqui.Negocio.Productos
{
    public class ObtenerProducto
    {
        public class Query : IRequest<Producto>
        {
            public int IdProducto { get; set; }
        }

        public class Handler : IRequestHandler<Query, Producto>
        {
            private readonly ApplicationDbContext _context;

            public Handler(ApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<Producto> Handle(Query request, CancellationToken cancellationToken)
            {
                if (await _context.Productos.FindAsync(request.IdProducto) is null)
                    return null;
                return await _context.Productos.Where(producto => producto.IdProducto == request.IdProducto)
                    .Include(producto => producto.CategoriaProducto)
                    .Include(producto => producto.MedidaProducto)
                    .Include(producto => producto.SaborProducto)
                    .Include(producto => producto.ProveedorProducto).FirstOrDefaultAsync(cancellationToken);
            }
        }
    }
}
