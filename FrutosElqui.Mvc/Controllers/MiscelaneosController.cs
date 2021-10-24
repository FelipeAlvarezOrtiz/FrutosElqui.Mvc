using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FrutosElqui.Core.Misc;
using FrutosElqui.Negocio.Misc.Comunas;
using FrutosElqui.Negocio.Misc.Dtes;
using FrutosElqui.Negocio.Misc.Extras;
using FrutosElqui.Negocio.Misc.Giros;
using FrutosElqui.Negocio.Misc.Sectores;
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

        #region Documentos tributarios y giros
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
        #endregion

        #region Localizaciones

        [Route("Localizaciones/Index")]
        public async Task<IActionResult> IndexLocalizaciones()
        {
            ViewData["Comunas"] = await Mediator.Send(new ListaDeComunas.Query());
            ViewData["Sectores"] = await Mediator.Send(new ListaSectores.Query());
            return View("Localizaciones/Index");
        }

        [HttpPost("CrearComuna"),Authorize(Roles = "Administrador")]
        public async Task<ActionResult<Unit>> NuevaComuna(CrearComuna.Command request)
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

        [HttpPost("CrearSector"),Authorize(Roles = "Administrador")]
        public async Task<ActionResult<Unit>> NuevoSector(CrearSector.Command request)
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

        [HttpGet]
        public async Task<ActionResult<List<Comuna>>> ObtenerComunas()
        {
            return await Mediator.Send(new ListaDeComunas.Query());
        }

        [HttpGet]
        public async Task<ActionResult<List<Sector>>> ObtenerSectores()
        {
            return await Mediator.Send(new ListaSectores.Query());
        }

        #endregion

        #region Sabores, categorias y medidas - EXTRAS

        [Route("Extras")]
        public async Task<IActionResult> IndexExtras()
        {
            ViewData["Sabores"] = await Mediator.Send(new ListaSabores.Query());
            ViewData["Medidas"] = await Mediator.Send(new ListaMedidas.Query());
            ViewData["Categorias"] = await Mediator.Send(new ListaCategorias.Query());
            return View("Extras/Index");
        }

        [HttpPost("CrearSabor")]
        public async Task<ActionResult<Unit>> CrearSabor(CrearSabor.Command request)
        {
            try
            {
                return await Mediator.Send(request);
            }
            catch(Exception error)
            {
                return BadRequest(error.Message);
            }
        }

        [HttpPost("CrearMedida")]
        public async Task<ActionResult<Unit>> CrearMedida(CrearMedida.Command request)
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

        [HttpPost("CrearCategoria")]
        public async Task<ActionResult<Unit>> CrearCategoria(CrearCategoria.Command request)
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

        [HttpGet("ObtenerMedidas")]
        public async Task<ActionResult<List<Medida>>> ObtenerMedidas()
        {
            return await Mediator.Send(new ListaMedidas.Query());
        }

        [HttpGet("ObtenerCategorias")]
        public async Task<ActionResult<List<Categoria>>> ObtenerCategorias()
        {
            return await Mediator.Send(new ListaCategorias.Query());
        }

        [HttpGet("ObtenerSabores")]
        public async Task<ActionResult<List<Sabor>>> ObtenerSabores()
        {
            return await Mediator.Send(new ListaSabores.Query());
        }

        #endregion


    }
}
