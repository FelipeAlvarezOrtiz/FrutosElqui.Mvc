using System.Threading.Tasks;
using FrutosElqui.Persistencia;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FrutosElqui.Mvc.Controllers
{
    [Authorize(Roles = "Administrador")]
    public class ProveedoresController : BaseController
    {

        private readonly ApplicationDbContext _context;

        public ProveedoresController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            ViewData["Proveedores"] = await _context.Proveedores.ToListAsync();
            return View();
        }

        [Route("Nuevo")]
        public async Task<IActionResult> NuevoProveedor()
        {
            ViewData["Bancos"] = await _context.Bancos.ToListAsync();
            ViewData["TipoCuentas"] = await _context.TipoCuentas.ToListAsync();
            ViewData["Giros"] = await _context.Giros.ToListAsync();
            ViewData["TipoPagos"] = await _context.TipoPagos.ToListAsync();
            return View();
        }
    }
}
