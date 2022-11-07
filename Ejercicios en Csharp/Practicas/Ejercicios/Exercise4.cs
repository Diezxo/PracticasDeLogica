using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.Ejercicios
{
    // 4 Dado String, darle la vuelta e invertir su orden sin usar metodos del objeto.
    internal class Exercise4:IExercise
    {
        public static string Inverter(string word)
        {
            string inverted = "";
            foreach(var w in word)
            {
                inverted = w + inverted;
            }

            return inverted;
        }

        public static void Print()
        {
            Console.WriteLine("Que palabra deseas invertir?");
            string word = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(Inverter(word));
        }
    }
}
