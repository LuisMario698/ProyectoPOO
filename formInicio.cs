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
    public partial class formInicio : Form
    {
        public formInicio()
        {
            InitializeComponent();
            this.CenterToScreen();
            //Colores de paneles
            pnLogo.BackColor = ColorTranslator.FromHtml("#e57e31");
            pnTop.BackColor = ColorTranslator.FromHtml("#ffffff");
            pnLateral.BackColor = ColorTranslator.FromHtml("#1f2b37");
            pnCuerpo.BackColor = ColorTranslator.FromHtml("#dfdbd9");

            //Colores de botones
            btnHabitaciones.BaseColor = ColorTranslator.FromHtml("#1f2b37");
            btnClientes.BaseColor = ColorTranslator.FromHtml("#1f2b37");
            btnReservas.BaseColor = ColorTranslator.FromHtml("#1f2b37");
            btnPagos.BaseColor = ColorTranslator.FromHtml("#1f2b37");
            btnReportes.BaseColor = ColorTranslator.FromHtml("#1f2b37");
        }

        private void formInicio_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void ActualizarCuerpo()
        {
            foreach (Control control in pnCuerpo.Controls)
            {
                if (control is formClientes)
                {
                    control.Hide();
                    pnCuerpo.Controls.Remove(control);
                    break;
                }
                if (control is formHabitaciones)
                {
                    control.Hide();
                    pnCuerpo.Controls.Remove(control);
                    break;
                }
                if (control is formReservas)
                {
                    control.Hide();
                    pnCuerpo.Controls.Remove(control);
                    break;
                }
                if (control is formPagos)
                {
                    control.Hide();
                    pnCuerpo.Controls.Remove(control);
                    break;
                }
                if (control is formReportes)
                {
                    control.Hide();
                    pnCuerpo.Controls.Remove(control);
                    break;
                }
            }
        }
        private void btnHabitaciones_Click(object sender, EventArgs e)
        {
            ActualizarCuerpo();

            formHabitaciones habitaciones = new formHabitaciones();

            habitaciones.TopLevel = false; 
            habitaciones.FormBorderStyle = FormBorderStyle.None; 
            habitaciones.Dock = DockStyle.Fill; 

            pnCuerpo.Controls.Add(habitaciones);

            habitaciones.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ActualizarCuerpo();

            formClientes clientes = new formClientes();

            clientes.TopLevel = false; 
            clientes.FormBorderStyle = FormBorderStyle.None; 
            clientes.Dock = DockStyle.Fill; 

            pnCuerpo.Controls.Add(clientes);

            clientes.Show();
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            ActualizarCuerpo();

            formReservas reservas = new formReservas();

            reservas.TopLevel = false; 
            reservas.FormBorderStyle = FormBorderStyle.None; 
            reservas.Dock = DockStyle.Fill; 

            pnCuerpo.Controls.Add(reservas);

            reservas.Show();
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            ActualizarCuerpo();

            formPagos pagos = new formPagos();

            pagos.TopLevel = false; 
            pagos.FormBorderStyle = FormBorderStyle.None;
            pagos.Dock = DockStyle.Fill; 

            pnCuerpo.Controls.Add(pagos);

            pagos.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            ActualizarCuerpo();

            formReportes reportes = new formReportes();

            reportes.TopLevel = false; 
            reportes.FormBorderStyle = FormBorderStyle.None; 
            reportes.Dock = DockStyle.Fill; 

            pnCuerpo.Controls.Add(reportes);

            reportes.Show();
        }
    }
}
