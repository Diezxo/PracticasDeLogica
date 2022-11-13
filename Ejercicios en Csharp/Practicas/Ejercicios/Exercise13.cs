using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.Ejercicios
{   
    /// <summary>
/// Dado un array, devolver tantos sub arrays como se nos indique mediante un indice
/// </summary>
    internal class Exercise13
    {

        public static void Divide(int[] principal, int index)
        {

           var secundary= principal.Chunk(index);

            foreach(var indi in secundary)
            {
                Console.WriteLine(indi);
            }
        }
        public static void Print()
        {
            int[] x = { 4, 56, 3, 7, 3, 7, 3 };
            Divide(x, 2);
        }
    }
}
