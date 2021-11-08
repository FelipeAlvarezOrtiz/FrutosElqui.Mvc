using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Core.Ofertas;
using FrutosElqui.Negocio.Productos;
using FrutosElqui.Negocio.Proveedores;
using FrutosElqui.Persistencia;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FrutosElqui.Negocio.Ofertas
{
    public class CrearOferta
    {
        public record Command : IRequest
        {
            public List<CommandDetalle> ProductosEnOferta { get; set; }
            public int PrecioOferta { get; set; }
            public string NombreOferta { get; set; }
        }

        public record CommandDetalle
        {
            public int IdProducto { get; set; }
            public int Cantidad { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly ApplicationDbContext _context;
            private readonly IMediator _mediator;

            public Handler(ApplicationDbContext context, IMediator mediator)
            {
                _context = context;
                _mediator = mediator;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                if (await _context.Ofertas.Where(oferta => oferta.NombreOferta.Equals(request.NombreOferta))
                    .FirstOrDefaultAsync(cancellationToken) is not null)
                    throw new Exception("El nombre de esa oferta ya está registrada en sistema");

                var ListaDetalles = new List<DetalleOferta>(request.ProductosEnOferta.Count);
                
                foreach (var detalle in request.ProductosEnOferta)
                {
                    var producto = await _mediator.Send(new ObtenerProducto.Query { IdProducto = detalle.IdProducto}, cancellationToken);
                    producto.ProveedorProducto = await _mediator.Send(new ObtenerProveedorPorId.Query { IdProveedor = producto.ProveedorProducto.IdProveedor}, cancellationToken);
                    var guidDetalleOferta = Guid.NewGuid();
                    var detalleOferta = new DetalleOferta()
                    {
                        Producto = producto,
                        CantidadProducto = detalle.Cantidad,
                        GuidDetalle = guidDetalleOferta
                    };
                    ListaDetalles.Add(detalleOferta);
                }

                var ofertaCabeceraGuid = Guid.NewGuid();
                var detalleCabecera = new Oferta()
                {
                    GuidOferta = ofertaCabeceraGuid,
                    FechaCreacion = DateTime.Now,
                    NombreOferta = request.NombreOferta,
                    PrecioOferta = request.PrecioOferta,
                    ProductosEnOferta = ListaDetalles
                };

                await _context.Ofertas.AddAsync(detalleCabecera,cancellationToken);
                return await _context.SaveChangesAsync(cancellationToken) > 0
                    ? Unit.Value
                    : throw new Exception("Ha ocurrido un error al guardar la oferta, intentelo nuevamente.");
            }
        }
    }
}
