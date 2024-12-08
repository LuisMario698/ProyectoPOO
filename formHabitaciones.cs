using MaterialSkin;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Proyecto.Habitaciones;
using static ReaLTaiizor.Controls.HopeTabPage;

namespace Proyecto
{
    public partial class formHabitaciones : Form
    {
        Conexion miConexion;
        public formHabitaciones()
        {
            InitializeComponent();

            dgvHabitaciones.ColumnCount = 3;
            dgvHabitaciones.Columns[0].Name = "Tipo";
            dgvHabitaciones.Columns[1].Name = "Estado";
            dgvHabitaciones.Columns[2].Name = "Numero";

            dgvHabitaciones.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvHabitaciones.ColumnHeadersHeight = 40;

            

            //CargarDatos();
        }

        private void formHabitaciones_Load(object sender, EventArgs e)
        {

        }
        /*
        private void CargarDatos()
        {
            miConexion = new Conexion();
            try
            {
                string tipo = "";
                string estado = "";
                int numero;

                MySqlDataReader mySqlDataReader = null;
                string consulta = "select * from habitaciones";

                if (miConexion.ObtenerConexion() != null)
                {
                    MySqlCommand mySqlCommand = new MySqlCommand(consulta, miConexion.ObtenerConexion());
                    mySqlDataReader = mySqlCommand.ExecuteReader();

                    while (mySqlDataReader.Read())
                    {
                        tipo = mySqlDataReader.GetString("Tipo");
                        estado = mySqlDataReader.GetString("Estado");
                        numero = mySqlDataReader.GetInt32("Numero");
                        dgvHabitaciones.Rows.Add(tipo, estado, numero);
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
        */
    }
}
