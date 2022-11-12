using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.Ejercicios
{
    //Dados dos arrays, devolver los elementos iguales en uno nuevo.
    internal class Exercise9
    {
        public static void Commondproperty(string[] first, string[] second )
        {
            int n = 0;
            if (first.Length < second.Length) n = first.Length;
            if (first.Length > second.Length) n = second.Length;

            string[] commond= new string[n];

            for (int i = 0; i < n; i++)
            {
                commond[i] =first.FirstOrDefault(x => x.Contains(second[i]));
            }
            foreach(var result in commond)
            {
                

                Console.WriteLine(result);
            }
        }

        public static void Print()
        {
            string[] x = { "12", "Hola", "48","Jesus" };
            string[] y = { "Jesus", "12", "Manuel", "Hola", "Mandarina" };
            Commondproperty(x,y);
        }
    }
}