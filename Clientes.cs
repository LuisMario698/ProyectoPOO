using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Clientes
    {
        Conexion miConexion;
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


        public void GuardarDB()
        {

            miConexion = new Conexion();
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
    }
}
