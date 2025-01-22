using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class actividad_4
    {
        public static void Actividad4(string[] args)
        {
            //PROBLEMA 4
            //Escribir un programa utilizando javascript que encuentre los dos elementos del arreglo que sumados dan 10. Se deben imprimir ambos números como resultado separados por un espacio (en el orden en que aparecen en el arreglo).

            List<int> numeros = new List<int>();
            List<string> Combinaciones = new List<string>();

            Console.Write("Ingrese el largo del arreglo: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("iNTRODUCZA LOS NUMEROS : ");

            for (int i = 0; i < n; i++)
            {

                numeros.Add(int.Parse(Console.ReadLine()));

            }
            Console.WriteLine(" ");

            for (int i =0; i  < n; i++)
            {
                int valor = numeros[i];

                for (int j = (i+1); j < n; j++)
                {
                    int valorC = numeros[j]; 

                    if (valor + valorC == 10)
                    {
                        Combinaciones.Add($"La suma de {valor} y {valorC} dan 10");
                    }
                    

                }
            }

            
            foreach (string combinacion in Combinaciones)
            {
                Console.WriteLine(combinacion);
            }

            //foreach (int num in numeros)
            //{
            //    Console.Write(num + " ");
            //}
            Console.ReadKey();
        }

    }
}
