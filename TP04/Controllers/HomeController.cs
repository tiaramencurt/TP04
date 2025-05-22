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
        return View("Juego");
    }
    public IActionResult ArriesgarLetra(char c)
    {
       ViewBag.palabraMostrar = Ahorcado.ArriesgarLetra(c);
       ViewBag.letrasUsadas = Ahorcado.letrasUsadas;
       ViewBag.intentos = Ahorcado.intentos;
       if (!ViewBag.palabraMostrar.Contains("_"))
       {
            ViewBag.mensaje = "Ganaste";
            return View("Resultado");
       }
       return View("Juego");
    }
    public IActionResult ArriesgarPalabra(string palabra)
    {
       ViewBag.Resultado = Ahorcado.ArriesgarPalabra(palabra);
       ViewBag.PalabraMostrar = Ahorcado.ArmarPalabra();
       ViewBag.letrasUsadas = Ahorcado.letrasUsadas;
       ViewBag.intentos = Ahorcado.intentos;
       return View("Resultado");
    }
}
