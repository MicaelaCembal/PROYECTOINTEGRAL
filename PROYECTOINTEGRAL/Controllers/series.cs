using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PROYECTOINTEGRAL.Models;

namespace PROYECTOINTEGRAL.series;

public class series : Controller
{
    private readonly ILogger<series> _logger;

    public series(ILogger<series> logger)
    {
        _logger = logger;
    }

    public Serie TraeInfoSerie(int idSerie)
    {
        Serie seerie= BD.ObtenerUnaSerie(idSerie);
         return seerie;
    }


}