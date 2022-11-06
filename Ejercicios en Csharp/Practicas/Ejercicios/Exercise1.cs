using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Practicas.Ejercicios
{
    // 1 Dado un numero, devolver su tabla de multiplicar completa.
    public class Exercise1 : IExercise
    {
        static int Result;
        static string? table;
        static int n;
        public static void Multiply(int Ntable)
        {
            Console.WriteLine("Cuantas veces deseas multiplicar");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"  Tabla del {Ntable}");
            Console.WriteLine("-----------------");
            for (int i = 1; i <= n; i++)
            {
                Result = Ntable * i;
                table = ($"| {Ntable} x {i} = {Result}   |" );
                Console.WriteLine(table);

            }
            Console.WriteLine("-----------------");
        }

        public static void Print()
        {
            Console.WriteLine("Escribe un numero para multplicar");
            int Ntable = Convert.ToInt32(Console.ReadLine());

            Multiply(Ntable);
        }
    }
}
