using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public class Conexion
    {
        private MySqlConnection conexion;
        public string cadenaConexion = $"Server=localhost;Database=cooking;Uid=root;Pwd=;";

        public MySqlConnection ObtenerConexion()
        {
            if (conexion == null)
            {
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
            }
            return conexion; // Devuelve la conexión sin abrirla
        }

        public bool AbrirConexion()
        {
            try
            {
                return true;
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
                return false;
            }
        }

        public bool CerrarConexion()
        {
            try
            {
                conexion.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al cerrar la conexión a la base de datos: " + ex.Message);
                return false;
            }
        }
    }

}
