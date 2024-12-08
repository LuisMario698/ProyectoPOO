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
    public partial class formReservas : Form
    {
        public formReservas()
        {
            InitializeComponent();
        }

        private void formReservas_Load(object sender, EventArgs e)
        {

        }
        private void CargarDatos()
        {
            Conexion miConexion = new Conexion();
            ObtenerDatosHabitaciones obtenerDatos = new ObtenerDatosHabitaciones();

            DataTable dtHabitaciones = obtenerDatos.ObtenerHabitaciones(miConexion);

            // Mostrar los datos en un DataGridView
            dgvReservas.DataSource = dtHabitaciones;
        }
    }
}
