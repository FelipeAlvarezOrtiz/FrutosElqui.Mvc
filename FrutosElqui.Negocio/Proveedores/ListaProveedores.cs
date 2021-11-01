using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Core.Proveedores;
using FrutosElqui.Persistencia;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FrutosElqui.Negocio.Proveedores
{
    public class ListaProveedores
    {
        public record Query : IRequest<List<Proveedor>> { }

        public class Handler : IRequestHandler<Query, List<Proveedor>>
        {
            private readonly ApplicationDbContext _context;
            public Handler(ApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<List<Proveedor>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Proveedores.ToListAsync(cancellationToken);
            }
        }
    }
}
