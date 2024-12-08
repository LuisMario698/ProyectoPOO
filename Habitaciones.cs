using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Habitaciones
    {
        public class ObtenerDatosHabitaciones
        {
            public DataTable ObtenerHabitaciones(Conexion miConexion)
            {
                DataTable dtHabitaciones = new DataTable();

                try
                {
                    if (miConexion.AbrirConexion())
                    {
                        // Crear la consulta SQL
                        string consulta = "SELECT * FROM habitaciones";

                        // Crear un comando MySQL
                        MySqlCommand cmd = new MySqlCommand(consulta, miConexion.ObtenerConexion());

                        // Crear un adaptador de datos
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                        // Llenar el DataTable con los datos de la consulta
                        adapter.Fill(dtHabitaciones);

                        // Cerrar la conexión
                        miConexion.CerrarConexion();
                    }
                }
                catch (Exception ex)
                {
                    // Manejar el error, por ejemplo, mostrar un mensaje de error
                    System.Windows.Forms.MessageBox.Show("Error al obtener los datos de las habitaciones: " + ex.Message);
                }

                return dtHabitaciones;
            }
        }
    }
}
