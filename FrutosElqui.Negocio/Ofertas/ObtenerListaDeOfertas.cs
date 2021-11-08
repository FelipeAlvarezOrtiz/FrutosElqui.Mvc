using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Core.Ofertas;
using FrutosElqui.Persistencia;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FrutosElqui.Negocio.Ofertas
{
    public class ObtenerListaDeOfertas
    {
        public record Query : IRequest<List<Oferta>>{}

        public class Handler : IRequestHandler<Query,List<Oferta>>
        {
            private readonly ApplicationDbContext _context;

            public Handler(ApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<List<Oferta>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Ofertas
                    .Include(oferta => oferta.ProductosEnOferta)
                    .ThenInclude(detalle => detalle.Producto)
                    .ThenInclude(producto => producto.ProveedorProducto)
                    .Include(oferta => oferta.ProductosEnOferta)
                    .ThenInclude(detalle => detalle.Producto)
                    .ThenInclude(producto => producto.CategoriaProducto)
                    .Include(oferta => oferta.ProductosEnOferta)
                    .ThenInclude(detalle => detalle.Producto)
                    .ThenInclude(producto => producto.MedidaProducto)
                    .Include(oferta => oferta.ProductosEnOferta)
                    .ThenInclude(detalle => detalle.Producto)
                    .ThenInclude(producto => producto.SaborProducto)
                    .ToListAsync(cancellationToken);
            }
        }
    }
}
