using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using FrutosElqui.Core.Misc;
using FrutosElqui.Mvc.Controllers;
using FrutosElqui.Negocio.Misc.Bancos;
using MediatR;
using Microsoft.AspNetCore.Authorization;

namespace FrutosElqui.Mvc.ApiControllers
{
    [Authorize]
    public class BancosController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<List<Banco>>> ListaBanco()
        {
            return await Mediator.Send(new ListaDeBancos.Query());
        }

        [HttpPost,Authorize(Roles = "Administrador")]
        public async Task<ActionResult<Unit>> CrearBanco(CrearBanco.Command request)
        {
            return await Mediator.Send(request);
        }

        [HttpPut,Authorize(Roles = "Administrador")]
        public async Task<ActionResult<Unit>> ActualizarBanco(ActualizarBanco.Command request)
        {
            return await Mediator.Send(request);
        }

        [HttpGet("{idBanco:int}")]
        public async Task<ActionResult<Banco>> ObtenerBanco(int idBanco)
        {
            return await Mediator.Send(new ObtenerBanco.Query{IdBanco = idBanco});
        }
    }
}
