using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class actividad5
    {

        public static void Act5(string connectionString)
        {
            
            string query = @" SELECT nombre, educacion FROM empleados WHERE departamento IN (SELECT departamento FROM empleados GROUP BY departamento HAVING SUM(sueldo) > 25000)";

            try
            {
                
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {                    
                    conexion.Open();
                    
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            Console.WriteLine("Nombre\tEducación");
                            Console.WriteLine("-----------------------");

                            
                            while (reader.Read())
                            {
                                string nombre = reader["nombre"].ToString();
                                string educacion = reader["educacion"].ToString();

                                // Mostrar resultados en consola
                                Console.WriteLine($"{nombre}\t{educacion}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}
