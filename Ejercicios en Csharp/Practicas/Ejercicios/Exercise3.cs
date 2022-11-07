using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.Ejercicios
{
     //3 Dada una frase y una palabra, buscar cuantas veces se repite esa frase en dicha palabra.
     //la palabra y la frase se reciben como parametros.
    internal class Exercise3: IExercise
    {
        public static int WordSame(string word, string phrase)
        {
            int result=0;
            string phrase_clean = phrase.ToLower().Replace(",", " ").Replace(".", " ");
           if(phrase_clean.Contains(word))
            {
                var words = phrase_clean.Split(" ");
                foreach(string w in words)
                {
                    if (w == word) { result++; }
                }

            }
            else { result = 0; }

            return result;
        }

        public static void Print()
        {
            Console.WriteLine("Escribe tu parrafo");
            string p = Console.ReadLine();

            Console.WriteLine("Escribe tu palabra a buscar");
            string w = Console.ReadLine();

           Console.WriteLine( $"Numero de Repeticiones que tiene la palabra {w} en tu Parrafo: {WordSame(w, p)}");
        }
    }
}
