﻿using MaterialSkin;
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
            dgvHabitaciones.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
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
            string tipo = cmbTipo.SelectedItem.ToString();
            string estado = cmbEstado.SelectedItem.ToString();
            int numero = int.Parse(txtNumero.Text);
            decimal precio = decimal.Parse(txtPrecio.Text);

            if (habitaciones.ModificarHabitacion(tipo, estado, numero, precio))
            {
                MessageBox.Show("Habitación modificada correctamente");
                CargarDatosHabitaciones();
            }
            else
            {
                MessageBox.Show("No se pudo modificar la habitación");
            }
        }
    }
}
