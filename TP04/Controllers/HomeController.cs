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
    public IActionResult InicializarPartida()
    {
        Ahorcado.InicializarPartida();
        ViewBag.palabraMostrar = Ahorcado.ArmarPalabra();
        ViewBag.letrasUsadas = Ahorcado.letrasUsadas;
        ViewBag.intentos = Ahorcado.intentos;
        ViewBag.palabraElegida = Ahorcado.palabraElegida;
        return View("Juego");
    }
    public IActionResult ArriesgarLetra(char c)
    {
       ViewBag.palabraMostrar = Ahorcado.ArriesgarLetra(c);
       ViewBag.letrasUsadas = Ahorcado.letrasUsadas;
       ViewBag.intentos = Ahorcado.intentos;
       ViewBag.palabraElegida = Ahorcado.palabraElegida;
       if (!ViewBag.palabraMostrar.Contains("_"))
       {
            ViewBag.resultado = true;
            return View("Resultado");
       }
       return View("Juego");
    }
    public IActionResult ArriesgarPalabra(string palabra)
    {
       ViewBag.resultado = Ahorcado.ArriesgarPalabra(palabra);
       ViewBag.palabraMostrar = Ahorcado.ArmarPalabra();
       ViewBag.letrasUsadas = Ahorcado.letrasUsadas;
       ViewBag.intentos = Ahorcado.intentos;
       ViewBag.palabraElegida = Ahorcado.palabraElegida;
       return View("Resultado");
    }
}
