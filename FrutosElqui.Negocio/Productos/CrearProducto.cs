using System;
using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Negocio.Misc.Categorias;
using FrutosElqui.Persistencia;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

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
            public int Sabor { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly ApplicationDbContext _context;
            private IMediator _mediator;
            
            public Handler(ApplicationDbContext context, IMediator mediator)
            {
                _context = context;
                _mediator = mediator;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var categoria = await _mediator.Send(new ObtenerCategoria.Query {IdCategoria = request.Categoria});
                
                return await _context.SaveChangesAsync(cancellationToken) > 0
                    ? Unit.Value
                    : throw new Exception("Problema al guardar el producto");
            }
        }

    }
}
