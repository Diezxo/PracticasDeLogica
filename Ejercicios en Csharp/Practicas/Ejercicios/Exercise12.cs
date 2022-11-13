using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.Ejercicios
{    //Dado un numero, devolver una secuencia de 8 en 8 hasta llegar a 0, cada numero debe mostrar - #
    internal class Exercise12
    {
        public static void Secuency(int index)
        {
            Console.WriteLine($"Del {index} al 0 en intervalos de 8");
            int by = 8;
            for (int i = index; i > 0; i-=by)
            {
                Console.WriteLine($"- #{i}");
            }
        }
        public static void Print()
        {
            Secuency(654);
        }
    }
}
