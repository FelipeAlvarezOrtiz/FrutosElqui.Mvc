using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using FrutosElqui.Core.Misc;
using FrutosElqui.Mvc.Controllers;
using FrutosElqui.Negocio.Misc.Bancos;
using FrutosElqui.Persistencia;
using MediatR;
using Microsoft.AspNetCore.Authorization;

namespace FrutosElqui.Mvc.ApiControllers
{
    [Authorize]
    public class BancosController : BaseController
    {
        private readonly ApplicationDbContext _context;

        public BancosController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<List<Banco>>> ListaBanco()
        {
            return await Mediator.Send(new ListaDeBancos.Query());
        }

        [HttpPost("CrearBanco"),Authorize(Roles = "Administrador")]
        public async Task<ActionResult<Unit>> CrearBanco(CrearBanco.Command request)
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

        [HttpPost("ActualizarBanco"),Authorize(Roles = "Administrador")]
        public async Task<ActionResult<Unit>> ActualizarBanco(ActualizarBanco.Command request)
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

        [HttpGet("{idBanco:int}")]
        public async Task<ActionResult<Banco>> ObtenerBanco(int idBanco)
        {
            try
            {
                return await Mediator.Send(new ObtenerBanco.Query { IdBanco = idBanco });
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }
        
        public async Task<IActionResult> Index()
        {
            ViewData["Bancos"] = await Mediator.Send(new ListaDeBancos.Query());
            return View();
        }

        [Route("EditarBanco")]
        public async Task<IActionResult> EditarBanco(int idBanco)
        {
            ViewData["Banco"] = await Mediator.Send(new ObtenerBanco.Query { IdBanco = idBanco });
            return View();
        }

    }
}
