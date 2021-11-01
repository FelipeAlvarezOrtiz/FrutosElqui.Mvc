using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Core.Proveedores;
using FrutosElqui.Persistencia;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FrutosElqui.Negocio.Proveedores
{
    public class ObtenerProveedorPorId
    {
        public record Query : IRequest<Proveedor>
        {
            public int IdProveedor { get; set; }
        }

        public class Handler : IRequestHandler<Query, Proveedor>
        {
            private readonly ApplicationDbContext _context;

            public Handler(ApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<Proveedor> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Proveedores.Where(proveedor => proveedor.IdProveedor == request.IdProveedor)
                    .Include(proveedor => proveedor.BancoProveedor).Include(proveedor => proveedor.GiroProveedor)
                    .Include(proveedor => proveedor.TipoCuentaProveedor).Include(proveedor => proveedor.TipoPagoProveedor)
                    .FirstOrDefaultAsync(cancellationToken);
            }
        }
    }
}
