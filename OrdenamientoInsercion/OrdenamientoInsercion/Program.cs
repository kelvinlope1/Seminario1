using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenamientoInsercion
{
    internal class Program
    {
        static int[] lista = new int[] { 6, 8, 4, 2, 7, 9, 5, 3, 1 };
        static void Main(string[] args)
        {
            Console.WriteLine("Lista desordenada");

            Mostrar();
            Console.WriteLine("Lista Ordenada:");
            int temporal = 0;
          
            //hace un recorrido por todos los elementos analizando dependiento su longitud
            
            {


                for (int i = 1; i < lista.Length; i++)
                {
                    temporal = lista[i];
                   int j = i-1;
                    // mueve los elementos de la lista que son mayores que el elemento temporal a una posicion adelante
                    while ((j >= 0) && (lista[j] > temporal) )
                    {
                        lista[j + 1] = lista[j];    
                        j--;
                        
                    }
                    lista[j + 1] = temporal;
                  
                }
                

            }
            Mostrar();


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
