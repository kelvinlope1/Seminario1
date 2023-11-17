using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenamientSelecion
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
            for (int i = 0; i < lista.Length - 1; i++)
            {
                
                int IndMinim = i;
                for (int j = i + 1; j < lista.Length; j++)
                {
                    // Intercambiar el elemento mínimo con el primer elemento de la parte desordenada
                    if (lista[j] < lista[IndMinim])
                    {
                        temporal = lista[j];
                        lista[j] = lista[IndMinim];
                        lista[IndMinim] = temporal;
                    }

                }
                //muestra el proceso de Selecion
               //Mostrar();

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
