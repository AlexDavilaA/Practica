using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class Actividad2
    {
        public static void Act2(string[] args)
        {




            int[] miArray = new int[10];
            int numero;
            int contador = 1;
            int valor = 0;
            Verificacion masRepetido = null;

            List<Verificacion> verificaciones = new List<Verificacion>();


            Console.Write("introduce el numero que quieres agregar: ");

            //foreach (int vuelta in miArray)
            //{
            //    numero = int.Parse(Console.ReadLine());
            //    vuelta = numero;
            //}


            for (int i = 0; i < miArray.Length; i++)
            {
                if (i == 0)
                {
                    Console.Write("introduce el numero que quieres agregar: ");
                }
                do
                {
                    numero = int.Parse(Console.ReadLine());


                    if (numero < 0 || numero > 100)
                    {
                        Console.WriteLine("Favor de introducir un numero valido: ");
                    }

                } while (numero < 0 || numero > 100);

                miArray[i] = numero;


            }


            for (int i = 0; i < miArray.Length; i++)
            {

                if (i != 0)
                {
                    if (miArray[i] == miArray[i - 1])
                    {
                        valor = miArray[i];
                        contador++;

                    }
                    else
                    {
                        if (contador > 0)
                        {
                            verificaciones.Add(new Verificacion { Valor = valor, Contador = contador });
                        }

                        valor = miArray[i];
                        contador = 1;


                    }


                    Console.Write(miArray[i] + " ");
                }
                else
                {

                    valor = miArray[i];
                    contador = 1;
                    Console.Write(miArray[i] + " ");
                }


            }

            foreach (Verificacion verificacion in verificaciones)
            {
                if (masRepetido == null || verificacion.Contador > masRepetido.Contador)
                {
                    masRepetido = verificacion;
                }
            }

            // Imprime el resultado
            if (masRepetido != null)
            {
                Console.WriteLine("\nEl número más repetido es " + masRepetido.Valor + " con " + masRepetido.Contador + " repeticiones");
            }
            else
            {
                Console.WriteLine("\nNo hay números repetidos.");
            }



            foreach (int imprimir in miArray)
            {
                Console.Write(imprimir + " ");
            }


            Console.ReadKey();


        }
    }
}
