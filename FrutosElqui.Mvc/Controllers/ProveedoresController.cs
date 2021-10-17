using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FrutosElqui.Mvc.Controllers
{
    [Authorize(Roles = "Administrador")]
    public class ProveedoresController : BaseController
    {
        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            return View();
        }

        [Route("Nuevo")]
        public async Task<IActionResult> NuevoProveedor()
        {
            return View();
        }
    }
}
