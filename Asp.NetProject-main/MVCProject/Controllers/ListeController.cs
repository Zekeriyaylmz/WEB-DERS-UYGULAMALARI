using Microsoft.AspNetCore.Mvc;
public class ListeController: Controller
{
 public string Liste(int id)
 {
 return $"Parametreden gelen değer:{id}";
 }
 
}
