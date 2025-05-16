using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP04.Models;

namespace TP04.Controllers;

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
    public IActionResult Partida()
    {
        Ahorcado.InicializarAhorcado();
        ViewBag.palabra = Ahorcado.palabraElegida;
        ViewBag.letrasUsadas = Ahorcado.letrasUsadas;
        ViewBag.intentos = Ahorcado.intentos;
        return View("");
    }
}
