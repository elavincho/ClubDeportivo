namespace PrevioClubDeportivo.InterfazGrafica
{
    partial class frmComprobantePago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComprobantePago));
            this.picBanner = new System.Windows.Forms.PictureBox();
            this.picLateral = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblNroComprobante = new System.Windows.Forms.Label();
            this.txtNroComprobante = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNroSocio = new System.Windows.Forms.TextBox();
            this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblImporte = new System.Windows.Forms.Label();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblActividad = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblNroSocio = new System.Windows.Forms.Label();
            this.txtActividad = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLateral)).BeginInit();
            this.SuspendLayout();
            // 
            // picBanner
            // 
            this.picBanner.Image = ((System.Drawing.Image)(resources.GetObject("picBanner.Image")));
            this.picBanner.Location = new System.Drawing.Point(-1, 0);
            this.picBanner.Name = "picBanner";
            this.picBanner.Size = new System.Drawing.Size(1035, 144);
            this.picBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBanner.TabIndex = 0;
            this.picBanner.TabStop = false;
            // 
            // picLateral
            // 
            this.picLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.picLateral.Location = new System.Drawing.Point(0, 143);
            this.picLateral.Name = "picLateral";
            this.picLateral.Size = new System.Drawing.Size(260, 456);
            this.picLateral.TabIndex = 1;
            this.picLateral.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTitulo.Location = new System.Drawing.Point(294, 174);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(363, 39);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Comprobante de Pago";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblFecha.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblFecha.Location = new System.Drawing.Point(846, 159);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(69, 20);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "FECHA";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(850, 182);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(162, 24);
            this.dtpFecha.TabIndex = 4;
            // 
            // lblNroComprobante
            // 
            this.lblNroComprobante.AutoSize = true;
            this.lblNroComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblNroComprobante.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNroComprobante.Location = new System.Drawing.Point(846, 225);
            this.lblNroComprobante.Name = "lblNroComprobante";
            this.lblNroComprobante.Size = new System.Drawing.Size(166, 20);
            this.lblNroComprobante.TabIndex = 3;
            this.lblNroComprobante.Text = "N° COMPROBANTE";
            // 
            // txtNroComprobante
            // 
            this.txtNroComprobante.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.txtNroComprobante.Location = new System.Drawing.Point(850, 248);
            this.txtNroComprobante.Name = "txtNroComprobante";
            this.txtNroComprobante.Size = new System.Drawing.Size(162, 25);
            this.txtNroComprobante.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.txtNombre.Location = new System.Drawing.Point(392, 400);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(224, 25);
            this.txtNombre.TabIndex = 18;
            // 
            // txtImporte
            // 
            this.txtImporte.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.txtImporte.Location = new System.Drawing.Point(392, 451);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(224, 25);
            this.txtImporte.TabIndex = 19;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.txtApellido.Location = new System.Drawing.Point(788, 400);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(224, 25);
            this.txtApellido.TabIndex = 20;
            // 
            // txtNroSocio
            // 
            this.txtNroSocio.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.txtNroSocio.Location = new System.Drawing.Point(392, 349);
            this.txtNroSocio.Name = "txtNroSocio";
            this.txtNroSocio.Size = new System.Drawing.Size(224, 25);
            this.txtNroSocio.TabIndex = 21;
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dtpVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimiento.Location = new System.Drawing.Point(788, 452);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(224, 24);
            this.dtpVencimiento.TabIndex = 17;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNombre.Location = new System.Drawing.Point(301, 405);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(85, 20);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "NOMBRE";
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporte.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblImporte.Location = new System.Drawing.Point(298, 456);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(88, 20);
            this.lblImporte.TabIndex = 11;
            this.lblImporte.Text = "IMPORTE";
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblVencimiento.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblVencimiento.Location = new System.Drawing.Point(652, 456);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(130, 20);
            this.lblVencimiento.TabIndex = 12;
            this.lblVencimiento.Text = "VENCIMIENTO";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblApellido.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblApellido.Location = new System.Drawing.Point(685, 405);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(96, 20);
            this.lblApellido.TabIndex = 13;
            this.lblApellido.Text = "APELLIDO";
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblActividad.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblActividad.Location = new System.Drawing.Point(676, 357);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(105, 20);
            this.lblActividad.TabIndex = 14;
            this.lblActividad.Text = "ACTIVIDAD";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTipo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTipo.Location = new System.Drawing.Point(732, 312);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(49, 20);
            this.lblTipo.TabIndex = 15;
            this.lblTipo.Text = "TIPO";
            // 
            // lblNroSocio
            // 
            this.lblNroSocio.AutoSize = true;
            this.lblNroSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblNroSocio.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNroSocio.Location = new System.Drawing.Point(298, 354);
            this.lblNroSocio.Name = "lblNroSocio";
            this.lblNroSocio.Size = new System.Drawing.Size(88, 20);
            this.lblNroSocio.TabIndex = 16;
            this.lblNroSocio.Text = "N° SOCIO";
            // 
            // txtActividad
            // 
            this.txtActividad.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.txtActividad.Location = new System.Drawing.Point(787, 352);
            this.txtActividad.Name = "txtActividad";
            this.txtActividad.Size = new System.Drawing.Size(224, 25);
            this.txtActividad.TabIndex = 20;
            // 
            // txtTipo
            // 
            this.txtTipo.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.txtTipo.Location = new System.Drawing.Point(787, 307);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(224, 25);
            this.txtTipo.TabIndex = 20;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.ForestGreen;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Location = new System.Drawing.Point(815, 510);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(138, 36);
            this.btnImprimir.TabIndex = 22;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Firebrick;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(392, 510);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(138, 36);
            this.btnCerrar.TabIndex = 23;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // frmComprobantePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1034, 591);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtActividad);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNroSocio);
            this.Controls.Add(this.dtpVencimiento);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.lblVencimiento);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblActividad);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblNroSocio);
            this.Controls.Add(this.txtNroComprobante);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblNroComprobante);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.picLateral);
            this.Controls.Add(this.picBanner);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1050, 630);
            this.MinimumSize = new System.Drawing.Size(1050, 630);
            this.Name = "frmComprobantePago";
            this.Text = "Comprobante de Pago";
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLateral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBanner;
        private System.Windows.Forms.PictureBox picLateral;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblNroComprobante;
        private System.Windows.Forms.TextBox txtNroComprobante;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNroSocio;
        private System.Windows.Forms.DateTimePicker dtpVencimiento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.Label lblVencimiento;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblNroSocio;
        private System.Windows.Forms.TextBox txtActividad;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnCerrar;
    }
}