using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCProject.Models;

namespace MVCProject.Controllers
{
    public class HomeController : Controller
    {
        // Anasayfa görünümünü döndürür.
        public IActionResult Index()
        {
            return View();
        }

        // Hakkında (About) sayfası için mesajla birlikte görünüm döner.
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            return View();
        }

        // İletişim (Contact) sayfası için mesajla birlikte görünüm döner.
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            return View();
        }

        // Gizlilik (Privacy) sayfası görünümünü döndürür.
        public IActionResult Privacy()
        {
            return View();
        }

        // Hata sayfası için hata modeliyle görünüm döner. Cache yapılmaz.
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            // Hata durumunda RequestId içeren model döner.
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
