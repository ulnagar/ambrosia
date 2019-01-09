using Ambrosia.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ambrosia.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult About()
        {
            return View();
        }
        
        public IActionResult Cookies()
        {
            // Update to reflect the final URL of your site
            ViewData["URL"] = "ambrosia.mydigitalhome.net.au";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
