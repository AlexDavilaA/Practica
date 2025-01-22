using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class Actividad3
    {

        //Imprimir un tablero de damas donde la "X" representa el color negro y el "_" representa el blanco. El tablero debe tener n x n casillas. Por ejemplo, para n=5 el tablero se vería así:



          public static void Act3(string[] args) {

                string negro;
                string blanco;
                int n;

                Console.Write("Ingrese un numero: ");
                n= int.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                negro = "x ";
                blanco = "_ ";

                for (int i = n; i > 0; i--)
                {
                    if (i % 2 != 0)
                    {
                        for (int j = n; j > 0 ; j--)
                        {
                            if (j % 2 != 0)
                            {
                                Console.Write(negro);
                            } else
                            {
                                Console.Write(blanco);
                            }
                        
                        }
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");

                    }
                    else

                    {

                        for (int j = n; j > 0; j--)
                        {
                            if (j % 2 != 0)
                            {
                                Console.Write(blanco);
                            }
                            else
                            {
                                Console.Write(negro);
                            }
                       
                        }
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");

                    }


                }


                Console.Write("");
            Console.ReadKey();
        }

    }
}
