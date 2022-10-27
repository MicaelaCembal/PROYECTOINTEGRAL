using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PROYECTOINTEGRAL.Models;

namespace PROYECTOINTEGRAL.peliculas;

public class peliculas : Controller
{
    private readonly ILogger<peliculas> _logger;

    public peliculas(ILogger<peliculas> logger)
    {
        _logger = logger;
    }

    public Pelicula TraeInfoPeli(int idPelicula)
    {
        Pelicula Peli= BD.ObtenerUnaPelicula(idPelicula);
         return Peli;
    }


}
