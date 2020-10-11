using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GestordeCasosPF.Areas.Casos.Controllers
{
    [Area("Casos")]
    public class CasosController : Controller
    {
        public IActionResult Casos()
        {
            return View();
        }
    }
}
