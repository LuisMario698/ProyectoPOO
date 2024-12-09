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
    public partial class formPagos : Form
    {
        private Habitaciones habitaciones;

        public formPagos()
        {
            InitializeComponent();
            habitaciones = new Habitaciones();
        }

        private void formPagos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void CargarDatos()
        {
            try
            {
                // Obtener los datos de habitaciones
                DataTable dtHabitaciones = habitaciones.ObtenerHabitaciones();

                // Mostrar los datos en el DataGridView
                dgvPagos.DataSource = dtHabitaciones;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de las habitaciones: " + ex.Message);
            }
        }
    }
}
