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
        public Habitaciones habitaciones;
        Conexion miConexion;
        public formHabitaciones()
        {
            InitializeComponent();

            habitaciones = new Habitaciones();
            ConfigurarDataGridView();
            CargarDatosHabitaciones();
            InitializeComboBoxes();
            LimpiarControles();
           dgvHabitaciones.SelectionChanged += dgvHabitaciones_SelectionChanged;
        }
        private void InitializeComboBoxes()
        {
            // Llenar el ComboBox de Tipo con opciones predefinidas
            cmbTipo.Items.Add("Estandar");
            cmbTipo.Items.Add("Suite");
            cmbTipo.Items.Add("Deluxe");
            cmbTipo.SelectedIndex = 0;
            // Llenar el ComboBox de Estado con opciones predefinidas
            cmbEstado.Items.Add("Disponible");
            cmbEstado.Items.Add("En Limpieza");
            cmbEstado.SelectedIndex = 0;
        }
        private void LimpiarControles()
        {
            cmbTipo.SelectedIndex = -1; // Ningún elemento seleccionado
            cmbEstado.SelectedIndex = -1; // Ningún elemento seleccionado
            txtNumero.Clear(); // Vaciar el TextBox
            txtPrecio.Clear(); // Vaciar el TextBox
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
                DataTable dt = habitaciones.ObtenerHabitaciones(); // Llama al método sin pasar la conexión
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
        private void dgvHabitaciones_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHabitaciones.CurrentRow != null && dgvHabitaciones.CurrentRow.Selected)
            {
                string tipo = dgvHabitaciones.CurrentRow.Cells[0].Value?.ToString();
                string estado = dgvHabitaciones.CurrentRow.Cells[1].Value?.ToString();
                string numero = dgvHabitaciones.CurrentRow.Cells[2].Value?.ToString();
                string precio = dgvHabitaciones.CurrentRow.Cells[3].Value?.ToString();

                cmbTipo.SelectedIndex = cmbTipo.Items.IndexOf(tipo);
                cmbEstado.SelectedIndex = cmbEstado.Items.IndexOf(estado);
                txtNumero.Text = numero ?? string.Empty;
                txtPrecio.Text = precio ?? string.Empty;

                // Deshabilitar el botón Agregar si hay una fila seleccionada
            }
            else
            {
                // Limpiar los controles y habilitar el botón Agregar si no hay fila seleccionada
                LimpiarControles();
                btnAgregar.Enabled = true;
            }
        }
        private void formHabitaciones_Load(object sender, EventArgs e)
        {
            if (dgvHabitaciones.Rows.Count > 0)
            {
                dgvHabitaciones.CurrentCell = dgvHabitaciones.Rows[0].Cells[0]; // Selecciona la primera fila
                dgvHabitaciones_SelectionChanged(null, null); // Fuerza la sincronización
            }
        }

        private void dgvHabitaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string tipo = cmbTipo.SelectedItem.ToString();
            string estado = cmbEstado.SelectedItem.ToString();
            int numero = int.Parse(txtNumero.Text);
            decimal precio = decimal.Parse(txtPrecio.Text);

            if (habitaciones.AgregarHabitacion(tipo, estado, numero, precio))
            {
                MessageBox.Show("Habitación agregada correctamente");
                CargarDatosHabitaciones();
            }
            else
            {
                MessageBox.Show("No se pudo agregar la habitación");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);
            if (habitaciones.EliminarHabitacion(numero))
            {
                MessageBox.Show("Habitación eliminada correctamente");
                CargarDatosHabitaciones();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar la habitación");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string tipo = dgvHabitaciones.CurrentRow.Cells[0].Value.ToString();
            string estado = dgvHabitaciones.CurrentRow.Cells[1].Value.ToString();
            int numeroViejo = int.Parse(dgvHabitaciones.CurrentRow.Cells[2].Value.ToString());
            int numeroNuevo = int.Parse(txtNumero.Text);
            decimal precio = decimal.Parse(txtPrecio.Text);

            bool actualizado = habitaciones.ModificarHabitacion(tipo, estado, numeroNuevo, precio, numeroViejo);

            if (actualizado)
            {
                MessageBox.Show("Habitación modificada correctamente.");
                CargarDatosHabitaciones(); // Recargar los datos
                //xd

                // Deseleccionar filas y habilitar el botón Agregar
                dgvHabitaciones.ClearSelection();
                btnAgregar.Enabled = true;
                btnAgregar.Visible = true;
            }
            else
            {
                MessageBox.Show("No se pudo modificar la habitación.");
            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
