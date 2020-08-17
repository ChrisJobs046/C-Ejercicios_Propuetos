using System;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            while(i >26){
                if(i % 2==0){
                    i--;
                }
            }
            Console.WriteLine(i);
            Console.ReadKey();
        }
        
    }
}
