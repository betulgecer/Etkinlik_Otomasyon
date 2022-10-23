using Etkinlik_Otomasyon.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Etkinlik_Otomasyon.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }
 
        public IActionResult AddKullanıcı(KULLANICI kullanıcı)
        {
            if (ModelState.IsValid)
            {
                EtkinlikDBContext context = new EtkinlikDBContext();
                context.KULLANICIs.Add(kullanıcı);

                context.SaveChanges(); 

            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}