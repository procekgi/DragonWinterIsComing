using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DragonWinterIsComing.Controllers
{
    public class PilotoController : Controller
    {
        public IActionResult PaginaPiloto()
        {
            return View();
        }

    }
}