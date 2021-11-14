using FrutosElqui.Core.Ofertas;
using FrutosElqui.Persistencia;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FrutosElqui.Negocio.Ofertas
{
    public class ObtenerOferta
    {
        public record Query : IRequest<Oferta>
        {
            public Guid IdOferta { get; set; }
        }

        public class Handler : IRequestHandler<Query, Oferta>
        {
            private readonly ApplicationDbContext _context;

            public Handler(ApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<Oferta> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Ofertas.Where(oferta => oferta.GuidOferta == request.IdOferta)
                    .Include(oferta => oferta.ProductosEnOferta)
                    .ThenInclude(detalle => detalle.Producto)
                    .ThenInclude(producto => producto.ProveedorProducto)
                    .FirstOrDefaultAsync(cancellationToken);
            }
        }
    }
}
