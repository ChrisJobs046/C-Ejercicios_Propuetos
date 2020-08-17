using System;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Numeros multiplos de 3");
            for(numero = 3; numero <=50; numero = numero + 3){
                Console.WriteLine(numero);
            }
            Console.ReadKey();
        }
    }
}
