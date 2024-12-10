using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public class Clientes
    {
        Conexion miConexion = new Conexion();
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public byte[] Identificacion { get; set; }
       
        public Clientes(int id, string nombre, string telefonoo, string correo, byte[] identificacion)
        {
            Id = id;
            Nombre = nombre;
            Telefono = telefonoo;
            Correo = correo;
            Identificacion = identificacion;
        }
        public Clientes(string nombre, string telefonoo, string correo, byte[] identificacion)
        {
            Nombre = nombre;
            Telefono = telefonoo;
            Correo = correo;
            Identificacion = identificacion;
        }
        public Clientes() { }


        public void GuardarDB()
        {
            var conexion = miConexion.ObtenerConexion();

            string consulta = "INSERT INTO clientes (Nombre, Numero_telefonico, Correo, Identificacion) VALUES (@Nombre, @Numero_telefonico, @Correo, @Identificacion)";

            using (var comando = new MySqlCommand(consulta, conexion))
            {
                comando.Parameters.AddWithValue("@Nombre", Nombre);
                comando.Parameters.AddWithValue("@Numero_telefonico", Telefono);
                comando.Parameters.AddWithValue("@Correo", Correo);
                comando.Parameters.AddWithValue("@Identificacion", Identificacion);


                comando.ExecuteNonQuery();

                miConexion.CerrarConexion(); // Cerrar la conexión aquí
               
            }
        }
        public bool EliminarClientePorId(int id)
        {
            bool eliminado = false;

            try
            {
                using (MySqlConnection conn = miConexion.ObtenerConexion())
                {
                    string consulta = "DELETE FROM clientes WHERE Id = @Id";
                    using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        int filasAfectadas = cmd.ExecuteNonQuery();
                        eliminado = filasAfectadas > 0;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al eliminar producto: {ex.Message}");
            }
            finally
            {
                miConexion.CerrarConexion();
            }

            return eliminado;
        }
        public bool ActualizarCliente(int id, string nombre, string telefono, string correo, byte[] identificacion)
        {
            string cadenaConexion = "server=localhost;port=3306;database=cooking;user=root;password=;";

            string consulta = "UPDATE clientes SET Id = @Id, Nombre = @Nombre, Numero_Telefonico = @Telefono, Correo = @Correo, Identificacion = @Identificacion " +
                "WHERE Id = @id";

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Id", id);
                        comando.Parameters.AddWithValue("@Nombre", nombre);
                        comando.Parameters.AddWithValue("@Telefono", telefono);
                        comando.Parameters.AddWithValue("@Correo", correo);
                        comando.Parameters.AddWithValue("@Identificacion", identificacion);
                        int filasActualizadas = comando.ExecuteNonQuery();
                        return filasActualizadas > 0;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error de base de datos: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }
        }
            public bool ActualizarClienteSinFoto(int id, string nombre, string telefono, string correo)
            {
                string cadenaConexion = "server=localhost;port=3306;database=cooking;user=root;password=;";

                string consulta = "UPDATE clientes SET Id = @Id, Nombre = @Nombre, Numero_Telefonico = @Telefono, Correo = @Correo " +
                    "WHERE Id = @id";

                try
                {
                    using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                    {
                        conexion.Open();

                        using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                        {
                            comando.Parameters.AddWithValue("@Id", id);
                            comando.Parameters.AddWithValue("@Nombre", nombre);
                            comando.Parameters.AddWithValue("@Telefono", telefono);
                            comando.Parameters.AddWithValue("@Correo", correo);
                            int filasActualizadas = comando.ExecuteNonQuery();
                            return filasActualizadas > 0;
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error de base de datos: {ex.Message}");
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                    return false;
                }
            }
    }
}
