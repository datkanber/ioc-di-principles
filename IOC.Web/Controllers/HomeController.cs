using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UdemyIOC.Web.Models;

namespace UdemyIOC.Web.Controllers
{
    public class HomeController : Controller
    {
        // private readonly ISingletonDateService _singletonDateService;

        //  private readonly IScopedDateService _scopedDateService;

        private readonly ITransientDateservice _transientDateservice;

        public HomeController(ITransientDateservice transientDateservice)
        {
            _transientDateservice = transientDateservice;
        }

        public IActionResult Index([FromServices] ITransientDateservice transientDateservice2)
        {
            ViewBag.time1 = _transientDateservice.GetDateTime.TimeOfDay.ToString();

            ViewBag.time2 = transientDateservice2.GetDateTime.TimeOfDay.ToString();
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