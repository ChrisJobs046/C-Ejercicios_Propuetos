using System;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;

            Console.Write("Los numeros del 1 al 10");

            do{

                if(numero == 0){
                    numero++;
                }
                
            }while(numero > 11);
            Console.WriteLine(numero);
            Console.ReadKey();
            
        }
    }
}
