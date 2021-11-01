using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Core.Proveedores;
using FrutosElqui.Persistencia;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FrutosElqui.Negocio.Proveedores
{
    public class ObtenerProveedorPorNombre
    {
        public record Query : IRequest<Proveedor>
        {
            public string NombreProveedor { get; set; }
        }

        public class Handler : IRequestHandler<Query,Proveedor>
        {
            private readonly ApplicationDbContext _context;

            public Handler(ApplicationDbContext context)
            {
                _context = context;
            }

            public  async Task<Proveedor> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Proveedores
                    .Where(proveedor => proveedor.NombreProveedor.Equals(request.NombreProveedor))
                    .FirstOrDefaultAsync(cancellationToken);
            }
        }
    }
}
