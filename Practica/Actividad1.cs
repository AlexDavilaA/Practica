using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class Actividad1
    {
        public static void Act1(string[] args)
        {

            Console.WriteLine("hola mundo");

            int[] miarray = new int[5];
            int numero;

            Console.Write("introduce el numero que quieres agregar: ");

            //foreach (int vuelta in miarray)
            //{
            //    numero = int.parse(Console.readLine());
            //    vuelta = numero;
            //}


            for (int i = 0; i < miarray.Length; i++)
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
                        Console.WriteLine("favor de introducir un numero valido: ");
                    }

                } while (numero < 0 || numero > 100);



                miarray[i] = numero;
            }

            foreach (int imprimir in miarray)
            {
                Console.Write(imprimir + " ");
            }


            Console.ReadKey();


        }
    }
}
