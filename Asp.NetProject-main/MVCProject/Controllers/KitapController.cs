using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MVCProject.Models;
public class KitapController: Controller
{
 //Geçici Kitap Listesi

 private static List<KitapModel> kitaplar = new List<KitapModel>();

 public IActionResult Giris(){
   return View();
 }

 [HttpPost]
 public IActionResult Giris(KullaniciModel model)
 {
   if(model.KullaniciAdi=="admin" && model.Sifre=="1234"){
      return RedirectToAction("Ekle");
   }
   ViewBag.Hata="Hatalı Giriş!";
   return View();
 }
 public IActionResult Ekle()
 {
   return View();
 }
 [HttpPost]
 public IActionResult Ekle(KitapModel kitap)
 {
   kitaplar.Add(kitap);
   return RedirectToAction("Liste");
 }
public IActionResult Liste(){
   return View(kitaplar);
}
}