using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GestordeCasosPF.Areas.Clientes.Controllers
{
    [Area("Clientes")]
    public class ClientesController : Controller
    {
        public IActionResult Clase()
        {
            return View();
        }
    }
}
