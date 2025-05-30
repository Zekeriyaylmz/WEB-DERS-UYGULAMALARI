using Microsoft.AspNetCore.Mvc;

public class ListeController : Controller
{
    // Parametre olarak id alan ve ekrana yazan bir action
    public string Liste(int id)
    {
        return $"Parametreden gelen değer:{id}"; // id parametresini metin olarak döndürür
    }
}
