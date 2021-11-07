using System;
using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Core.Misc;
using FrutosElqui.Negocio.Misc.Sucursales;
using FrutosElqui.Persistencia;
using MediatR;

namespace FrutosElqui.Negocio.Misc.EgresosDinero
{
    public class CrearEgresoDinero
    {
        public record Command : IRequest
        {
            public int CantidadEgresada { get; set; }
            public string Observacion { get; set; }
            public int SucursalOrigen { get; set; }
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
                var sucursal = await _mediator.Send(new ObtenerSucursal.Query { IdSucursal = request.SucursalOrigen }, cancellationToken);
                if (sucursal is null) throw new Exception("La sucursal no existe");
                await _context.EgresosDineros.AddAsync(new EgresoDinero()
                {
                    SucursalOrigen = sucursal,
                    FechaEgreso = DateTime.Now,
                    CantidadEgresada = request.CantidadEgresada,
                    Observacion = request.Observacion
                }, cancellationToken);
                return await _context.SaveChangesAsync(cancellationToken) > 0
                    ? Unit.Value
                    : throw new Exception("Ha ocurrido un error al guardar el ingreso");
            }
        }
    }
}
