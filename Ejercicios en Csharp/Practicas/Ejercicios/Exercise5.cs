using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.Ejercicios;

// 5 Cuanto es el X% de x numero?
internal class Exercise5: IExercise
{
    public static double GetPorcent(decimal Porcent, double Value)
    {
        Porcent /= 100;
        var result = ((double)Porcent) * Value;

        return result;
    }

    public static void Print()
    {
        Console.WriteLine("Escribe tu valor");
        double v = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Que Porcentaje deseas obtener de {v}?: ");
        decimal p = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine($"El {p}% de {v} es {GetPorcent(p, v)}.");
    }
}
