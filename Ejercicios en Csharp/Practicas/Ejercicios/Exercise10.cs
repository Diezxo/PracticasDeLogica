using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.Ejercicios
{ // Dado un numero, mostrar una escalera con escalones de "{-}", usando el  numero para los niveles de la escalera.
    internal class Exercise10
    {
        public static void Stair(int size)
        {
            for (int i = 0; i <= size; i++)
            {
                var escalon = "";
                for (int x = 1; x <= i; x++)
                {
                    escalon += $"[{x}]";
                }

                Console.WriteLine(escalon);
            }
        }
        
        public static void Print()
        {
            int x = 11;
            Stair(x);
        }
    }
}
