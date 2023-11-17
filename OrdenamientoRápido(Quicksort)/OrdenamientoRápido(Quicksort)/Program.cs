using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OrdenamientoRápido_Quicksort_
{
    internal class Program
    {
        static int[] lista = { 6, 8, 4, 2, 7, 9, 5, 3, 1 };
        static void Main(string[] args)
        {
            
            Console.WriteLine("Lista deSordenada");
            Mostrar();

            Console.WriteLine("Lista Ordenada");
            Quicksort(0, lista.Length - 1) ;

            Mostrar();
        

        }

        //metodo para instercambiar los elementos
        private static void Intercambio(int k1, int k2)
        {
           int temporal = lista[k1];
            lista[k1] = lista[k2];
            lista[k2] = temporal;
        }
        static int Particion(int pIni, int pFin)
        {

            // el elemento en la posición alta
            int high = 0;
            //indece del elemento con la posicion mas baja
            int indabaj = 0;
            int n = 0;
            //selecionamos el ultimo como high
            high = lista[pFin];
            //ponemos El indece abaj como el indece de inicio
            indabaj = pIni;
            //recorremos la lista
            for (n = pIni; n < pFin; n++)
            {

              
                // Si el elemento actual es menor o igual al high
                if (lista[n] <= high)
                {
                    //Intercambiamos El elemento En n con el que se encuentra el en indece
                    Intercambio(n, indabaj);
                    indabaj++;

                    
                }
            }
            //hacemos el intercambio del Pfin para colocar el high donde corresponde
            Intercambio(indabaj, pFin);

            return indabaj;

        }
        public static void Quicksort(int pIni, int pFin) 
         
            {
            int Indabaj = 0;
            //esta funcion es para cuando haga solo un elemento o cuando del lado se que se va a intercambiar esta vacio
            if (pIni >= pFin)
                return;
           
            Indabaj=Particion(pIni, pFin);

            // Ordena los elementos a la izquierda y a la derecha del ultimo elemento de la lista
            Quicksort(pIni,  Indabaj - 1);
            Quicksort(Indabaj + 1, pFin);
           

        }
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
