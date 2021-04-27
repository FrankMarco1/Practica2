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
    public class CompraController : Controller
    {
        private readonly ILogger<CompraController> _logger;

        public CompraController(ILogger<CompraController> logger)
        {
            _logger = logger;
        }

        public IActionResult PagarCompra()
        {
            return View();
        }

        public IActionResult ResumenCompra()
        {
            return View();
        }
    }
}