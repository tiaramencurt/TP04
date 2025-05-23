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
        public static void InicializarPartida()
        {
            palabras = new List<string>{"caminar", "botella", "maestro", "reunion", "apuntes", "cosecha", "enlacez", "pintura", "alegría", "hogares",
"montaña", "clasear", "esquema", "lectura", "visitas", "cuartos", "esferas", "calamar", "rescate", "bailaba",
"nervios", "verdura", "tortuga", "aviones", "charlar", "pensado", "guitarra", "cuidaba", "amistad", "viajero",
"cultura", "alcance", "retozar", "esperar", "cálculo", "rompido", "aliento", "soldado", "cuento", "cartón",
"volaban", "mirador", "dejaban", "reflejo", "crianza", "afectar", "rosario", "soltera", "mandato", "ayudaba"};
            Random rnd = new Random();
            palabraElegida = palabras[rnd.Next(0, palabras.Count)];
            letrasUsadas = new List<char>();
            intentos = 0;
        }
        public static string ArriesgarLetra(char letra)
        {
            string intentoPalabra = null;
            letra = Char.ToLower(letra);
            if(!letrasUsadas.Contains(letra))
            {
                letrasUsadas.Add(letra);
                intentos++;
            }
            intentoPalabra = ArmarPalabra();
	    return intentoPalabra;
        }
		public static bool ArriesgarPalabra(string palabra)
		{
            return palabra.ToLower() == palabraElegida;
		}
        public static string ArmarPalabra()
        {
            string resultado = "";
            foreach (char c in palabraElegida)
            {
                if (letrasUsadas.Contains(c))
                {
                    resultado += c;
                }
                else
                {
                    resultado += "_";
                }
            }
			return resultado;
        }
    }
}
