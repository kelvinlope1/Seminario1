using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenamientoBurbuja
{
    internal class Program
    {
        static int[] lista = new int[] { 6, 8, 4, 2, 7, 9, 5, 3, 1 };
        static void Main(string[] args)
        {
            int temporal = 0;
            int IntExternas = 0;
            int IntInternas = 0;
            
            Console.WriteLine("Lista deSordenada");
            Mostrar();
            //hace un recorrido por todos los elementos analizando dependiento su longitud


            for (int i = 0; i < lista.Length - 1; i++)

            {
                IntExternas++;
                //va Comparando de cual es mayor o menor para hacer el intercambio

                for (int j = 0; j < lista.Length- i- 1; j++)

                {
                    IntInternas++;
                    //analiza si el elemento siguiente es mayor que el actual loque hace es que lo va intercambiando por el elementos siguiente   
                    if (lista[j] > lista[j + 1])
                    {
                        temporal = lista[j];
                        lista[j] = lista[j + 1];
                        lista[j + 1] = temporal;

                    }
                   // Mostrar();
                }
            }
            Console.WriteLine("Lista Ordenada:");
            Mostrar();
             Console.Write("Interasiones Externas:" + IntExternas + "\n");
             Console.Write("Interasiones Internas:" + IntInternas + "\n");




        }

        //Este metodo es utilizado para Mostrar la lista en la consola
        public static void Mostrar()
        {
            foreach (var l in lista)
            {
                Console.Write(l + ",");
            }
            Console.WriteLine("\n");
        }
    }
}
