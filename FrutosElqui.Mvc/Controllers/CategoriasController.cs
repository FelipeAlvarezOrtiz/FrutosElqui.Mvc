using System.Collections.Generic;
using System.Threading.Tasks;
using FrutosElqui.Core.Misc;
using FrutosElqui.Mvc.Controllers;
using FrutosElqui.Negocio.Misc.Categorias;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FrutosElqui.Mvc.ApiControllers
{
    [Authorize]
    public class CategoriasController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<List<Categoria>>> ObtenerCategorias()
        {
            return await Mediator.Send(new ListaDeCategorias.Query());
        }

        [HttpPost, Authorize(Roles = "Administrador")]
        public async Task<ActionResult<Unit>> CrearCategoria(CrearCategoria.Command request)
        {
            return await Mediator.Send(request);
        }

        [HttpPut, Authorize(Roles = "Administrador")]
        public async Task<ActionResult<Unit>> ActualizarCategoria(ActualizarCategoria.Command request)
        {
            return await Mediator.Send(request);
        }

        [HttpGet("{idCategoria:int}")]
        public async Task<ActionResult<Categoria>> ObtenerCategoria(int idCategoria)
        {
            return await Mediator.Send(new ObtenerCategoria.Query { IdCategoria = idCategoria });
        }
    }
}
