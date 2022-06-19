﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PavlyukFinalProjectForCSI350.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PavlyukFinalProjectForCSI350.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("1")]
        [Route("Page")]
        [Route("Home/Page1")]
        [Route("1Page")]
        public IActionResult Page1()
        {
            return View();
        }


        [Route("2")]
        [Route("Page2")]
        [Route("Home/Page2")]
        [Route("2Page")]
        public IActionResult Page2()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
