﻿using Microsoft.AspNetCore.Mvc;
using Nutella.Web.Models;
using System.Diagnostics;

namespace Nutella.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult WhatIsIt()
        {
            return View();
        }

        public IActionResult History()
        {
            return View();
        }

        public IActionResult Evolution()
        {
            return View();
        }

        public IActionResult Recipes()
        {
            return View();
        }

        public IActionResult Store()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult ShoppingCart()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contact(string name, string email, string message)
        {
            // Aqui você pode adicionar lógica para processar o formulário e enviar o email.

            // Exemplo simples de exibição das informações enviadas.
            ViewData["Name"] = name;
            ViewData["Email"] = email;
            ViewData["Message"] = message;

            return View("ContactConfirmation");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
