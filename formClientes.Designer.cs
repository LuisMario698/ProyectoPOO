namespace Proyecto
{
    partial class formClientes
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
            this.tcClientes = new ReaLTaiizor.Controls.HopeTabPage();
            this.tabConsultar = new System.Windows.Forms.TabPage();
            this.dgvClientes = new Guna.UI.WinForms.GunaDataGridView();
            this.tabRegistrar = new System.Windows.Forms.TabPage();
            this.pb = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.pb1 = new Guna.UI.WinForms.GunaPictureBox();
            this.lblIdentificacion = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.lblCorreo = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.lblTelefono = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.lblNombre = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.txtTelefono = new Guna.UI.WinForms.GunaTextBox();
            this.txtCorreo = new Guna.UI.WinForms.GunaTextBox();
            this.txtNombre = new Guna.UI.WinForms.GunaTextBox();
            this.tabModificar = new System.Windows.Forms.TabPage();
            this.tabEliminar = new System.Windows.Forms.TabPage();
            this.btnRegistrar = new Guna.UI.WinForms.GunaButton();
            this.tcClientes.SuspendLayout();
            this.tabConsultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.tabRegistrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcClientes
            // 
            this.tcClientes.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.tcClientes.Controls.Add(this.tabConsultar);
            this.tcClientes.Controls.Add(this.tabRegistrar);
            this.tcClientes.Controls.Add(this.tabModificar);
            this.tcClientes.Controls.Add(this.tabEliminar);
            this.tcClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcClientes.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tcClientes.ForeColorA = System.Drawing.Color.Silver;
            this.tcClientes.ForeColorB = System.Drawing.Color.Gray;
            this.tcClientes.ForeColorC = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tcClientes.ItemSize = new System.Drawing.Size(120, 40);
            this.tcClientes.Location = new System.Drawing.Point(0, 0);
            this.tcClientes.Name = "tcClientes";
            this.tcClientes.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.tcClientes.SelectedIndex = 0;
            this.tcClientes.Size = new System.Drawing.Size(596, 406);
            this.tcClientes.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcClientes.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.tcClientes.TabIndex = 6;
            this.tcClientes.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.tcClientes.ThemeColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.tcClientes.ThemeColorB = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.tcClientes.TitleTextState = ReaLTaiizor.Controls.HopeTabPage.TextState.Upper;
            // 
            // tabConsultar
            // 
            this.tabConsultar.Controls.Add(this.dgvClientes);
            this.tabConsultar.Location = new System.Drawing.Point(0, 40);
            this.tabConsultar.Name = "tabConsultar";
            this.tabConsultar.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultar.Size = new System.Drawing.Size(596, 366);
            this.tabConsultar.TabIndex = 0;
            this.tabConsultar.Text = "Consultar";
            this.tabConsultar.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientes.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClientes.EnableHeadersVisualStyles = false;
            this.dgvClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvClientes.Location = new System.Drawing.Point(12, 49);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(243, 146);
            this.dgvClientes.TabIndex = 20;
            this.dgvClientes.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvClientes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvClientes.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvClientes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvClientes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvClientes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvClientes.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvClientes.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvClientes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvClientes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvClientes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dgvClientes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvClientes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvClientes.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvClientes.ThemeStyle.ReadOnly = false;
            this.dgvClientes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvClientes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvClientes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dgvClientes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvClientes.ThemeStyle.RowsStyle.Height = 22;
            this.dgvClientes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvClientes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // tabRegistrar
            // 
            this.tabRegistrar.Controls.Add(this.btnRegistrar);
            this.tabRegistrar.Controls.Add(this.pb);
            this.tabRegistrar.Controls.Add(this.pb1);
            this.tabRegistrar.Controls.Add(this.lblIdentificacion);
            this.tabRegistrar.Controls.Add(this.lblCorreo);
            this.tabRegistrar.Controls.Add(this.lblTelefono);
            this.tabRegistrar.Controls.Add(this.lblNombre);
            this.tabRegistrar.Controls.Add(this.txtTelefono);
            this.tabRegistrar.Controls.Add(this.txtCorreo);
            this.tabRegistrar.Controls.Add(this.txtNombre);
            this.tabRegistrar.Location = new System.Drawing.Point(0, 40);
            this.tabRegistrar.Name = "tabRegistrar";
            this.tabRegistrar.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistrar.Size = new System.Drawing.Size(596, 366);
            this.tabRegistrar.TabIndex = 1;
            this.tabRegistrar.Text = "Registrar";
            this.tabRegistrar.UseVisualStyleBackColor = true;
            // 
            // pb
            // 
            this.pb.BaseColor = System.Drawing.Color.Black;
            this.pb.Location = new System.Drawing.Point(327, 55);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(187, 122);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb.TabIndex = 28;
            this.pb.TabStop = false;
            // 
            // pb1
            // 
            this.pb1.BaseColor = System.Drawing.Color.White;
            this.pb1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb1.Location = new System.Drawing.Point(133, 129);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(41, 39);
            this.pb1.TabIndex = 27;
            this.pb1.TabStop = false;
            this.pb1.Click += new System.EventHandler(this.pb1_Click);
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.BackColor = System.Drawing.Color.Transparent;
            this.lblIdentificacion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblIdentificacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lblIdentificacion.Location = new System.Drawing.Point(19, 137);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(108, 20);
            this.lblIdentificacion.TabIndex = 26;
            this.lblIdentificacion.Text = "Identificacion:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lblCorreo.Location = new System.Drawing.Point(19, 55);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(60, 20);
            this.lblCorreo.TabIndex = 25;
            this.lblCorreo.Text = "Correo:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lblTelefono.Location = new System.Drawing.Point(19, 91);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(74, 20);
            this.lblTelefono.TabIndex = 24;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lblNombre.Location = new System.Drawing.Point(19, 19);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(71, 20);
            this.lblNombre.TabIndex = 23;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BaseColor = System.Drawing.Color.White;
            this.txtTelefono.BorderColor = System.Drawing.Color.Silver;
            this.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefono.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTelefono.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTelefono.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTelefono.Location = new System.Drawing.Point(96, 86);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.Size = new System.Drawing.Size(160, 30);
            this.txtTelefono.TabIndex = 22;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BaseColor = System.Drawing.Color.White;
            this.txtCorreo.BorderColor = System.Drawing.Color.Silver;
            this.txtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCorreo.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCorreo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCorreo.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCorreo.Location = new System.Drawing.Point(96, 50);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PasswordChar = '\0';
            this.txtCorreo.SelectedText = "";
            this.txtCorreo.Size = new System.Drawing.Size(160, 30);
            this.txtCorreo.TabIndex = 21;
            // 
            // txtNombre
            // 
            this.txtNombre.BaseColor = System.Drawing.Color.White;
            this.txtNombre.BorderColor = System.Drawing.Color.Silver;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNombre.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNombre.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombre.Location = new System.Drawing.Point(96, 14);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.SelectedText = "";
            this.txtNombre.Size = new System.Drawing.Size(160, 30);
            this.txtNombre.TabIndex = 20;
            // 
            // tabModificar
            // 
            this.tabModificar.Location = new System.Drawing.Point(0, 40);
            this.tabModificar.Name = "tabModificar";
            this.tabModificar.Padding = new System.Windows.Forms.Padding(3);
            this.tabModificar.Size = new System.Drawing.Size(596, 366);
            this.tabModificar.TabIndex = 2;
            this.tabModificar.Text = "Modificar";
            this.tabModificar.UseVisualStyleBackColor = true;
            // 
            // tabEliminar
            // 
            this.tabEliminar.Location = new System.Drawing.Point(0, 40);
            this.tabEliminar.Name = "tabEliminar";
            this.tabEliminar.Padding = new System.Windows.Forms.Padding(3);
            this.tabEliminar.Size = new System.Drawing.Size(596, 366);
            this.tabEliminar.TabIndex = 3;
            this.tabEliminar.Text = "Eliminar";
            this.tabEliminar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.AnimationHoverSpeed = 0.07F;
            this.btnRegistrar.AnimationSpeed = 0.03F;
            this.btnRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnRegistrar.BorderColor = System.Drawing.Color.Black;
            this.btnRegistrar.BorderSize = 1;
            this.btnRegistrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRegistrar.FocusedColor = System.Drawing.Color.Empty;
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Image = null;
            this.btnRegistrar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRegistrar.Location = new System.Drawing.Point(219, 234);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnRegistrar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRegistrar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRegistrar.OnHoverImage = null;
            this.btnRegistrar.OnPressedColor = System.Drawing.Color.Black;
            this.btnRegistrar.Radius = 10;
            this.btnRegistrar.Size = new System.Drawing.Size(124, 42);
            this.btnRegistrar.TabIndex = 29;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // formClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 406);
            this.Controls.Add(this.tcClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formClientes";
            this.Text = "formClientes";
            this.Load += new System.EventHandler(this.formClientes_Load);
            this.tcClientes.ResumeLayout(false);
            this.tabConsultar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.tabRegistrar.ResumeLayout(false);
            this.tabRegistrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.HopeTabPage tcClientes;
        private System.Windows.Forms.TabPage tabConsultar;
        private System.Windows.Forms.TabPage tabRegistrar;
        private System.Windows.Forms.TabPage tabModificar;
        private System.Windows.Forms.TabPage tabEliminar;
        private Guna.UI.WinForms.GunaDataGridView dgvClientes;
        private Guna.UI.WinForms.GunaPictureBox pb1;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lblIdentificacion;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lblCorreo;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lblTelefono;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lblNombre;
        private Guna.UI.WinForms.GunaTextBox txtTelefono;
        private Guna.UI.WinForms.GunaTextBox txtCorreo;
        private Guna.UI.WinForms.GunaTextBox txtNombre;
        private Guna.UI.WinForms.GunaTransfarantPictureBox pb;
        private Guna.UI.WinForms.GunaButton btnRegistrar;
    }
}