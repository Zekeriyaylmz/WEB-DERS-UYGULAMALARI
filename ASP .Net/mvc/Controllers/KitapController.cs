using Microsoft.AspNetCore.Mvc;

public class KitapController : Controller
{

public IActionResult Kategoriler()
{

    return View();
}

public IActionResult KitapListesi(){

    return View();
}

public string Index()
{

    return "Kitap Controller Sınıfındaki Index Metodu Çalıştı";
}

}