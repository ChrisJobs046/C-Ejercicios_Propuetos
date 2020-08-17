using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Ejercicio_16
{
    class Program
    {
        private int[] sueldos;
        public void Cargar(){
            sueldos = new int[5];
            for(int i = 0; i < sueldos.Length; i++){

                Console.Write("Ingrese el sueldo deseado: ");
                string linea = Console.ReadLine();
                sueldos[i] = int.Parse(linea);
            }
        }

        public void Ordenar(){

            for (int v = 0; v < 4; v++){

                for( int i = 0; i < 4 - v; i++){

                    if(sueldos[i] > sueldos[i + 1]){

                        int ay;
                        ay = sueldos[i];
                        sueldos[i] = sueldos[i + 1];
                        sueldos[i + 1] = ay;
                    }
                }
            }
        }

        public void Mostrar(){

            Console.WriteLine("Sueldos ordenados");
            for(int  i = 0; i < sueldos.Length; i++){
                Console.WriteLine(sueldos[i]);
            }
            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            Vector v = new Vector();
            v.Cargar();
            v.Ordenar();
            v.Mostrar();
        }
    }
}
