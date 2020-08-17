using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra;
            bool  vocal;

            Console.WriteLine("introduzca una letra");
            letra = Convert.ToChar(Console.ReadLine());

            vocal = (letra == 'a') || (letra == 'e') || (letra == 'i') || (letra == 'o') || (letra == 'u');

            if(vocal){
                Console.WriteLine("es una vocal!!!");
            }
            else{
                Console.WriteLine("es una consonante");
            }
            Console.ReadKey();

        }
    }
}
