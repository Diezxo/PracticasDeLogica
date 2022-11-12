using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.Ejercicios;

// 7 Dado dos numeros, devolver cuantos numeros impares hay entre ellos.
internal class Exercise7
{
   static int diference { get; set; }
    public static int OddNumber(int a, int b)
    {
        if (a > b) diference = a - b;
        if (a < b) diference = b - a;
        int result=0;
        for(int i=diference; i>0; i--)
        {
            if (i % 2 != 0)
            {
                result++;
            }

        }

        return result;
    }

    public static void Print()
    {
        Console.WriteLine(OddNumber(2, 1));
    }
}
