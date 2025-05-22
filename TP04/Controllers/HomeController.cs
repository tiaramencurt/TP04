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
        ViewBag.palabra = Ahorcado.ArmarPalabra();
        ViewBag.letrasUsadas = Ahorcado.letrasUsadas;
        ViewBag.intentos = Ahorcado.intentos;
		ViewBag.Ganar = Ahorcado.ganar;
        ViewBag.Perder = Ahorcado.perder;
        return View("Juego");
    }
	[HttpPost]
	public IActionResult IngresarLetra(char letra)
    {
        ViewBag.palabra = Ahorcado.ArriesgarLetra(letra);
        ViewBag.letrasUsadas = Ahorcado.letrasUsadas;
        ViewBag.intentos = Ahorcado.intentos;
		ViewBag.Ganar = Ahorcado.ganar;
        ViewBag.Perder = Ahorcado.perder;
        return View("Juego");
    }
	[HttpPost]
        public IActionResult IngresarPalabra(string palabraArriesgar)
        {
            Ahorcado.ArriesgarPalabra(palabraArriesgar);
			ViewBag.Palabra = Ahorcado.ArmarPalabra();
            ViewBag.Intentos = Ahorcado.intentos;
            ViewBag.LetrasUsadas = Ahorcado.letrasUsadas;
            ViewBag.Ganar = Ahorcado.ganar;
            ViewBag.Perder = Ahorcado.perder;
            return View("Resultado");
        }
}
