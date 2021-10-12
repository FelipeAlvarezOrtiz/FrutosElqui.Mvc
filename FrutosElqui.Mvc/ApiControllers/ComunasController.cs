using System.Collections.Generic;
using System.Threading.Tasks;
using FrutosElqui.Core.Misc;
using Microsoft.AspNetCore.Mvc;
using FrutosElqui.Mvc.Controllers;
using FrutosElqui.Negocio.Misc.Comunas;
using MediatR;
using Microsoft.AspNetCore.Authorization;

namespace FrutosElqui.Mvc.ApiControllers
{
    [Authorize]
    public class ComunasController : BaseController
    {
        [HttpPost, Authorize(Roles = "Administrador")]
        public async Task<ActionResult<Unit>> CrearComuna(CrearComuna.Command request)
        {
            return await Mediator.Send(request);
        }

        [HttpPut, Authorize(Roles = "Administrador")]
        public async Task<ActionResult<Unit>> ActualizarComuna(ActualizarComuna.Command request)
        {
            return await Mediator.Send(request);
        }

        [HttpGet,Authorize]
        public async Task<ActionResult<List<Comuna>>> ObtenerComunas()
        {
            return await Mediator.Send(new ListaDeComunas.Query());
        }

        [HttpGet("{idComuna:int}"),Authorize]
        public async Task<ActionResult<Comuna>> ObtenerComuna(int idComuna)
        {
            return await Mediator.Send(new ObtenerComuna.Query { IdComuna = idComuna });
        }

    }
}
