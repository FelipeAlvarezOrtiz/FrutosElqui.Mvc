using System;
using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Persistencia;
using MediatR;

namespace FrutosElqui.Negocio.Productos
{
    public class CrearProducto
    {
        public record Command : IRequest
        {
            public string NombreProducto { get; set; }
            public string DescripcionProducto { get; set; }
            public int PrecioMayorista { get; set; }
            public int PrecioTotal { get; set; }

            public int Categoria { get; set; }

            public int Medida { get; set; }

            public int Proveedor { get; set; }
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
                return await _context.SaveChangesAsync(cancellationToken) > 0
                    ? Unit.Value
                    : throw new Exception("Problema al guardar el producto");
            }
        }

    }
}
