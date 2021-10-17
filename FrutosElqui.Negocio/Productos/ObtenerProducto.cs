using System;
using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Core.Productos;
using FrutosElqui.Persistencia;
using MediatR;

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
                    throw new Exception("No existen datos para el producto buscado.");
                return await _context.Productos.FindAsync(request.IdProducto);
            }
        }
    }
}
