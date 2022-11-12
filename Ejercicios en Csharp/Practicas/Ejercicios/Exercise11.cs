using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Practicas.Ejercicios
{ //Dado un texto y una busqueda, censurar todas las veces que aparece dicha busqueda en el texto con [-CENSURADO-]
    internal class Exercise11
    {
        public static void Censor(string phrase, string word)
        {
            var censored = "[-CENSURADO-]";
          //  phrase = phrase.Replace(",", " ");
          var phrase_censored= phrase.Replace(word,censored);

            Console.WriteLine(phrase_censored);
        }

        public static void Print()
        {
            var x = "Holacoo, Como Estas, Hola Nuevamente.";
            var y = "Hola";
            Censor(x, y);
        }
    }
}
