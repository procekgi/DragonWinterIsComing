using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DragonWinterIsComing.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult PaginaUsuario()
        {
            return View();
        }
    }
}