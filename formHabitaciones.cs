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
            LimpiarControles();
            dgvHabitaciones.CellDoubleClick += dgvHabitaciones_CellDoubleClick;
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
            cmbTipo.SelectedIndex = 0; // Ningún elemento seleccionado
            cmbEstado.SelectedIndex = 0; // Ningún elemento seleccionado
            txtNumero.Clear(); // Vaciar el TextBox
            txtPrecio.Clear(); // Vaciar el TextBox
            lblEditando.Visible = false;
            lblHabitacion.Visible = false;
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
            dgvHabitaciones.AllowUserToAddRows = false;
            dgvHabitaciones.ReadOnly = true;

            // Deshabilitar selección inicial
            dgvHabitaciones.ClearSelection();
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

                dgvHabitaciones.ClearSelection(); // Deseleccionar filas
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void dgvHabitaciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que se hizo clic en una fila válida
            if (e.RowIndex >= 0 && e.RowIndex < dgvHabitaciones.Rows.Count)
            {
                DataGridViewRow row = dgvHabitaciones.Rows[e.RowIndex];

                cmbTipo.SelectedIndex = cmbTipo.Items.IndexOf(row.Cells[0].Value.ToString());
                cmbEstado.SelectedIndex = cmbEstado.Items.IndexOf(row.Cells[1].Value.ToString());
                txtNumero.Text = row.Cells[2].Value?.ToString() ?? string.Empty;
                txtPrecio.Text = row.Cells[3].Value?.ToString() ?? string.Empty;
                lblHabitacion.Text = row.Cells[2].Value?.ToString() ?? string.Empty;
                // Deshabilitar el botón Agregar
                btnAgregar.Enabled = false;
                btnAgregar.Visible = false;
                lblHabitacion.Visible = true;
                lblEditando.Visible = true;

            }
        }

        private void formHabitaciones_Load(object sender, EventArgs e)
        {
            if (dgvHabitaciones.Rows.Count > 0)
            {
                dgvHabitaciones.CurrentCell = dgvHabitaciones.Rows[0].Cells[0]; // Selecciona la primera fila
            }
        }

        private void dgvHabitaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {

                try
                {
                    string tipo = cmbTipo.SelectedItem.ToString();
                    string estado = cmbEstado.SelectedItem.ToString();
                    int numero = int.Parse(txtNumero.Text);
                    decimal precio = decimal.Parse(txtPrecio.Text);

                    // Validar si el número ya existe
                    if (NumeroDeHabitacionExiste(numero))
                    {
                        MessageBox.Show("Ya existe una habitación con este número. Intente con otro número.");
                        return;
                    }

                    if (habitaciones.AgregarHabitacion(tipo, estado, numero, precio))
                    {
                        MessageBox.Show("Habitación agregada correctamente");
                        CargarDatosHabitaciones();
                        LimpiarControles();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar la habitación");
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Por favor, ingrese valores válidos en todos los campos.");
                }
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ValidarSeleccion())
            {
                int numero = int.Parse(txtNumero.Text);
                if (habitaciones.EliminarHabitacion(numero))
                {
                    MessageBox.Show("Habitación eliminada correctamente.");
                    btnAgregar.Visible = true;
                    btnAgregar.Enabled = true;
                    CargarDatosHabitaciones();
                    LimpiarControles();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la habitación.");
                }
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (ValidarSeleccion() && ValidarCampos())
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
                    CargarDatosHabitaciones();
                    LimpiarControles();

                    // Volver a habilitar el botón Agregar
                    btnAgregar.Enabled = true;
                    btnAgregar.Visible = true;
                    lblEditando.Visible = true;
                    lblHabitacion.Visible = true;
                    lblEditando.Visible = false;
                    lblHabitacion.Visible = false;
                }
                else
                {
                    MessageBox.Show("No se pudo modificar la habitación.");
                }
            }
        }
        private bool ValidarCampos()
        {
            if (cmbTipo.SelectedIndex == -1 || cmbEstado.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtNumero.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos antes de continuar.");
                return false;
            }

            if (!int.TryParse(txtNumero.Text, out _) || !decimal.TryParse(txtPrecio.Text, out _))
            {
                MessageBox.Show("Asegúrate de que los campos de número y precio tengan valores válidos.");
                return false;
            }

            return true;
        }

        private bool ValidarSeleccion()
        {
            if (dgvHabitaciones.CurrentRow == null || !dgvHabitaciones.CurrentRow.Selected)
            {
                MessageBox.Show("Por favor, selecciona una fila para realizar esta acción.");
                return false;
            }

            return true;
        }
        private bool NumeroDeHabitacionExiste(int numero)
        {
            foreach (DataGridViewRow fila in dgvHabitaciones.Rows)
            {
                if (fila.Cells[2].Value != null && int.Parse(fila.Cells[2].Value.ToString()) == numero)
                {
                    return true;
                }
            }
            return false;
        }

        private void dgvHabitaciones_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblHabitacion_Click(object sender, EventArgs e)
        {

        }
    }
}
