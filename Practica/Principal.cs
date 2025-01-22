using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;


namespace Practica
{
    internal class Principal
    {
        static void Main(string[] args)
        {
            // Leer la cadena de conexión desde App.config
            string connectionString = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;

            // Crear conexión
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    // Abrir conexión
                    conexion.Open();
                    Console.WriteLine("Conexión exitosa a la base de datos");

                    // Realizar operaciones aquí
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }


            //Actividad1.Act1(args);
            //Actividad2.Act2(args);
            //Actividad3.Act3(args);
            //actividad_4.Actividad4(args);

            

            actividad5.Act5(connectionString);


        }

    }
}
