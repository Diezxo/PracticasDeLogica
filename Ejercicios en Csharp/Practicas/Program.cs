

//Dado un numero, devolver su tabla de multiplicar completa.


/// Main
/// 


Console.WriteLine("Escribe un numero");
int Ntable = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Hasta que numero deseas la tabla");
int max= Convert.ToInt32(Console.ReadLine());
int Result; ;

Console.Clear();
Console.WriteLine($">>>  Tabla del {Ntable}  <<<");
for (int i = 1; i < max; i++)
{
    Result= Ntable*i;
    Console.WriteLine($"     >>{Ntable}x{i}={Result}");
}