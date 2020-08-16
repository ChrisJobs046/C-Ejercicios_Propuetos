using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2; string resultado; double resultF;
            
            Console.WriteLine("Ingrese 2 numeros!!!");
            Console.Write("Primer Numero :");
            resultado = Console.ReadLine();
            numero1 = int.Parse(resultado);
            Console.Write("Segundo numero :");
            resultado = Console.ReadLine();
            numero2 = int.Parse(resultado);
            resultF = numero1 / numero2;
            Console.WriteLine("La division es: "+ resultF);
            resultF = numero1 % numero2; Console.WriteLine("EL RESIDUO ES: "+ resultF);
            Console.ReadLine();
        }
    }
}
