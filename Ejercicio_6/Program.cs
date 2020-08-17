using System;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2;

            Console.WriteLine("Ingrese el primer numero");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero");
            numero2 = Convert.ToInt32(Console.ReadLine());

            if(numero1 != 0 ){
                Console.Write("Uno de los numeros es positivo");
            }
            else if(numero1 > 0 | numero2 > 0){
                Console.Write("Los dos numeros son positivos");
            }
            else{
                Console.Write("Ninguno de los numeros es positivo");
            }
        }
    }
}
