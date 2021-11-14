using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Core.Ventas;
using FrutosElqui.Negocio.Inventarios;
using FrutosElqui.Negocio.Misc.Sucursales;
using FrutosElqui.Negocio.Misc.TipoPago;
using FrutosElqui.Negocio.Ofertas;
using FrutosElqui.Negocio.Productos;
using FrutosElqui.Negocio.Proveedores;
using FrutosElqui.Persistencia;
using MediatR;

namespace FrutosElqui.Negocio.Ventas
{
    public class CrearVenta
    {
        public record Command : IRequest
        {
            public int IdSucursal { get; set; }
            public int IdTipoPago { get; set; }
            public int Descuento { get; set; }
            public int Total { get; set; }
            public List<CommandDetalle> DetallesVentas { get; set; }
            public List<CommandOfertasDetalle>  DetallesVentaOfertas { get; set; }
        }

        public record CommandDetalle
        {
            public int IdProducto { get; set; }
            public int IdProveedor { get; set; }
            public int CantidadProducto { get; set; }
        }

        public record CommandOfertasDetalle
        {
            public Guid IdOferta { get; set; }
            public int CantidadOferta { get; set; }
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
                //obtener sucursal
                var sucursal = await _mediator.Send(new ObtenerSucursal.Query { IdSucursal = request.IdSucursal }, cancellationToken);
                if (sucursal is null)
                    throw new Exception("Sucursal es no existe");
                //obtener tipo de pago
                var tipoPago = await _mediator.Send(new ObtenerTipoPago.Query { IdTipoPago = request.IdTipoPago }, cancellationToken);
                if (tipoPago is null)
                    throw new Exception("El tipo de pago no existe.");
                //obtener los productos del detalle
                var listDetalles = new List<DetalleVenta>(request.DetallesVentas.Count);
                foreach (var detalleVenta in request.DetallesVentas)
                {
                    var guidDetalle = Guid.NewGuid();
                    var productoEnDetalle = await _mediator.Send(new ObtenerProducto.Query
                        { IdProducto = detalleVenta.IdProducto });
                    var proveedorEnDetalle = await _mediator.Send(new ObtenerProveedorPorId.Query
                        { IdProveedor = detalleVenta.IdProveedor });
                    listDetalles.Add(new DetalleVenta()
                    {
                        IdProducto = detalleVenta.IdProducto,
                        NombreProveedor = proveedorEnDetalle.NombreProveedor,
                        NombreProducto = productoEnDetalle.NombreBusqueda,
                        IdProveedor = detalleVenta.IdProveedor,
                        IdDetalle = guidDetalle,
                        CantidadProducto = detalleVenta.CantidadProducto,
                        TotalProducto = (productoEnDetalle.PrecioTotal * detalleVenta.CantidadProducto)
                    });

                    await _mediator.Send(new ReducirInventario.Command()
                    {
                        Cantidad = detalleVenta.CantidadProducto,
                        IdProducto = detalleVenta.IdProducto,
                        IdSucursal = sucursal.IdSucursal
                    }, cancellationToken);
                }
                //aplicar las ofertas
                var listaOfertas = new List<OfertasEnVenta>(request.DetallesVentaOfertas.Count);
                foreach (var ofertasEnDetalle in request.DetallesVentaOfertas)
                {
                    var oferta = await _mediator.Send(new ObtenerOferta.Query
                        { IdOferta = ofertasEnDetalle.IdOferta }, cancellationToken);
                    var guidOfertaDetalle = Guid.NewGuid();
                    listaOfertas.Add(new OfertasEnVenta()
                    {
                        NombreOferta = oferta.NombreOferta,
                        GuidOferta = oferta.GuidOferta,
                        IdOfertasVenta = guidOfertaDetalle,
                        CantidadOferta = ofertasEnDetalle.CantidadOferta
                    });
                    foreach(var detallesDeOferta in oferta.ProductosEnOferta)
                    {
                        await _mediator.Send(new ReducirInventario.Command()
                        {
                            Cantidad = detallesDeOferta.CantidadProducto,
                            IdProducto = detallesDeOferta.Producto.IdProducto,
                            IdSucursal = sucursal.IdSucursal
                        }, cancellationToken);
                    }
                }

                await _context.Ventas.AddAsync(new Venta()
                {              
                    Sucursal = sucursal,
                    TipoPago = tipoPago,
                    Descuento = request.Descuento,
                    DetallesVenta = listDetalles,
                    FechaVenta = DateTime.Now,
                    IdVenta = Guid.NewGuid(),
                    NombreUsuarioVenta = "SYSTEM",
                    OfertasEnVenta = listaOfertas,
                    RutUsuarioVenta = "SYSTEM",
                    Total = request.Total
                },cancellationToken);

                return await _context.SaveChangesAsync(cancellationToken) > 0 
                    ? Unit.Value 
                    : throw new Exception("No se puede registrar la venta en sistema.");
            }

        }
    }
}
