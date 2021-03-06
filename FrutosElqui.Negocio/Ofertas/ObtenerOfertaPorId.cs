using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Core.Ofertas;
using FrutosElqui.Persistencia;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FrutosElqui.Negocio.Ofertas
{
    public class ObtenerOfertaPorId
    {
        public record Query : IRequest<Oferta>
        {
            public int IdOferta { get; set; }
        }

        public class Handler : IRequestHandler<Query,Oferta>
        {
            private readonly ApplicationDbContext _context;

            public Handler(ApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<Oferta> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Ofertas.Where(oferta => oferta.IdOferta == request.IdOferta)
                    .Include(oferta => oferta.ProductosEnOferta)
                    .ThenInclude(detalle => detalle.Producto)
                    .ThenInclude(producto => producto.ProveedorProducto)
                    .FirstOrDefaultAsync(cancellationToken);
            }
        }
    }
}
