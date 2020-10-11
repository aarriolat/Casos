using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestordeCasosPF.Areas.TipoServicio.Models;
using Microsoft.AspNetCore.Mvc;
using GestordeCasosPF.Library;
using Microsoft.AspNetCore.Identity;
using GestordeCasosPF.Models;
using GestordeCasosPF.Data;
using GestordeCasosPF.Controllers;

namespace GestordeCasosPF.Areas.TipoServicio.Controllers
{
    [Area("TipoServicio")]
    public class TipoServicioController : Controller
    {

        private TTipoServicio _TTipoServicio;
        private LTipoServicio _lTipoServicio;
        private SignInManager<IdentityUser> _signInManager;
        private static DataPaginador<TTipoServicio> models;

        public TipoServicioController(ApplicationDbContext context, SignInManager<IdentityUser> signInManager)
        {
            _signInManager = signInManager;
            _lTipoServicio = new LTipoServicio(context);
        }
        public IActionResult TipoServicio()
        {
            if (_signInManager.IsSignedIn(User))
            {
                models = new DataPaginador<TTipoServicio>
                {
                    Input = new TTipoServicio()
                };
                return View(models);
            }
            else
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
        }
    }
}