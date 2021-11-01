using System;
using System.Threading.Tasks;
using FrutosElqui.Core.Productos;
using FrutosElqui.Negocio.Productos;
using FrutosElqui.Persistencia;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FrutosElqui.Mvc.Controllers
{
    [Authorize]
    public class ProductosController : BaseController
    {
        private readonly ApplicationDbContext _context;

        public ProductosController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            ViewData["Productos"] = await Mediator.Send(new ListaProductos.Query());
            return View();
        }

        [Route("NuevoProducto"),Authorize(Roles = "Administrador")]
        public async Task<IActionResult> NuevoProducto()
        {
            ViewData["Sabores"] = await _context.Sabores.ToListAsync();
            ViewData["Proveedores"] = await _context.Proveedores.ToListAsync();
            ViewData["Categorias"] = await _context.Categorias.ToListAsync();
            ViewData["Medidas"] = await _context.Medidas.ToListAsync();
            return View();
        }

        [HttpPost("CrearNuevoProducto"),Authorize(Roles = "Administrador")]
        public async Task<ActionResult<Unit>> CrearNuevoProducto(NuevoProducto.Command request)
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

        [HttpGet("{idProducto:int}"),Authorize(Roles = "Administrador,Vendedor")]
        public async Task<ActionResult<Producto>> ObtenerProducto(int idProducto)
        {
            try
            {
                return await Mediator.Send(new ObtenerProducto.Query{IdProducto = idProducto});
            }
            catch (Exception error)
            {
                return BadRequest(error.Message);
            }
        }
        
    }
}
