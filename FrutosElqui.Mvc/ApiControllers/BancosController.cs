using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using FrutosElqui.Core.Misc;
using FrutosElqui.Mvc.Controllers;
using FrutosElqui.Negocio.Misc.Bancos;

namespace FrutosElqui.Mvc.ApiControllers
{
    public class BancosController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<List<Banco>>> ListaBanco()
        {
            return await Mediator.Send(new ListaDeBancos.Query());
        }
    }
}
