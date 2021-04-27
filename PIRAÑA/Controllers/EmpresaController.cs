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
    public class EmpresaController : Controller
    {
        private readonly ILogger<EmpresaController> _logger;

        public EmpresaController(ILogger<EmpresaController> logger)
        {
            _logger = logger;
        }

        public IActionResult FormularioContacto()
        {
            return View();
        }

        public IActionResult QuinesSomos()
        {
            return View();
        }
        public IActionResult ServicioyProductos()
        {
            return View();
        }
    }
}