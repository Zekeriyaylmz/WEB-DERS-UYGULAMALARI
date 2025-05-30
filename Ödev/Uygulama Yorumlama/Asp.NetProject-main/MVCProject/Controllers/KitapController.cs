using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MVCProject.Models;

public class KitapController : Controller
{
    // Geçici kitap listesi: bellekte saklanan kitap koleksiyonu
    private static List<KitapModel> kitaplar = new List<KitapModel>();

    // Giriş sayfasının görünümünü döndürür
    public IActionResult Giris()
    {
        return View();
    }

    // Giriş formundan gelen verileri işler
    [HttpPost]
    public IActionResult Giris(KullaniciModel model)
    {
        // Kullanıcı adı ve şifre kontrolü
        if (model.KullaniciAdi == "admin" && model.Sifre == "1234")
        {
            // Giriş başarılıysa Ekle sayfasına yönlendir
            return RedirectToAction("Ekle");
        }

        // Hatalı girişte mesajı görünümde göster
        ViewBag.Hata = "Hatalı Giriş!";
        return View();
    }

    // Kitap ekleme sayfasının görünümünü döndürür
    public IActionResult Ekle()
    {
        return View();
    }

    // Kitap ekleme formundan gelen verileri işler
    [HttpPost]
    public IActionResult Ekle(KitapModel kitap)
    {
        // Kitabı listeye ekle
        kitaplar.Add(kitap);

        // Liste sayfasına yönlendir
        return RedirectToAction("Liste");
    }

    // Kitap listesini görüntüleyen sayfa
    public IActionResult Liste()
    {
        // Kitap listesi görünümüne veriyi gönder
        return View(kitaplar);
    }
}
