namespace Proyecto
{
    partial class formPagos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvReservas = new Guna.UI.WinForms.GunaDataGridView();
            this.lblReserva = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.lblReservaSeleccionada = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.lblCargos = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.lblComidas = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.txtComidas = new Guna.UI.WinForms.GunaTextBox();
            this.checkLimpieza = new Guna.UI.WinForms.GunaCheckBox();
            this.lblIndicar = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.lblIdHabitacion = new Guna.UI.WinForms.GunaLabel();
            this.lblPrecioHabitacion = new Guna.UI.WinForms.GunaLabel();
            this.lblNombreCliente = new Guna.UI.WinForms.GunaLabel();
            this.lblIdCliente = new Guna.UI.WinForms.GunaLabel();
            this.lblTipoHabitacion = new Guna.UI.WinForms.GunaLabel();
            this.lblIdC = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.lblNombreC = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.lblNumeroH = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.lblTipoH = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.lblPrecioDia = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.lblInstancia = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.lblInstanciaTotal = new Guna.UI.WinForms.GunaLabel();
            this.lblGastosCo = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.lblTotalComida = new Guna.UI.WinForms.GunaLabel();
            this.lblGastosL = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.lblTotalLimpieza = new Guna.UI.WinForms.GunaLabel();
            this.lblSubT = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.lblSubtotal = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.lblTotal = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.lblTot = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.btnPago = new Guna.UI.WinForms.GunaButton();
            this.dungeonHeaderLabel1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReservas
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvReservas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReservas.BackgroundColor = System.Drawing.Color.White;
            this.dgvReservas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReservas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReservas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReservas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvReservas.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReservas.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvReservas.EnableHeadersVisualStyles = false;
            this.dgvReservas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvReservas.Location = new System.Drawing.Point(434, 70);
            this.dgvReservas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.RowHeadersVisible = false;
            this.dgvReservas.RowHeadersWidth = 51;
            this.dgvReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservas.Size = new System.Drawing.Size(686, 470);
            this.dgvReservas.TabIndex = 0;
            this.dgvReservas.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvReservas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvReservas.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvReservas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvReservas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvReservas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvReservas.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvReservas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvReservas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvReservas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvReservas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvReservas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvReservas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvReservas.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvReservas.ThemeStyle.ReadOnly = false;
            this.dgvReservas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvReservas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReservas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvReservas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvReservas.ThemeStyle.RowsStyle.Height = 22;
            this.dgvReservas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvReservas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvReservas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservas_CellClick);
            this.dgvReservas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservas_CellContentClick);
            // 
            // lblReserva
            // 
            this.lblReserva.AutoSize = true;
            this.lblReserva.BackColor = System.Drawing.Color.Transparent;
            this.lblReserva.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblReserva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lblReserva.Location = new System.Drawing.Point(83, 107);
            this.lblReserva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReserva.Name = "lblReserva";
            this.lblReserva.Size = new System.Drawing.Size(86, 25);
            this.lblReserva.TabIndex = 26;
            this.lblReserva.Text = "Reserva:";
            // 
            // lblReservaSeleccionada
            // 
            this.lblReservaSeleccionada.AutoSize = true;
            this.lblReservaSeleccionada.BackColor = System.Drawing.Color.Transparent;
            this.lblReservaSeleccionada.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblReservaSeleccionada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lblReservaSeleccionada.Location = new System.Drawing.Point(183, 107);
            this.lblReservaSeleccionada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReservaSeleccionada.Name = "lblReservaSeleccionada";
            this.lblReservaSeleccionada.Size = new System.Drawing.Size(23, 25);
            this.lblReservaSeleccionada.TabIndex = 27;
            this.lblReservaSeleccionada.Text = "0";
            // 
            // lblCargos
            // 
            this.lblCargos.AutoSize = true;
            this.lblCargos.BackColor = System.Drawing.Color.Transparent;
            this.lblCargos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCargos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lblCargos.Location = new System.Drawing.Point(119, 407);
            this.lblCargos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCargos.Name = "lblCargos";
            this.lblCargos.Size = new System.Drawing.Size(177, 25);
            this.lblCargos.TabIndex = 28;
            this.lblCargos.Text = "Cargos adicionales";
            // 
            // lblComidas
            // 
            this.lblComidas.AutoSize = true;
            this.lblComidas.BackColor = System.Drawing.Color.Transparent;
            this.lblComidas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblComidas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lblComidas.Location = new System.Drawing.Point(92, 473);
            this.lblComidas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComidas.Name = "lblComidas";
            this.lblComidas.Size = new System.Drawing.Size(88, 25);
            this.lblComidas.TabIndex = 30;
            this.lblComidas.Text = "Comidas";
            // 
            // txtComidas
            // 
            this.txtComidas.BaseColor = System.Drawing.Color.White;
            this.txtComidas.BorderColor = System.Drawing.Color.Silver;
            this.txtComidas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtComidas.FocusedBaseColor = System.Drawing.Color.White;
            this.txtComidas.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtComidas.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtComidas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtComidas.Location = new System.Drawing.Point(192, 468);
            this.txtComidas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtComidas.Name = "txtComidas";
            this.txtComidas.PasswordChar = '\0';
            this.txtComidas.SelectedText = "";
            this.txtComidas.Size = new System.Drawing.Size(213, 37);
            this.txtComidas.TabIndex = 31;
            this.txtComidas.Text = "0";
            this.txtComidas.TextChanged += new System.EventHandler(this.txtComidas_TextChanged);
            // 
            // checkLimpieza
            // 
            this.checkLimpieza.BaseColor = System.Drawing.Color.White;
            this.checkLimpieza.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkLimpieza.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.checkLimpieza.FillColor = System.Drawing.Color.White;
            this.checkLimpieza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkLimpieza.Location = new System.Drawing.Point(97, 436);
            this.checkLimpieza.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkLimpieza.Name = "checkLimpieza";
            this.checkLimpieza.Size = new System.Drawing.Size(186, 22);
            this.checkLimpieza.TabIndex = 32;
            this.checkLimpieza.Text = "Servicio de limpieza";
            this.checkLimpieza.CheckedChanged += new System.EventHandler(this.checkLimpieza_CheckedChanged);
            // 
            // lblIndicar
            // 
            this.lblIndicar.AutoSize = true;
            this.lblIndicar.BackColor = System.Drawing.Color.Transparent;
            this.lblIndicar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblIndicar.ForeColor = System.Drawing.Color.Silver;
            this.lblIndicar.Location = new System.Drawing.Point(140, 508);
            this.lblIndicar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndicar.Name = "lblIndicar";
            this.lblIndicar.Size = new System.Drawing.Size(255, 25);
            this.lblIndicar.TabIndex = 33;
            this.lblIndicar.Text = "Indicar numero de comidas";
            // 
            // lblIdHabitacion
            // 
            this.lblIdHabitacion.AutoSize = true;
            this.lblIdHabitacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblIdHabitacion.Location = new System.Drawing.Point(251, 238);
            this.lblIdHabitacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdHabitacion.Name = "lblIdHabitacion";
            this.lblIdHabitacion.Size = new System.Drawing.Size(17, 20);
            this.lblIdHabitacion.TabIndex = 34;
            this.lblIdHabitacion.Text = "0";
            // 
            // lblPrecioHabitacion
            // 
            this.lblPrecioHabitacion.AutoSize = true;
            this.lblPrecioHabitacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPrecioHabitacion.Location = new System.Drawing.Point(251, 309);
            this.lblPrecioHabitacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioHabitacion.Name = "lblPrecioHabitacion";
            this.lblPrecioHabitacion.Size = new System.Drawing.Size(17, 20);
            this.lblPrecioHabitacion.TabIndex = 35;
            this.lblPrecioHabitacion.Text = "0";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNombreCliente.Location = new System.Drawing.Point(251, 199);
            this.lblNombreCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(15, 20);
            this.lblNombreCliente.TabIndex = 36;
            this.lblNombreCliente.Text = "-";
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblIdCliente.Location = new System.Drawing.Point(249, 169);
            this.lblIdCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(17, 20);
            this.lblIdCliente.TabIndex = 37;
            this.lblIdCliente.Text = "0";
            // 
            // lblTipoHabitacion
            // 
            this.lblTipoHabitacion.AutoSize = true;
            this.lblTipoHabitacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTipoHabitacion.Location = new System.Drawing.Point(249, 268);
            this.lblTipoHabitacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoHabitacion.Name = "lblTipoHabitacion";
            this.lblTipoHabitacion.Size = new System.Drawing.Size(15, 20);
            this.lblTipoHabitacion.TabIndex = 38;
            this.lblTipoHabitacion.Text = "-";
            // 
            // lblIdC
            // 
            this.lblIdC.AutoSize = true;
            this.lblIdC.BackColor = System.Drawing.Color.Transparent;
            this.lblIdC.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblIdC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lblIdC.Location = new System.Drawing.Point(119, 162);
            this.lblIdC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdC.Name = "lblIdC";
            this.lblIdC.Size = new System.Drawing.Size(125, 25);
            this.lblIdC.TabIndex = 39;
            this.lblIdC.Text = "Id de cliente:";
            // 
            // lblNombreC
            // 
            this.lblNombreC.AutoSize = true;
            this.lblNombreC.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreC.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblNombreC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lblNombreC.Location = new System.Drawing.Point(60, 193);
            this.lblNombreC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreC.Name = "lblNombreC";
            this.lblNombreC.Size = new System.Drawing.Size(181, 25);
            this.lblNombreC.TabIndex = 40;
            this.lblNombreC.Text = "Nombre de cliente:";
            // 
            // lblNumeroH
            // 
            this.lblNumeroH.AutoSize = true;
            this.lblNumeroH.BackColor = System.Drawing.Color.Transparent;
            this.lblNumeroH.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblNumeroH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lblNumeroH.Location = new System.Drawing.Point(24, 231);
            this.lblNumeroH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroH.Name = "lblNumeroH";
            this.lblNumeroH.Size = new System.Drawing.Size(216, 25);
            this.lblNumeroH.TabIndex = 41;
            this.lblNumeroH.Text = "Numero de habitacion:";
            // 
            // lblTipoH
            // 
            this.lblTipoH.AutoSize = true;
            this.lblTipoH.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoH.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTipoH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lblTipoH.Location = new System.Drawing.Point(191, 263);
            this.lblTipoH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoH.Name = "lblTipoH";
            this.lblTipoH.Size = new System.Drawing.Size(57, 25);
            this.lblTipoH.TabIndex = 42;
            this.lblTipoH.Text = "Tipo:";
            // 
            // lblPrecioDia
            // 
            this.lblPrecioDia.AutoSize = true;
            this.lblPrecioDia.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecioDia.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblPrecioDia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lblPrecioDia.Location = new System.Drawing.Point(175, 303);
            this.lblPrecioDia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioDia.Name = "lblPrecioDia";
            this.lblPrecioDia.Size = new System.Drawing.Size(73, 25);
            this.lblPrecioDia.TabIndex = 43;
            this.lblPrecioDia.Text = "Precio:";
            // 
            // lblInstancia
            // 
            this.lblInstancia.AutoSize = true;
            this.lblInstancia.BackColor = System.Drawing.Color.Transparent;
            this.lblInstancia.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblInstancia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lblInstancia.Location = new System.Drawing.Point(148, 330);
            this.lblInstancia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstancia.Name = "lblInstancia";
            this.lblInstancia.Size = new System.Drawing.Size(96, 25);
            this.lblInstancia.TabIndex = 44;
            this.lblInstancia.Text = "Instancia:";
            // 
            // lblInstanciaTotal
            // 
            this.lblInstanciaTotal.AutoSize = true;
            this.lblInstanciaTotal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInstanciaTotal.Location = new System.Drawing.Point(253, 335);
            this.lblInstanciaTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstanciaTotal.Name = "lblInstanciaTotal";
            this.lblInstanciaTotal.Size = new System.Drawing.Size(17, 20);
            this.lblInstanciaTotal.TabIndex = 45;
            this.lblInstanciaTotal.Text = "0";
            this.lblInstanciaTotal.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // lblGastosCo
            // 
            this.lblGastosCo.AutoSize = true;
            this.lblGastosCo.BackColor = System.Drawing.Color.Transparent;
            this.lblGastosCo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblGastosCo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lblGastosCo.Location = new System.Drawing.Point(33, 548);
            this.lblGastosCo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGastosCo.Name = "lblGastosCo";
            this.lblGastosCo.Size = new System.Drawing.Size(183, 25);
            this.lblGastosCo.TabIndex = 46;
            this.lblGastosCo.Text = "Gastos por comida:";
            // 
            // lblTotalComida
            // 
            this.lblTotalComida.AutoSize = true;
            this.lblTotalComida.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalComida.Location = new System.Drawing.Point(257, 553);
            this.lblTotalComida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalComida.Name = "lblTotalComida";
            this.lblTotalComida.Size = new System.Drawing.Size(17, 20);
            this.lblTotalComida.TabIndex = 47;
            this.lblTotalComida.Text = "0";
            // 
            // lblGastosL
            // 
            this.lblGastosL.AutoSize = true;
            this.lblGastosL.BackColor = System.Drawing.Color.Transparent;
            this.lblGastosL.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblGastosL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lblGastosL.Location = new System.Drawing.Point(33, 572);
            this.lblGastosL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGastosL.Name = "lblGastosL";
            this.lblGastosL.Size = new System.Drawing.Size(191, 25);
            this.lblGastosL.TabIndex = 48;
            this.lblGastosL.Text = "Gastos por limpieza:";
            // 
            // lblTotalLimpieza
            // 
            this.lblTotalLimpieza.AutoSize = true;
            this.lblTotalLimpieza.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalLimpieza.Location = new System.Drawing.Point(257, 578);
            this.lblTotalLimpieza.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalLimpieza.Name = "lblTotalLimpieza";
            this.lblTotalLimpieza.Size = new System.Drawing.Size(17, 20);
            this.lblTotalLimpieza.TabIndex = 49;
            this.lblTotalLimpieza.Text = "0";
            // 
            // lblSubT
            // 
            this.lblSubT.AutoSize = true;
            this.lblSubT.BackColor = System.Drawing.Color.Transparent;
            this.lblSubT.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSubT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lblSubT.Location = new System.Drawing.Point(119, 368);
            this.lblSubT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubT.Name = "lblSubT";
            this.lblSubT.Size = new System.Drawing.Size(93, 25);
            this.lblSubT.TabIndex = 50;
            this.lblSubT.Text = "Subtotal:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lblSubtotal.Location = new System.Drawing.Point(223, 368);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(23, 25);
            this.lblSubtotal.TabIndex = 51;
            this.lblSubtotal.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lblTotal.Location = new System.Drawing.Point(211, 617);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(23, 25);
            this.lblTotal.TabIndex = 52;
            this.lblTotal.Text = "0";
            // 
            // lblTot
            // 
            this.lblTot.AutoSize = true;
            this.lblTot.BackColor = System.Drawing.Color.Transparent;
            this.lblTot.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lblTot.Location = new System.Drawing.Point(115, 617);
            this.lblTot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTot.Name = "lblTot";
            this.lblTot.Size = new System.Drawing.Size(60, 25);
            this.lblTot.TabIndex = 53;
            this.lblTot.Text = "Total:";
            // 
            // btnPago
            // 
            this.btnPago.AnimationHoverSpeed = 0.07F;
            this.btnPago.AnimationSpeed = 0.03F;
            this.btnPago.BackColor = System.Drawing.Color.Transparent;
            this.btnPago.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnPago.BorderColor = System.Drawing.Color.Black;
            this.btnPago.BorderSize = 1;
            this.btnPago.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPago.FocusedColor = System.Drawing.Color.Empty;
            this.btnPago.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPago.ForeColor = System.Drawing.Color.White;
            this.btnPago.Image = null;
            this.btnPago.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPago.Location = new System.Drawing.Point(693, 572);
            this.btnPago.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPago.Name = "btnPago";
            this.btnPago.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnPago.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPago.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPago.OnHoverImage = null;
            this.btnPago.OnPressedColor = System.Drawing.Color.Black;
            this.btnPago.Radius = 10;
            this.btnPago.Size = new System.Drawing.Size(165, 52);
            this.btnPago.TabIndex = 68;
            this.btnPago.Text = "Procesar Pago";
            this.btnPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPago.Click += new System.EventHandler(this.btnPago_Click);
            // 
            // dungeonHeaderLabel1
            // 
            this.dungeonHeaderLabel1.AutoSize = true;
            this.dungeonHeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonHeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.dungeonHeaderLabel1.ForeColor = System.Drawing.Color.Silver;
            this.dungeonHeaderLabel1.Location = new System.Drawing.Point(640, 41);
            this.dungeonHeaderLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dungeonHeaderLabel1.Name = "dungeonHeaderLabel1";
            this.dungeonHeaderLabel1.Size = new System.Drawing.Size(267, 25);
            this.dungeonHeaderLabel1.TabIndex = 69;
            this.dungeonHeaderLabel1.Text = "Seleccione la reserva a pagar";
            // 
            // formPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1667, 689);
            this.Controls.Add(this.dungeonHeaderLabel1);
            this.Controls.Add(this.btnPago);
            this.Controls.Add(this.lblTot);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblSubT);
            this.Controls.Add(this.lblTotalLimpieza);
            this.Controls.Add(this.lblGastosL);
            this.Controls.Add(this.lblTotalComida);
            this.Controls.Add(this.lblGastosCo);
            this.Controls.Add(this.lblInstanciaTotal);
            this.Controls.Add(this.lblInstancia);
            this.Controls.Add(this.lblPrecioDia);
            this.Controls.Add(this.lblTipoH);
            this.Controls.Add(this.lblNumeroH);
            this.Controls.Add(this.lblNombreC);
            this.Controls.Add(this.lblIdC);
            this.Controls.Add(this.lblTipoHabitacion);
            this.Controls.Add(this.lblIdCliente);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.lblPrecioHabitacion);
            this.Controls.Add(this.lblIdHabitacion);
            this.Controls.Add(this.lblIndicar);
            this.Controls.Add(this.checkLimpieza);
            this.Controls.Add(this.txtComidas);
            this.Controls.Add(this.lblComidas);
            this.Controls.Add(this.lblCargos);
            this.Controls.Add(this.lblReservaSeleccionada);
            this.Controls.Add(this.lblReserva);
            this.Controls.Add(this.dgvReservas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formPagos";
            this.Text = "formPagos";
            this.Load += new System.EventHandler(this.formPagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView dgvReservas;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lblReserva;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lblReservaSeleccionada;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lblCargos;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lblComidas;
        private Guna.UI.WinForms.GunaTextBox txtComidas;
        private Guna.UI.WinForms.GunaCheckBox checkLimpieza;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lblIndicar;
        private Guna.UI.WinForms.GunaLabel lblIdHabitacion;
        private Guna.UI.WinForms.GunaLabel lblPrecioHabitacion;
        private Guna.UI.WinForms.GunaLabel lblNombreCliente;
        private Guna.UI.WinForms.GunaLabel lblIdCliente;
        private Guna.UI.WinForms.GunaLabel lblTipoHabitacion;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lblIdC;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lblNombreC;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lblNumeroH;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lblTipoH;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lblPrecioDia;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lblInstancia;
        private Guna.UI.WinForms.GunaLabel lblInstanciaTotal;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lblGastosCo;
        private Guna.UI.WinForms.GunaLabel lblTotalComida;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lblGastosL;
        private Guna.UI.WinForms.GunaLabel lblTotalLimpieza;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lblSubT;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lblSubtotal;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lblTotal;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lblTot;
        private Guna.UI.WinForms.GunaButton btnPago;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel1;
    }
}