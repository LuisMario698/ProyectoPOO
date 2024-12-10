namespace Proyecto
{
    partial class formHabitaciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvHabitaciones = new Guna.UI.WinForms.GunaDataGridView();
            this.btnEliminar = new ReaLTaiizor.Controls.Button();
            this.btnModificar = new ReaLTaiizor.Controls.Button();
            this.btnAgregar = new ReaLTaiizor.Controls.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.cmbTipo = new ReaLTaiizor.Controls.AloneComboBox();
            this.cmbEstado = new ReaLTaiizor.Controls.AloneComboBox();
            this.lblEditando = new System.Windows.Forms.Label();
            this.lblHabitacion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHabitaciones
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvHabitaciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHabitaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHabitaciones.BackgroundColor = System.Drawing.Color.White;
            this.dgvHabitaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHabitaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHabitaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHabitaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHabitaciones.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHabitaciones.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHabitaciones.EnableHeadersVisualStyles = false;
            this.dgvHabitaciones.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHabitaciones.Location = new System.Drawing.Point(390, 87);
            this.dgvHabitaciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvHabitaciones.Name = "dgvHabitaciones";
            this.dgvHabitaciones.RowHeadersVisible = false;
            this.dgvHabitaciones.RowHeadersWidth = 62;
            this.dgvHabitaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHabitaciones.Size = new System.Drawing.Size(839, 378);
            this.dgvHabitaciones.TabIndex = 0;
            this.dgvHabitaciones.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvHabitaciones.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHabitaciones.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvHabitaciones.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvHabitaciones.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvHabitaciones.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvHabitaciones.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvHabitaciones.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHabitaciones.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvHabitaciones.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHabitaciones.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvHabitaciones.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvHabitaciones.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvHabitaciones.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvHabitaciones.ThemeStyle.ReadOnly = false;
            this.dgvHabitaciones.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHabitaciones.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHabitaciones.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvHabitaciones.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvHabitaciones.ThemeStyle.RowsStyle.Height = 22;
            this.dgvHabitaciones.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHabitaciones.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvHabitaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHabitaciones_CellContentClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnEliminar.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEliminar.Image = null;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnEliminar.Location = new System.Drawing.Point(1109, 473);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnEliminar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnEliminar.Size = new System.Drawing.Size(120, 40);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnModificar.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnModificar.Image = null;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnModificar.Location = new System.Drawing.Point(967, 473);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnModificar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnModificar.Size = new System.Drawing.Size(120, 40);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnAgregar.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAgregar.Image = null;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnAgregar.Location = new System.Drawing.Point(143, 473);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnAgregar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnAgregar.Size = new System.Drawing.Size(120, 40);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(40, 172);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(43, 20);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(26, 233);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(64, 20);
            this.lblEstado.TabIndex = 5;
            this.lblEstado.Text = "Estado:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(14, 301);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(69, 20);
            this.lblNumero.TabIndex = 6;
            this.lblNumero.Text = "Numero:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(26, 351);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(57, 20);
            this.lblPrecio.TabIndex = 7;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(89, 301);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(174, 26);
            this.txtNumero.TabIndex = 10;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(89, 351);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(174, 26);
            this.txtPrecio.TabIndex = 11;
            // 
            // cmbTipo
            // 
            this.cmbTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.EnabledCalc = true;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.ItemHeight = 20;
            this.cmbTipo.Location = new System.Drawing.Point(89, 172);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(174, 26);
            this.cmbTipo.TabIndex = 12;
            // 
            // cmbEstado
            // 
            this.cmbEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.EnabledCalc = true;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.ItemHeight = 20;
            this.cmbEstado.Location = new System.Drawing.Point(89, 227);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(174, 26);
            this.cmbEstado.TabIndex = 13;
            // 
            // lblEditando
            // 
            this.lblEditando.AutoSize = true;
            this.lblEditando.Location = new System.Drawing.Point(58, 87);
            this.lblEditando.Name = "lblEditando";
            this.lblEditando.Size = new System.Drawing.Size(221, 20);
            this.lblEditando.TabIndex = 14;
            this.lblEditando.Text = "Editando Habitacion Numero: ";
            // 
            // lblHabitacion
            // 
            this.lblHabitacion.AutoSize = true;
            this.lblHabitacion.Location = new System.Drawing.Point(139, 127);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(18, 20);
            this.lblHabitacion.TabIndex = 15;
            this.lblHabitacion.Text = "0";
            // 
            // formHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 560);
            this.Controls.Add(this.lblHabitacion);
            this.Controls.Add(this.lblEditando);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvHabitaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "formHabitaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formHabitaciones";
            this.Load += new System.EventHandler(this.formHabitaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView dgvHabitaciones;
        private ReaLTaiizor.Controls.Button btnEliminar;
        private ReaLTaiizor.Controls.Button btnModificar;
        private ReaLTaiizor.Controls.Button btnAgregar;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtPrecio;
        private ReaLTaiizor.Controls.AloneComboBox cmbTipo;
        private ReaLTaiizor.Controls.AloneComboBox cmbEstado;
        private System.Windows.Forms.Label lblEditando;
        private System.Windows.Forms.Label lblHabitacion;
    }
}