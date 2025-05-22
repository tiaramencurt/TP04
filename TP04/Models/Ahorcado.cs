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
		public static bool ganar { get; private set; }
		public static bool perder { get; private set; }
        public static void InicializarPartida()
        {
            palabras = new List<string>{"caminar", "botella", "maestro", "reunion", "apuntes", "cosecha"};
            Random rnd = new Random();
            palabraElegida = palabras[rnd.Next(0, palabras.Count)];
            letrasUsadas = new List<char>();
            intentos = 0;
			ganar = false;
			perder = false;
        }
        public static string ArriesgarLetra(char letra)
        {
            string intentoPalabra = null;
            if(!BuscarLetra(letrasUsadas, letra))
            {
                letrasUsadas.Add(letra);
                intentos++;
                intentoPalabra = ArmarPalabra();
				if(intentoPalabra == palabraElegida)
				{
					ganar = true;
				}
            }
	    return intentoPalabra;
        }
		public static void ArriesgarPalabra(string palabra)
		{
			if(palabra == palabraElegida)
			{
				ganar = true;
			}else{
				perder = true;
			}
		}
        public static string ArmarPalabra()
        {
            string resultado = "";
            foreach (char c in palabraElegida)
            {
                if (letrasUsadas.Contains(c))
                    resultado += c;
                else
                    resultado += "_";
            }
			return resultado;
        }
        public static bool BuscarLetra(List<char> lista, char letra)
        {
            int i = 0;
            bool esta = false;
            while (i < lista.Count && lista[i] != letra)
            {
                i++;
            }
            if(lista[i] != letra)
            {
                esta = true;
            }
            return esta;
        }
    }
}
