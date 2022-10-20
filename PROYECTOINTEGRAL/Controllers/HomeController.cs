using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PROYECTOINTEGRAL.Models;

namespace PROYECTOINTEGRAL.Controllers;

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

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

       public IActionResult AgregarPersonaje(int IdPersonaje){
       
        ViewBag.IdPersonaje = IdPersonaje;
        
        return View("AgregarPersonaje");
    }

    [HttpPost]
   public IActionResult GuardarPersonaje(string nombre, string descripcion, string vestimenta, IFormFile imagen1, IFormFile imagen2, int idPelicula, int idSerie)
    {    
        Personaje personaje = new Personaje(nombre,descripcion,vestimenta,imagen1, imagen2,idPelicula,idSerie);
        BD.AgregarPersonaje(personaje);
        ViewBag.ListadoPersonajes = BD.ObtenerPersonajes();
        return  ("VerPeliculas");
    }
    
    public IActionResult VerPersonajes(){
       
        ViewBag.ListadoPersonajes = BD.ObtenerPersonajes();
        return View("VerPersonajes");
    }
   
   public IActionResult EliminarPersonaje(int IdPersonaje)
   {
        BD.EliminarPersonaje(IdPersonaje);
        return View ("VerPersonajes");
    }




}
