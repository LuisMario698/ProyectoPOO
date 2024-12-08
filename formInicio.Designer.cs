namespace Proyecto
{
    partial class formInicio
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
            this.gridTabla = new System.Windows.Forms.TableLayoutPanel();
            this.pnLateral = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHabitaciones = new Guna.UI.WinForms.GunaButton();
            this.btnClientes = new Guna.UI.WinForms.GunaButton();
            this.btnReservas = new Guna.UI.WinForms.GunaButton();
            this.btnPagos = new Guna.UI.WinForms.GunaButton();
            this.btnReportes = new Guna.UI.WinForms.GunaButton();
            this.pnExtra = new Guna.UI.WinForms.GunaPanel();
            this.pnLogo = new Guna.UI.WinForms.GunaPanel();
            this.pnTop = new Guna.UI.WinForms.GunaPanel();
            this.pnCuerpo = new Guna.UI.WinForms.GunaPanel();
            this.pnHeader = new ReaLTaiizor.Forms.ParrotForm();
            this.gridTabla.SuspendLayout();
            this.pnLateral.SuspendLayout();
            this.pnHeader.WorkingArea.SuspendLayout();
            this.pnHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridTabla
            // 
            this.gridTabla.BackColor = System.Drawing.Color.White;
            this.gridTabla.ColumnCount = 2;
            this.gridTabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.gridTabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 600F));
            this.gridTabla.Controls.Add(this.pnLateral, 0, 1);
            this.gridTabla.Controls.Add(this.pnLogo, 0, 0);
            this.gridTabla.Controls.Add(this.pnTop, 1, 0);
            this.gridTabla.Controls.Add(this.pnCuerpo, 1, 1);
            this.gridTabla.Location = new System.Drawing.Point(0, 1);
            this.gridTabla.Margin = new System.Windows.Forms.Padding(2);
            this.gridTabla.Name = "gridTabla";
            this.gridTabla.RowCount = 2;
            this.gridTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.gridTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 390F));
            this.gridTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.gridTabla.Size = new System.Drawing.Size(750, 460);
            this.gridTabla.TabIndex = 1;
            // 
            // pnLateral
            // 
            this.pnLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.pnLateral.Controls.Add(this.btnHabitaciones);
            this.pnLateral.Controls.Add(this.btnClientes);
            this.pnLateral.Controls.Add(this.btnReservas);
            this.pnLateral.Controls.Add(this.btnPagos);
            this.pnLateral.Controls.Add(this.btnReportes);
            this.pnLateral.Controls.Add(this.pnExtra);
            this.pnLateral.Location = new System.Drawing.Point(2, 51);
            this.pnLateral.Margin = new System.Windows.Forms.Padding(2);
            this.pnLateral.Name = "pnLateral";
            this.pnLateral.Size = new System.Drawing.Size(146, 407);
            this.pnLateral.TabIndex = 1;
            // 
            // btnHabitaciones
            // 
            this.btnHabitaciones.AnimationHoverSpeed = 0.07F;
            this.btnHabitaciones.AnimationSpeed = 0.03F;
            this.btnHabitaciones.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnHabitaciones.BorderColor = System.Drawing.Color.Black;
            this.btnHabitaciones.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHabitaciones.FocusedColor = System.Drawing.Color.Empty;
            this.btnHabitaciones.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHabitaciones.ForeColor = System.Drawing.Color.White;
            this.btnHabitaciones.Image = null;
            this.btnHabitaciones.ImageSize = new System.Drawing.Size(20, 20);
            this.btnHabitaciones.Location = new System.Drawing.Point(2, 2);
            this.btnHabitaciones.Margin = new System.Windows.Forms.Padding(2);
            this.btnHabitaciones.Name = "btnHabitaciones";
            this.btnHabitaciones.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(102)))), ((int)(((byte)(131)))));
            this.btnHabitaciones.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnHabitaciones.OnHoverForeColor = System.Drawing.Color.White;
            this.btnHabitaciones.OnHoverImage = null;
            this.btnHabitaciones.OnPressedColor = System.Drawing.Color.Black;
            this.btnHabitaciones.Size = new System.Drawing.Size(141, 67);
            this.btnHabitaciones.TabIndex = 0;
            this.btnHabitaciones.Text = "Habitaciones";
            this.btnHabitaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnHabitaciones.Click += new System.EventHandler(this.btnHabitaciones_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.AnimationHoverSpeed = 0.07F;
            this.btnClientes.AnimationSpeed = 0.03F;
            this.btnClientes.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnClientes.BorderColor = System.Drawing.Color.Black;
            this.btnClientes.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClientes.FocusedColor = System.Drawing.Color.Empty;
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Image = null;
            this.btnClientes.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClientes.Location = new System.Drawing.Point(2, 73);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(2);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(102)))), ((int)(((byte)(131)))));
            this.btnClientes.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClientes.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClientes.OnHoverImage = null;
            this.btnClientes.OnPressedColor = System.Drawing.Color.Black;
            this.btnClientes.Size = new System.Drawing.Size(141, 67);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnReservas
            // 
            this.btnReservas.AnimationHoverSpeed = 0.07F;
            this.btnReservas.AnimationSpeed = 0.03F;
            this.btnReservas.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnReservas.BorderColor = System.Drawing.Color.Black;
            this.btnReservas.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReservas.FocusedColor = System.Drawing.Color.Empty;
            this.btnReservas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReservas.ForeColor = System.Drawing.Color.White;
            this.btnReservas.Image = null;
            this.btnReservas.ImageSize = new System.Drawing.Size(20, 20);
            this.btnReservas.Location = new System.Drawing.Point(2, 144);
            this.btnReservas.Margin = new System.Windows.Forms.Padding(2);
            this.btnReservas.Name = "btnReservas";
            this.btnReservas.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(102)))), ((int)(((byte)(131)))));
            this.btnReservas.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReservas.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReservas.OnHoverImage = null;
            this.btnReservas.OnPressedColor = System.Drawing.Color.Black;
            this.btnReservas.Size = new System.Drawing.Size(141, 67);
            this.btnReservas.TabIndex = 2;
            this.btnReservas.Text = "Reservas";
            this.btnReservas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReservas.Click += new System.EventHandler(this.btnReservas_Click);
            // 
            // btnPagos
            // 
            this.btnPagos.AnimationHoverSpeed = 0.07F;
            this.btnPagos.AnimationSpeed = 0.03F;
            this.btnPagos.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnPagos.BorderColor = System.Drawing.Color.Black;
            this.btnPagos.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPagos.FocusedColor = System.Drawing.Color.Empty;
            this.btnPagos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPagos.ForeColor = System.Drawing.Color.White;
            this.btnPagos.Image = null;
            this.btnPagos.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPagos.Location = new System.Drawing.Point(2, 215);
            this.btnPagos.Margin = new System.Windows.Forms.Padding(2);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(102)))), ((int)(((byte)(131)))));
            this.btnPagos.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPagos.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPagos.OnHoverImage = null;
            this.btnPagos.OnPressedColor = System.Drawing.Color.Black;
            this.btnPagos.Size = new System.Drawing.Size(141, 67);
            this.btnPagos.TabIndex = 3;
            this.btnPagos.Text = "Pagos";
            this.btnPagos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.AnimationHoverSpeed = 0.07F;
            this.btnReportes.AnimationSpeed = 0.03F;
            this.btnReportes.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnReportes.BorderColor = System.Drawing.Color.Black;
            this.btnReportes.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReportes.FocusedColor = System.Drawing.Color.Empty;
            this.btnReportes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.Image = null;
            this.btnReportes.ImageSize = new System.Drawing.Size(20, 20);
            this.btnReportes.Location = new System.Drawing.Point(2, 286);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(2);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(102)))), ((int)(((byte)(131)))));
            this.btnReportes.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReportes.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReportes.OnHoverImage = null;
            this.btnReportes.OnPressedColor = System.Drawing.Color.Black;
            this.btnReportes.Size = new System.Drawing.Size(141, 67);
            this.btnReportes.TabIndex = 4;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // pnExtra
            // 
            this.pnExtra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.pnExtra.Location = new System.Drawing.Point(2, 357);
            this.pnExtra.Margin = new System.Windows.Forms.Padding(2);
            this.pnExtra.Name = "pnExtra";
            this.pnExtra.Size = new System.Drawing.Size(141, 52);
            this.pnExtra.TabIndex = 5;
            // 
            // pnLogo
            // 
            this.pnLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.pnLogo.Location = new System.Drawing.Point(2, 2);
            this.pnLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Size = new System.Drawing.Size(146, 44);
            this.pnLogo.TabIndex = 2;
            // 
            // pnTop
            // 
            this.pnTop.Location = new System.Drawing.Point(152, 2);
            this.pnTop.Margin = new System.Windows.Forms.Padding(2);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(596, 44);
            this.pnTop.TabIndex = 3;
            // 
            // pnCuerpo
            // 
            this.pnCuerpo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(219)))), ((int)(((byte)(217)))));
            this.pnCuerpo.Location = new System.Drawing.Point(152, 51);
            this.pnCuerpo.Margin = new System.Windows.Forms.Padding(2);
            this.pnCuerpo.Name = "pnCuerpo";
            this.pnCuerpo.Size = new System.Drawing.Size(596, 406);
            this.pnCuerpo.TabIndex = 4;
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnHeader.ExitApplication = true;
            this.pnHeader.FormStyle = ReaLTaiizor.Forms.ParrotForm.Style.Ubuntu;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.MacOSForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnHeader.MacOSLeftBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pnHeader.MacOSRightBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.pnHeader.MacOSSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.pnHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnHeader.MaterialBackColor = System.Drawing.Color.DodgerBlue;
            this.pnHeader.MaterialForeColor = System.Drawing.Color.White;
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnHeader.ShowMaximize = true;
            this.pnHeader.ShowMinimize = true;
            this.pnHeader.Size = new System.Drawing.Size(750, 490);
            this.pnHeader.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.pnHeader.TabIndex = 2;
            this.pnHeader.TitleText = "";
            this.pnHeader.UbuntuForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(210)))));
            this.pnHeader.UbuntuLeftBackColor = System.Drawing.Color.White;
            this.pnHeader.UbuntuRightBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(228)))));
            // 
            // pnHeader.WorkingArea
            // 
            this.pnHeader.WorkingArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pnHeader.WorkingArea.Controls.Add(this.gridTabla);
            this.pnHeader.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnHeader.WorkingArea.Location = new System.Drawing.Point(0, 30);
            this.pnHeader.WorkingArea.Margin = new System.Windows.Forms.Padding(2);
            this.pnHeader.WorkingArea.Name = "WorkingArea";
            this.pnHeader.WorkingArea.Size = new System.Drawing.Size(750, 460);
            this.pnHeader.WorkingArea.TabIndex = 0;
            // 
            // formInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 490);
            this.Controls.Add(this.pnHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1440, 829);
            this.MinimumSize = new System.Drawing.Size(142, 32);
            this.Name = "formInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.formInicio_Load);
            this.gridTabla.ResumeLayout(false);
            this.pnLateral.ResumeLayout(false);
            this.pnHeader.WorkingArea.ResumeLayout(false);
            this.pnHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel gridTabla;
        private Guna.UI.WinForms.GunaButton btnHabitaciones;
        private System.Windows.Forms.FlowLayoutPanel pnLateral;
        private Guna.UI.WinForms.GunaButton btnClientes;
        private Guna.UI.WinForms.GunaButton btnReservas;
        private Guna.UI.WinForms.GunaButton btnPagos;
        private Guna.UI.WinForms.GunaButton btnReportes;
        private Guna.UI.WinForms.GunaPanel pnExtra;
        private Guna.UI.WinForms.GunaPanel pnLogo;
        private Guna.UI.WinForms.GunaPanel pnTop;
        private Guna.UI.WinForms.GunaPanel pnCuerpo;
        private ReaLTaiizor.Forms.ParrotForm pnHeader;
    }
}