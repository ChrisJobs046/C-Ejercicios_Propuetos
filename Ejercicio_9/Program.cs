using System;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 26;
            while(i <=10){


                if(i % 2==0){
                    i--;
                }
                Console.Write(i);
            }
            Console.ReadKey();
        }
        
    }
}
