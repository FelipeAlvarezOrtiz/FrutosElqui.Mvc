using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FrutosElqui.Core.Misc;
using FrutosElqui.Negocio.Misc.Dtes;
using FrutosElqui.Negocio.Misc.Giros;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FrutosElqui.Mvc.Controllers
{
    [Authorize]
    public class MiscelaneosController : BaseController
    {
        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Dte/Index")]
        public async Task<IActionResult> IndexDtes()
        {
            ViewData["Giros"] = await Mediator.Send(new ListaGiros.Query());
            ViewData["Dtes"] = await Mediator.Send(new ListaDtes.Query());
            return View("Dtes/Index");
        }

        [HttpPost("CrearDte")]
        public async Task<ActionResult<Unit>> CrearDte(CrearDte.Command request)
        {
            try
            {
                return await Mediator.Send(request);
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpPost("CrearGiro")]
        public async Task<ActionResult<Unit>> CrearGiro(CrearGiro.Command request)
        {
            try
            {
                return await Mediator.Send(request);
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpGet("ObtenerGiros")]
        public async Task<ActionResult<List<Giro>>> ListaGiros()
        {
            return await Mediator.Send(new ListaGiros.Query());
        }

        [HttpGet("ObtenerDtes")]
        public async Task<ActionResult<List<DocumentoTributario>>> ListaDtes()
        {
            return await Mediator.Send(new ListaDtes.Query());
        }

    }
}
