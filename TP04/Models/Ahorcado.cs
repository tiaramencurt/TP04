using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP04.Models
{
    public static class Ahorcado
    {
        public static List<string> palabras { get; private set; }
        public static string palabraElegida { get; private set; }
        public static List<char> letrasUsadas { get; private set; }
        public static int intentos { get; private set; }
        public static void InicializarAhorcado()
        {
            palabras = new List<string>{"caminar", "botella", "maestro", "reunion", "apuntes", "cosecha"};
            Random rnd = new Random();
            palabraElegida = palabras[rnd.Next(0, palabras.Count)];
            letrasUsadas = new List<char>();
            intentos = 0;
        }
        public static char .
        public 
    }
}