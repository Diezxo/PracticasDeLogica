using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.Ejercicios
{
    internal class Exercise8
    {
        public static int InverterNum(double x)
        {
            string result;
            x = x * Math.Sign(x);
            char[] inverted = x.ToString().ToCharArray();
            if (x < 0)
            {
                
            }
           
            Array.Reverse(inverted);
            result = new string(inverted);
            return Convert.ToInt32(result);
           
        }

        public static void Print()
        {
            Console.WriteLine($"Tu Numero invertido es {InverterNum(-89)}");
        }
    }
}
