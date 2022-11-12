using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.Ejercicios;

//6 Dibujar un cuadrado por consola.
internal class Exercise6
{
    public static string side(int lenght)
    {
        var content = "";

        for(int i = 0; i < lenght; i++)
        {
            content += "*";
        }

        return content;
    }

    public static string GetSquare(int lenght)
    {
        var content = side(lenght) + "\n";

        var draw = "";

        for (int i= 0; i < (lenght - 2); i++)
        {
            draw = "*";
            for(int x = 0; x < (lenght - 2); x++)
            {
                draw += " ";
            }
            draw += "*";

            content += draw + "\n";
        }

        content += side(lenght);
        return content;
    
    }

    public static void Print()
    {
        Console.WriteLine("Write the dimension of you Square");
        int w = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(GetSquare((w)));
    }
}
