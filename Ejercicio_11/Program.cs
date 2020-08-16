using System;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 26;
            do{
                if(numero % 2 == 0){
                    Console.WriteLine(numero);
                }
                numero = numero -1;
            }while(numero > 8);
            Console.ReadKey();
        }
    }
}
