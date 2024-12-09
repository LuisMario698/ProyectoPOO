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
        Habitaciones habitaciones;
        public formHabitaciones()
        {
            InitializeComponent();

            habitaciones = new Habitaciones();
            ConfigurarDataGridView();
            CargarDatosHabitaciones();
            InitializeComboBoxes();
        }
        private void InitializeComboBoxes()
        {
            // Llenar el ComboBox de Tipo con opciones predefinidas
            cmbTipo.Items.Add("Estandar");
            cmbTipo.Items.Add("Suite");
            cmbTipo.Items.Add("Deluxe");

            // Llenar el ComboBox de Estado con opciones predefinidas
            cmbEstado.Items.Add("Disponible");
            cmbEstado.Items.Add("Ocupada");
            cmbEstado.Items.Add("En Limpieza");
        }
        // Configuración inicial del DataGridView
        private void ConfigurarDataGridView()
        {
            dgvHabitaciones.ColumnCount = 4;
            dgvHabitaciones.Columns[0].Name = "Tipo";
            dgvHabitaciones.Columns[1].Name = "Estado";
            dgvHabitaciones.Columns[2].Name = "Número";
            dgvHabitaciones.Columns[3].Name = "Precio";
            dgvHabitaciones.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvHabitaciones.ColumnHeadersHeight = 40;
        }

        // Método para cargar datos en el DataGridView
        private void CargarDatosHabitaciones()
        {
            try
            {
                dgvHabitaciones.Rows.Clear();
                DataTable dt = habitaciones.ObtenerHabitaciones();
                foreach (DataRow row in dt.Rows)
                {
                    dgvHabitaciones.Rows.Add(row["Tipo"], row["Estado"], row["Numero"], row["Precio"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }
        private void formHabitaciones_Load(object sender, EventArgs e)
        {

        }

        private void dgvHabitaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar si se seleccionaron opciones en los ComboBox
                if (cmbTipo.SelectedItem == null || cmbEstado.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un tipo y un estado para la habitación.");
                    return;
                }

                // Validar campos numéricos
                if (!int.TryParse(txtNumero.Text, out int numero))
                {
                    MessageBox.Show("El número de la habitación debe ser un valor numérico.");
                    return;
                }

                if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
                {
                    MessageBox.Show("El precio debe ser un valor numérico.");
                    return;
                }

                string tipo = cmbTipo.SelectedItem.ToString();
                string estado = cmbEstado.SelectedItem.ToString();

                if (habitaciones.AgregarHabitacion(tipo, estado, numero, precio))
                {
                    MessageBox.Show("Habitación agregada correctamente");
                    CargarDatosHabitaciones();
                }
                else
                {
                    MessageBox.Show("Error al agregar la habitación. Verifique los datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al agregar la habitación: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar si el número de la habitación es un valor numérico
                if (!int.TryParse(txtNumero.Text, out int numero))
                {
                    MessageBox.Show("El número de la habitación debe ser un valor numérico.");
                    return;
                }

                if (habitaciones.EliminarHabitacion(numero))
                {
                    MessageBox.Show("Habitación eliminada correctamente");
                    CargarDatosHabitaciones();
                }
                else
                {
                    MessageBox.Show("Error al eliminar la habitación. Verifique el número de habitación.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al eliminar la habitación: " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar si se seleccionaron opciones en los ComboBox
                if (cmbTipo.SelectedItem == null || cmbEstado.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un tipo y un estado para la habitación.");
                    return;
                }

                // Validar campos numéricos
                if (!int.TryParse(txtNumero.Text, out int numero))
                {
                    MessageBox.Show("El número de la habitación debe ser un valor numérico.");
                    return;
                }

                if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
                {
                    MessageBox.Show("El precio debe ser un valor numérico.");
                    return;
                }

                string tipo = cmbTipo.SelectedItem.ToString();
                string estado = cmbEstado.SelectedItem.ToString();

                if (habitaciones.ModificarHabitacion(tipo, estado, numero, precio))
                {
                    MessageBox.Show("Habitación modificada correctamente");
                    CargarDatosHabitaciones();
                }
                else
                {
                    MessageBox.Show("Error al modificar la habitación. Verifique los datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al modificar la habitación: " + ex.Message);
            }
        }
    }
}
