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
        public static void Jugar(char letra)
        {
            if(!BuscarLetra(letrasUsadas, letra))
            {
                letrasUsadas.Add(letra);
                intentos++;
                string intentoPalabra = ArmarPalabra();
                
            }
        }
        public static string ArmarPalabra()
        {
            for (int i = 0; i < palabraElegida.Length; i++)
            {
                palabraElegida.Contains(letra);
            }
        }
        public static 
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