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
    public class UsuarioController : Controller
    {
        private readonly ILogger<UsuarioController> _logger;

        public UsuarioController(ILogger<UsuarioController> logger)
        {
            _logger = logger;
        }

        public IActionResult ActualizarPerfil()
        {
            return View();
        }

        public IActionResult IniciarSesion()
        {
            return View();
        }
        public IActionResult Registro()
        {
            return View();
        }
    }
}