using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Practicas.Ejercicios;

//2 Dada una cadena de texto, comprobar si la frase es un palindromo o no.
//Los Palindromos son enunciados que se leen al reves y al derecho.
internal class Exercise2 : IExercise
{

    public static string Palindromo(string wordtocompare)
    {
        var inverter = wordtocompare.ToCharArray();
        Array.Reverse(inverter);

        string WordInverted= new string(inverter);
        var result = WordInverted == wordtocompare;

        string word;
        if (result)
        {
            word = "Si es Palindromo";
        }
        else
        {
            word = "No es Palindromo ";
        };

        return word;
    }
    public static void Print()
    {
        Console.WriteLine("Que Palabra deseas evaluar?");
        string? x = Console.ReadLine();

        Console.WriteLine($"Resultado: {Palindromo(x)}");
    }

}



