﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Atv_3___MVC_.net.Models;

namespace Atv_3___MVC_.net.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Contato()
        {
            return View();
        }
        public IActionResult Sobre()
        {
            return View();
        }
        public IActionResult ConfirmacaoEnvio()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EnviarContato(ContatoViewModel contato)
        {
            if (!ModelState.IsValid)
            {
                ViewData["mensagem"] = "Informações inválidas";
                return View("Contato", contato);
            }

            ListaContatoViewModel.Add(contato);
            return View("ConfirmacaoEnvio", contato);
        }
    }
}
