using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Spreco.Models;

namespace Spreco.Controllers
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
            string clientid = Environment.GetEnvironmentVariable("sprecoid");
            string url = "https://accounts.spotify.com/authorize?client_id=" +
                          clientid +
                          "&redirect_uri=https://localhost:44336/home/callback" +
                          "&scope=user-read-private%20user-read-email" +
                          "&response_type=token" +
                          "&state=123";

            ViewBag.AuthUrl = url;

            return View();
        }
        
        public IActionResult Callback()
        {
            return View(); 
        }
        public IActionResult Privacy()
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
