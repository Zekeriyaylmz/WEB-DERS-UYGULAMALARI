using Microsoft.AspNetCore.Mvc;
using HastaKayitApp.Models;

namespace HastaKayitApp.Controllers
{
    public class HastaController : Controller
    {
        // HTTP GET ile çağrıldığında boş formu gösterir
        public IActionResult Kayit()
        {
            return View(); // Views/Hasta/Kayit.cshtml dosyasını yükler
        }

        // HTTP POST ile form gönderildiğinde burası çalışır
        [HttpPost]
        public IActionResult Kayit(Hasta hasta)
        {
            if (ModelState.IsValid) // Form verileri doğruysa
            {
                // Normalde burada veritabanına kayıt işlemi yapılır
                ViewBag.Mesaj = "Hasta başarıyla kaydedildi."; // Kullanıcıya mesaj göstermek için
                return View("KayitSonuc", hasta); // Kayıt sonucu sayfasına yönlendir
            }

            // Hatalı veri varsa formu tekrar göster
            return View(hasta);
        }
    }
}
