namespace Proyecto
{
    partial class formReservas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvReservas = new Guna.UI.WinForms.GunaDataGridView();
            this.lblEntrada = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.lblAntes = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.cbClientes = new ReaLTaiizor.Controls.SkyComboBox();
            this.cbHabitaciones = new ReaLTaiizor.Controls.SkyComboBox();
            this.dpEntrada = new ReaLTaiizor.Controls.HopeDatePicker();
            this.dpSalida = new ReaLTaiizor.Controls.HopeDatePicker();
            this.lblSalida = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.lblCliente = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.lblHabitacion = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.btnReservar = new Guna.UI.WinForms.GunaButton();
            this.lblReservacionesActivas = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.btnCancelar = new Guna.UI.WinForms.GunaButton();
            this.lblCancelarReservacion = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReservas
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvReservas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReservas.BackgroundColor = System.Drawing.Color.White;
            this.dgvReservas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReservas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReservas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReservas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvReservas.ColumnHeadersHeight = 4;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReservas.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvReservas.EnableHeadersVisualStyles = false;
            this.dgvReservas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvReservas.Location = new System.Drawing.Point(625, 42);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.RowHeadersVisible = false;
            this.dgvReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservas.Size = new System.Drawing.Size(602, 409);
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
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.BackColor = System.Drawing.Color.Transparent;
            this.lblEntrada.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lblEntrada.Location = new System.Drawing.Point(107, 315);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(63, 20);
            this.lblEntrada.TabIndex = 25;
            this.lblEntrada.Text = "Entrada";
            // 
            // lblAntes
            // 
            this.lblAntes.AutoSize = true;
            this.lblAntes.BackColor = System.Drawing.Color.Transparent;
            this.lblAntes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblAntes.ForeColor = System.Drawing.Color.Silver;
            this.lblAntes.Location = new System.Drawing.Point(385, 19);
            this.lblAntes.Name = "lblAntes";
            this.lblAntes.Size = new System.Drawing.Size(141, 20);
            this.lblAntes.TabIndex = 52;
            this.lblAntes.Text = "Seleccionar fecha...";
            // 
            // cbClientes
            // 
            this.cbClientes.BackColor = System.Drawing.Color.Transparent;
            this.cbClientes.BGColorA = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.cbClientes.BGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.cbClientes.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.cbClientes.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cbClientes.BorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.cbClientes.BorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.cbClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbClientes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClientes.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold);
            this.cbClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.ItemHeight = 16;
            this.cbClientes.ItemHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(176)))), ((int)(((byte)(214)))));
            this.cbClientes.LineColorA = System.Drawing.Color.White;
            this.cbClientes.LineColorB = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.cbClientes.LineColorC = System.Drawing.Color.White;
            this.cbClientes.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbClientes.ListBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbClientes.ListDashType = System.Drawing.Drawing2D.DashStyle.Dot;
            this.cbClientes.ListForeColor = System.Drawing.Color.Black;
            this.cbClientes.ListSelectedBackColorA = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbClientes.ListSelectedBackColorB = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbClientes.Location = new System.Drawing.Point(55, 401);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(163, 22);
            this.cbClientes.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.cbClientes.StartIndex = 0;
            this.cbClientes.TabIndex = 54;
            this.cbClientes.TriangleColorA = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(176)))), ((int)(((byte)(214)))));
            this.cbClientes.TriangleColorB = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            // 
            // cbHabitaciones
            // 
            this.cbHabitaciones.BackColor = System.Drawing.Color.Transparent;
            this.cbHabitaciones.BGColorA = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.cbHabitaciones.BGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.cbHabitaciones.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.cbHabitaciones.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cbHabitaciones.BorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.cbHabitaciones.BorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.cbHabitaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbHabitaciones.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbHabitaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHabitaciones.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold);
            this.cbHabitaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.cbHabitaciones.FormattingEnabled = true;
            this.cbHabitaciones.ItemHeight = 16;
            this.cbHabitaciones.ItemHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(176)))), ((int)(((byte)(214)))));
            this.cbHabitaciones.LineColorA = System.Drawing.Color.White;
            this.cbHabitaciones.LineColorB = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.cbHabitaciones.LineColorC = System.Drawing.Color.White;
            this.cbHabitaciones.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbHabitaciones.ListBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbHabitaciones.ListDashType = System.Drawing.Drawing2D.DashStyle.Dot;
            this.cbHabitaciones.ListForeColor = System.Drawing.Color.Black;
            this.cbHabitaciones.ListSelectedBackColorA = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbHabitaciones.ListSelectedBackColorB = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbHabitaciones.Location = new System.Drawing.Point(363, 401);
            this.cbHabitaciones.Name = "cbHabitaciones";
            this.cbHabitaciones.Size = new System.Drawing.Size(163, 22);
            this.cbHabitaciones.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.cbHabitaciones.StartIndex = 0;
            this.cbHabitaciones.TabIndex = 55;
            this.cbHabitaciones.TriangleColorA = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(176)))), ((int)(((byte)(214)))));
            this.cbHabitaciones.TriangleColorB = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.cbHabitaciones.SelectedIndexChanged += new System.EventHandler(this.cbHabitaciones_SelectedIndexChanged);
            // 
            // dpEntrada
            // 
            this.dpEntrada.BackColor = System.Drawing.Color.White;
            this.dpEntrada.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.dpEntrada.Date = new System.DateTime(2024, 12, 8, 0, 0, 0, 0);
            this.dpEntrada.DayNames = "MTWTFSS";
            this.dpEntrada.DaysTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.dpEntrada.DayTextColorA = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.dpEntrada.DayTextColorB = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.dpEntrada.HeaderFormat = "{0} Y - {1} M";
            this.dpEntrada.HeaderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.dpEntrada.HeadLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.dpEntrada.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.dpEntrada.Location = new System.Drawing.Point(12, 42);
            this.dpEntrada.Name = "dpEntrada";
            this.dpEntrada.NMColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.dpEntrada.NMHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.dpEntrada.NYColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.dpEntrada.NYHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.dpEntrada.PMColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.dpEntrada.PMHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.dpEntrada.PYColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.dpEntrada.PYHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.dpEntrada.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.dpEntrada.SelectedTextColor = System.Drawing.Color.White;
            this.dpEntrada.Size = new System.Drawing.Size(250, 270);
            this.dpEntrada.TabIndex = 58;
            this.dpEntrada.Text = "hopeDatePicker1";
            this.dpEntrada.ValueTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(133)))), ((int)(((byte)(228)))));
            // 
            // dpSalida
            // 
            this.dpSalida.BackColor = System.Drawing.Color.White;
            this.dpSalida.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.dpSalida.Date = new System.DateTime(2024, 12, 8, 0, 0, 0, 0);
            this.dpSalida.DayNames = "MTWTFSS";
            this.dpSalida.DaysTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.dpSalida.DayTextColorA = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.dpSalida.DayTextColorB = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.dpSalida.HeaderFormat = "{0} Y - {1} M";
            this.dpSalida.HeaderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.dpSalida.HeadLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.dpSalida.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.dpSalida.Location = new System.Drawing.Point(329, 42);
            this.dpSalida.Name = "dpSalida";
            this.dpSalida.NMColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.dpSalida.NMHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.dpSalida.NYColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.dpSalida.NYHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.dpSalida.PMColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.dpSalida.PMHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.dpSalida.PYColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.dpSalida.PYHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.dpSalida.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.dpSalida.SelectedTextColor = System.Drawing.Color.White;
            this.dpSalida.Size = new System.Drawing.Size(250, 270);
            this.dpSalida.TabIndex = 59;
            this.dpSalida.Text = "hopeDatePicker2";
            this.dpSalida.ValueTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(133)))), ((int)(((byte)(228)))));
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.BackColor = System.Drawing.Color.Transparent;
            this.lblSalida.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSalida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lblSalida.Location = new System.Drawing.Point(420, 315);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(50, 20);
            this.lblSalida.TabIndex = 60;
            this.lblSalida.Text = "Salida";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lblCliente.Location = new System.Drawing.Point(107, 378);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(57, 20);
            this.lblCliente.TabIndex = 61;
            this.lblCliente.Text = "Cliente";
            // 
            // lblHabitacion
            // 
            this.lblHabitacion.AutoSize = true;
            this.lblHabitacion.BackColor = System.Drawing.Color.Transparent;
            this.lblHabitacion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblHabitacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lblHabitacion.Location = new System.Drawing.Point(405, 378);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(84, 20);
            this.lblHabitacion.TabIndex = 62;
            this.lblHabitacion.Text = "Habitacion";
            // 
            // btnReservar
            // 
            this.btnReservar.AnimationHoverSpeed = 0.07F;
            this.btnReservar.AnimationSpeed = 0.03F;
            this.btnReservar.BackColor = System.Drawing.Color.Transparent;
            this.btnReservar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnReservar.BorderColor = System.Drawing.Color.Black;
            this.btnReservar.BorderSize = 1;
            this.btnReservar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReservar.FocusedColor = System.Drawing.Color.Empty;
            this.btnReservar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReservar.ForeColor = System.Drawing.Color.White;
            this.btnReservar.Image = null;
            this.btnReservar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnReservar.Location = new System.Drawing.Point(226, 470);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnReservar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReservar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReservar.OnHoverImage = null;
            this.btnReservar.OnPressedColor = System.Drawing.Color.Black;
            this.btnReservar.Radius = 10;
            this.btnReservar.Size = new System.Drawing.Size(124, 42);
            this.btnReservar.TabIndex = 68;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // lblReservacionesActivas
            // 
            this.lblReservacionesActivas.AutoSize = true;
            this.lblReservacionesActivas.BackColor = System.Drawing.Color.Transparent;
            this.lblReservacionesActivas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblReservacionesActivas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lblReservacionesActivas.Location = new System.Drawing.Point(850, 19);
            this.lblReservacionesActivas.Name = "lblReservacionesActivas";
            this.lblReservacionesActivas.Size = new System.Drawing.Size(164, 20);
            this.lblReservacionesActivas.TabIndex = 69;
            this.lblReservacionesActivas.Text = "Reservaciones Activas";
            // 
            // btnCancelar
            // 
            this.btnCancelar.AnimationHoverSpeed = 0.07F;
            this.btnCancelar.AnimationSpeed = 0.03F;
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnCancelar.BorderColor = System.Drawing.Color.Black;
            this.btnCancelar.BorderSize = 1;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancelar.FocusedColor = System.Drawing.Color.Empty;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = null;
            this.btnCancelar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCancelar.Location = new System.Drawing.Point(874, 488);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCancelar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCancelar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCancelar.OnHoverImage = null;
            this.btnCancelar.OnPressedColor = System.Drawing.Color.Black;
            this.btnCancelar.Radius = 10;
            this.btnCancelar.Size = new System.Drawing.Size(124, 42);
            this.btnCancelar.TabIndex = 70;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblCancelarReservacion
            // 
            this.lblCancelarReservacion.AutoSize = true;
            this.lblCancelarReservacion.BackColor = System.Drawing.Color.Transparent;
            this.lblCancelarReservacion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCancelarReservacion.ForeColor = System.Drawing.Color.Silver;
            this.lblCancelarReservacion.Location = new System.Drawing.Point(813, 459);
            this.lblCancelarReservacion.Name = "lblCancelarReservacion";
            this.lblCancelarReservacion.Size = new System.Drawing.Size(255, 20);
            this.lblCancelarReservacion.TabIndex = 71;
            this.lblCancelarReservacion.Text = "Seleccione la reservacion a cancelar";
            // 
            // formReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 560);
            this.Controls.Add(this.lblCancelarReservacion);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblReservacionesActivas);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.lblHabitacion);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.dpSalida);
            this.Controls.Add(this.dpEntrada);
            this.Controls.Add(this.cbHabitaciones);
            this.Controls.Add(this.cbClientes);
            this.Controls.Add(this.lblAntes);
            this.Controls.Add(this.lblEntrada);
            this.Controls.Add(this.dgvReservas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formReservas";
            this.Text = "formReservas";
            this.Load += new System.EventHandler(this.formReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView dgvReservas;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lblEntrada;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lblAntes;
        private ReaLTaiizor.Controls.SkyComboBox cbClientes;
        private ReaLTaiizor.Controls.SkyComboBox cbHabitaciones;
        private ReaLTaiizor.Controls.HopeDatePicker dpEntrada;
        private ReaLTaiizor.Controls.HopeDatePicker dpSalida;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lblSalida;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lblCliente;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lblHabitacion;
        private Guna.UI.WinForms.GunaButton btnReservar;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lblReservacionesActivas;
        private Guna.UI.WinForms.GunaButton btnCancelar;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lblCancelarReservacion;
    }
}