using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LessonMvc.Models;
using Microsoft.AspNetCore.Http;

namespace LessonMvc.Controllers
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
            ViewBag.temp = "hiihi";
            Response.Cookies.Delete("user");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public string SetSession()
        {
            HttpContext.Session.SetString("session1", "hihi");
            HttpContext.Session.SetString("session2", "haha");
            return "this is set session";
        }
        public string GetSession()
        {
            var ss1 = HttpContext.Session.GetString("session1");
            var ss2 = HttpContext.Session.GetString("session2");
            return (ss1 + ss2);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
