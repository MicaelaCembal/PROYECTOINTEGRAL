using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PROYECTOINTEGRAL.Models;

namespace PROYECTOINTEGRAL.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private IWebHostEnvironment Environment;
    
    public HomeController(IWebHostEnvironment environment,ILogger<HomeController> logger)
    {
        Environment=environment;
         _logger = logger;
    }
    public IActionResult Index()
    {
        ViewBag.ListadoSeries = BD.ObtenerSeries();
          ViewBag.ListadoPeliculas = BD.ObtenerPeliculas();
        
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

       public IActionResult AgregarPersonaje(){
        
        return View("AgregarPersonaje");
    }

     public IActionResult UnPersonaje(int IdPersonaje){
       
        ViewBag.UnPersonaje = BD.ObtenerUnPersonaje(IdPersonaje);
        return View("UnPersonaje");
    }


    [HttpPost]
   public IActionResult GuardarPersonaje(int idpersonaje,string nombre, string descripcion, string vestimenta, IFormFile imagen1, IFormFile imagen2, int idPelicula, int idSerie)
    {    
        
        if(imagen1.Length>0) 
            {
                string wwwRootLocal=this.Environment.ContentRootPath + @"\wwwroot\" + imagen1.FileName;
                using(var stream = System.IO.File.Create(wwwRootLocal))
                {
                    imagen1.CopyToAsync(stream);
                }
            }

             if(imagen2.Length>0) 
            {
                string wwwRootLocal=this.Environment.ContentRootPath + @"\wwwroot\" + imagen2.FileName;
                using(var stream = System.IO.File.Create(wwwRootLocal))
                {
                    imagen2.CopyToAsync(stream);
                }
            }
        Personaje personaje = new Personaje(idpersonaje,nombre,descripcion,vestimenta,imagen1.FileName, imagen2.FileName,idPelicula,idSerie);
        BD.AgregarPersonaje(personaje);
        
        return RedirectToAction("TodosLosPersonajes", "Home");
    }

    
    public IActionResult TodosLosPersonajes(){
       
        ViewBag.ListadoPersonajes = BD.ObtenerPersonajesTodos();
        return View("TodosLosPersonajes");
    }

   public IActionResult EliminarPersonaje(int IdPersonaje)
   {
        BD.EliminarPersonaje(IdPersonaje);
        return View ("Index");
    }




}
