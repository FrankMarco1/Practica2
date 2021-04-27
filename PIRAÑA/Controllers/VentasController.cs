using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PIRAÑA.Models;

namespace PIRAÑA.Controllers
{
    public class VentasController : Controller
    {
        private readonly ILogger<VentasController> _logger;

        public VentasController(ILogger<VentasController> logger)
        {
            _logger = logger;
        }

        public IActionResult CatalogoCompleto()
        {
            return View();
        }

        public IActionResult ProductosDestacados()
        {
            return View();
        }
        public IActionResult Servicios()
        {
            return View();
        }
    }
}