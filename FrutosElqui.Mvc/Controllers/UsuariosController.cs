using System.Threading.Tasks;
using FrutosElqui.Core.Usuarios;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FrutosElqui.Mvc.Controllers
{
    public class UsuariosController : BaseController
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UsuariosController(RoleManager<IdentityRole> roleManager, UserManager<AppUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        [HttpPost,Route("RegistrarInit")]
        [AllowAnonymous]
        public async Task<IActionResult> RegistrarInit()
        {
            await CrearRoles();
            var user = new AppUser
            {
                Email = "me@felipealvarez.dev",
                UserName = "me@felipealvarez.dev",
                Direccion = "Vicuña"
            };
            var result = await _userManager.CreateAsync(user, "Felipe2-");
            user = await _userManager.FindByEmailAsync("me@felipealvarez.dev");
            if (user is not null)
            {
                await _userManager.AddToRoleAsync(user, "Administrador");
            }
            return Ok();
        }

        private async Task CrearRoles()
        {
            string[] roles = { "Administrador","Vendedor","Mayorista", "Cliente" };
            foreach (var rol in roles)
            {
                if (!await _roleManager.RoleExistsAsync(rol))
                {
                    await _roleManager.CreateAsync(new IdentityRole(rol));
                }
            }
        }

        [HttpPost,Authorize(Roles = "Admnistrador")]
        public async Task<ActionResult> CrearUsuario()
        {
            return Ok();
        }

    }
}
