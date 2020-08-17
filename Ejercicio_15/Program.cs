using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Ejercicio_15
{
    class Program
    {
        private int[] vec;
        private int menor;
        
        public void Cargar(){
            Console.Write("Cuantos elementos desea cargar: ");
            string linea;
            linea = Console.ReadLine();
            int n = int.Parse(linea);
            vec = new int[n];
            for(int i =0; i < vec.Length; i++){
                Console.Write("Ingrese el componente : ");
                linea = Console.ReadLine();
                vec[i]= int.Parse(linea);
            }
        }

        public void MenorElemento(){
            menor= vec[0];
            for(int i=1; i< vec.Length; i++){

                if(vec[i] < menor){
                    menor = vec[i];
                }
            }
            Console.WriteLine("El elemento menor es:"+menor);
        }

        public void RepiteMenor(){
            int cant = 0;
            for(int i=0; i < vec.Length; i++){

                if(vec[i] == menor){
                    cant++;
                }
            }
            if(cant > 1){
                Console.WriteLine("No se repite el menor en el vector.");
            }
            else{
                Console.WriteLine("No se repite el menor en el vector");

            }
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Program P = new Program();
            P.Cargar();
            P.MenorElemento();
            P.RepiteMenor();
        }
    }
}
