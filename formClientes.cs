using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Proyecto.Habitaciones;

namespace Proyecto
{
    public partial class formClientes : Form
    {
        Conexion miConexion;
        public formClientes()
        {
            InitializeComponent();
            dgvClientes.ColumnCount = 4;
            dgvClientes.Columns[0].Name = "Id";
            dgvClientes.Columns[1].Name = "Nombre";
            dgvClientes.Columns[2].Name = "Numero Telefonico";
            dgvClientes.Columns[3].Name = "Correo Electronico";

            dgvClientes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvClientes.ColumnHeadersHeight = 40;

            CargarDatos();
        }

        private void btnHabitaciones_Click(object sender, EventArgs e)
        {
            formHabitaciones habitaciones = new formHabitaciones();
            habitaciones.ShowDialog();
        }

        private void formClientes_Load(object sender, EventArgs e)
        {

        }

        private void CargarDatos()
        {
            miConexion = new Conexion();
            try
            {
                int id;
                string nombre = "";
                int telefono;
                string correo = "";

                MySqlDataReader mySqlDataReader = null;
                string consulta = "select * from clientes";

                if (miConexion.ObtenerConexion() != null)
                {
                    MySqlCommand mySqlCommand = new MySqlCommand(consulta, miConexion.ObtenerConexion());
                    mySqlDataReader = mySqlCommand.ExecuteReader();

                    while (mySqlDataReader.Read())
                    {
                        id = mySqlDataReader.GetInt32("Id");
                        nombre = mySqlDataReader.GetString("Nombre");
                        telefono = mySqlDataReader.GetInt32("Numero_telefonico");
                        correo = mySqlDataReader.GetString("Correo");
                        dgvClientes.Rows.Add(id, nombre, telefono, correo);
                    }
                }
                else
                {
                    MessageBox.Show("Error al conectar");
                }
            }
            catch (MySqlException m)
            {
                MessageBox.Show(m.Message);
            }
            

        }
    }
}
