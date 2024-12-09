using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class formClientesModificar : Form
    {
        public int idRecivido {  get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public Image Identificacion { get; set; }
        public formClientesModificar()
        {
            InitializeComponent();
        }

        private void formClientesModificar_Load(object sender, EventArgs e)
        {

        }
    }
}
