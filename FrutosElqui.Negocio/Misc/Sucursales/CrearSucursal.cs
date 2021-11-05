using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FrutosElqui.Core.Misc;
using FrutosElqui.Negocio.Misc.Comunas;
using FrutosElqui.Negocio.Misc.Regiones;
using FrutosElqui.Persistencia;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FrutosElqui.Negocio.Misc.Sucursales
{
    public class CrearSucursal
    {
        public record Command : IRequest
        {
            public string NombreSucursal { get; set; }
            public string Calle { get; set; }
            public int IdComuna { get; set; }
            public int IdRegion { get; set; }
            public string NumeroTelefonico { get; set; }
            public string JefeSucursal { get; set; }
            public int TipoSucursal { get; set; }
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
                if (await _context.Sucursales.Where(sucursal => sucursal.NombreSucursal.Equals(request.NombreSucursal))
                    .FirstOrDefaultAsync(cancellationToken) is not null)
                    throw new Exception("Esa sucursal ya existe");
                var comuna = await _mediator.Send(new ObtenerComuna.Query { IdComuna = request.IdComuna });
                var region = await _mediator.Send(new ObtenerRegion.Query { IdRegion = request.IdRegion });
                var tipoSucursal = await _mediator.Send(new ObtenerTipoSucursal.Query{IdTipoSucursal = request.TipoSucursal});
                await _context.Sucursales.AddAsync(new Sucursal()
                {
                    Region = region,
                    NombreSucursal = request.NombreSucursal,
                    TipoSucursal = tipoSucursal,
                    Comuna = comuna,
                    Calle = request.Calle,
                    JefeSucursal = request.JefeSucursal,
                    NumeroTelefonico = request.NumeroTelefonico
                });
                return await _context.SaveChangesAsync(cancellationToken) > 0 
                    ? Unit.Value 
                    : throw new Exception("Ha ocurrido un error al guardar la sucursal");
            }
        }
    }
}
