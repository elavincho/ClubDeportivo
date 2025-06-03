namespace PrevioClubDeportivo.InterfazGrafica
{
    partial class frmCobrarCuota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCobrarCuota));
            this.picBanner = new System.Windows.Forms.PictureBox();
            this.picFondoBoton = new System.Windows.Forms.PictureBox();
            this.lblCobrarCuota = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblNroComprobante = new System.Windows.Forms.Label();
            this.txtNroComprobante = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNroSocio = new System.Windows.Forms.Label();
            this.txtNroSocio = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.lblActividad = new System.Windows.Forms.Label();
            this.lstActividad = new System.Windows.Forms.ListBox();
            this.rbEfectivo = new System.Windows.Forms.RadioButton();
            this.gbTipo = new System.Windows.Forms.GroupBox();
            this.rbDiaria = new System.Windows.Forms.RadioButton();
            this.rbMensual = new System.Windows.Forms.RadioButton();
            this.gbMetodoPago = new System.Windows.Forms.GroupBox();
            this.rbQR = new System.Windows.Forms.RadioButton();
            this.rbTarjeta = new System.Windows.Forms.RadioButton();
            this.gbCuotas = new System.Windows.Forms.GroupBox();
            this.lstCuotas = new System.Windows.Forms.ListBox();
            this.gbImporte = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFondoBoton)).BeginInit();
            this.gbTipo.SuspendLayout();
            this.gbMetodoPago.SuspendLayout();
            this.gbCuotas.SuspendLayout();
            this.gbImporte.SuspendLayout();
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
            // picFondoBoton
            // 
            this.picFondoBoton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.picFondoBoton.Location = new System.Drawing.Point(0, 143);
            this.picFondoBoton.Name = "picFondoBoton";
            this.picFondoBoton.Size = new System.Drawing.Size(100, 456);
            this.picFondoBoton.TabIndex = 1;
            this.picFondoBoton.TabStop = false;
            // 
            // lblCobrarCuota
            // 
            this.lblCobrarCuota.AutoSize = true;
            this.lblCobrarCuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.lblCobrarCuota.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCobrarCuota.Location = new System.Drawing.Point(143, 164);
            this.lblCobrarCuota.Name = "lblCobrarCuota";
            this.lblCobrarCuota.Size = new System.Drawing.Size(224, 39);
            this.lblCobrarCuota.TabIndex = 2;
            this.lblCobrarCuota.Text = "Cobrar Cuota";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblFecha.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblFecha.Location = new System.Drawing.Point(663, 159);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(69, 20);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "FECHA";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(667, 182);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(162, 24);
            this.dtpFecha.TabIndex = 5;
            // 
            // lblNroComprobante
            // 
            this.lblNroComprobante.AutoSize = true;
            this.lblNroComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblNroComprobante.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNroComprobante.Location = new System.Drawing.Point(844, 158);
            this.lblNroComprobante.Name = "lblNroComprobante";
            this.lblNroComprobante.Size = new System.Drawing.Size(166, 20);
            this.lblNroComprobante.TabIndex = 4;
            this.lblNroComprobante.Text = "N° COMPROBANTE";
            // 
            // txtNroComprobante
            // 
            this.txtNroComprobante.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.txtNroComprobante.Location = new System.Drawing.Point(848, 181);
            this.txtNroComprobante.Name = "txtNroComprobante";
            this.txtNroComprobante.ReadOnly = true;
            this.txtNroComprobante.Size = new System.Drawing.Size(162, 25);
            this.txtNroComprobante.TabIndex = 6;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblApellido.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblApellido.Location = new System.Drawing.Point(142, 356);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(96, 20);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "APELLIDO";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.txtApellido.Location = new System.Drawing.Point(245, 351);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ReadOnly = true;
            this.txtApellido.Size = new System.Drawing.Size(224, 25);
            this.txtApellido.TabIndex = 6;
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblVencimiento.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblVencimiento.Location = new System.Drawing.Point(682, 447);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(130, 20);
            this.lblVencimiento.TabIndex = 4;
            this.lblVencimiento.Text = "VENCIMIENTO";
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dtpVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVencimiento.Location = new System.Drawing.Point(815, 444);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(162, 24);
            this.dtpVencimiento.TabIndex = 5;
            // 
            // txtImporte
            // 
            this.txtImporte.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.txtImporte.Location = new System.Drawing.Point(14, 38);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.ReadOnly = true;
            this.txtImporte.Size = new System.Drawing.Size(136, 25);
            this.txtImporte.TabIndex = 6;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNombre.Location = new System.Drawing.Point(154, 310);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(85, 20);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "NOMBRE";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.txtNombre.Location = new System.Drawing.Point(245, 305);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(224, 25);
            this.txtNombre.TabIndex = 6;
            // 
            // lblNroSocio
            // 
            this.lblNroSocio.AutoSize = true;
            this.lblNroSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblNroSocio.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNroSocio.Location = new System.Drawing.Point(151, 262);
            this.lblNroSocio.Name = "lblNroSocio";
            this.lblNroSocio.Size = new System.Drawing.Size(88, 20);
            this.lblNroSocio.TabIndex = 4;
            this.lblNroSocio.Text = "N° SOCIO";
            // 
            // txtNroSocio
            // 
            this.txtNroSocio.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.txtNroSocio.Location = new System.Drawing.Point(245, 257);
            this.txtNroSocio.Name = "txtNroSocio";
            this.txtNroSocio.Size = new System.Drawing.Size(224, 25);
            this.txtNroSocio.TabIndex = 6;
            this.txtNroSocio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroSocio_KeyPress);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(293, 512);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(138, 36);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "VOLVER";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCobrar
            // 
            this.btnCobrar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobrar.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCobrar.ForeColor = System.Drawing.Color.White;
            this.btnCobrar.Location = new System.Drawing.Point(716, 512);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(138, 36);
            this.btnCobrar.TabIndex = 8;
            this.btnCobrar.Text = "COBRAR";
            this.btnCobrar.UseVisualStyleBackColor = false;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblActividad.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblActividad.Location = new System.Drawing.Point(133, 398);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(105, 20);
            this.lblActividad.TabIndex = 4;
            this.lblActividad.Text = "ACTIVIDAD";
            // 
            // lstActividad
            // 
            this.lstActividad.Font = new System.Drawing.Font("Gadugi", 12F);
            this.lstActividad.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lstActividad.FormattingEnabled = true;
            this.lstActividad.ItemHeight = 19;
            this.lstActividad.Location = new System.Drawing.Point(245, 395);
            this.lstActividad.Name = "lstActividad";
            this.lstActividad.Size = new System.Drawing.Size(224, 23);
            this.lstActividad.TabIndex = 9;
            // 
            // rbEfectivo
            // 
            this.rbEfectivo.AutoSize = true;
            this.rbEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEfectivo.Location = new System.Drawing.Point(11, 46);
            this.rbEfectivo.Name = "rbEfectivo";
            this.rbEfectivo.Size = new System.Drawing.Size(91, 20);
            this.rbEfectivo.TabIndex = 11;
            this.rbEfectivo.TabStop = true;
            this.rbEfectivo.Text = "EFECTIVO";
            this.rbEfectivo.UseVisualStyleBackColor = true;
            this.rbEfectivo.CheckedChanged += new System.EventHandler(this.rbEfectivo_CheckedChanged);
            // 
            // gbTipo
            // 
            this.gbTipo.Controls.Add(this.rbDiaria);
            this.gbTipo.Controls.Add(this.rbMensual);
            this.gbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.gbTipo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gbTipo.Location = new System.Drawing.Point(490, 248);
            this.gbTipo.Name = "gbTipo";
            this.gbTipo.Size = new System.Drawing.Size(115, 170);
            this.gbTipo.TabIndex = 12;
            this.gbTipo.TabStop = false;
            this.gbTipo.Text = "TIPO";
            // 
            // rbDiaria
            // 
            this.rbDiaria.AutoSize = true;
            this.rbDiaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.rbDiaria.Location = new System.Drawing.Point(10, 103);
            this.rbDiaria.Name = "rbDiaria";
            this.rbDiaria.Size = new System.Drawing.Size(69, 20);
            this.rbDiaria.TabIndex = 0;
            this.rbDiaria.TabStop = true;
            this.rbDiaria.Text = "DIARIA";
            this.rbDiaria.UseVisualStyleBackColor = true;
            this.rbDiaria.CheckedChanged += new System.EventHandler(this.rbDiaria_CheckedChanged);
            // 
            // rbMensual
            // 
            this.rbMensual.AutoSize = true;
            this.rbMensual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.rbMensual.Location = new System.Drawing.Point(10, 46);
            this.rbMensual.Name = "rbMensual";
            this.rbMensual.Size = new System.Drawing.Size(90, 20);
            this.rbMensual.TabIndex = 0;
            this.rbMensual.TabStop = true;
            this.rbMensual.Text = "MENSUAL";
            this.rbMensual.UseVisualStyleBackColor = true;
            this.rbMensual.CheckedChanged += new System.EventHandler(this.rbMensual_CheckedChanged);
            // 
            // gbMetodoPago
            // 
            this.gbMetodoPago.Controls.Add(this.rbQR);
            this.gbMetodoPago.Controls.Add(this.rbTarjeta);
            this.gbMetodoPago.Controls.Add(this.rbEfectivo);
            this.gbMetodoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.gbMetodoPago.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gbMetodoPago.Location = new System.Drawing.Point(631, 248);
            this.gbMetodoPago.Name = "gbMetodoPago";
            this.gbMetodoPago.Size = new System.Drawing.Size(162, 170);
            this.gbMetodoPago.TabIndex = 13;
            this.gbMetodoPago.TabStop = false;
            this.gbMetodoPago.Text = "METODO PAGO";
            // 
            // rbQR
            // 
            this.rbQR.AutoSize = true;
            this.rbQR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbQR.Location = new System.Drawing.Point(11, 126);
            this.rbQR.Name = "rbQR";
            this.rbQR.Size = new System.Drawing.Size(45, 20);
            this.rbQR.TabIndex = 13;
            this.rbQR.TabStop = true;
            this.rbQR.Text = "QR";
            this.rbQR.UseVisualStyleBackColor = true;
            this.rbQR.CheckedChanged += new System.EventHandler(this.rbQR_CheckedChanged);
            // 
            // rbTarjeta
            // 
            this.rbTarjeta.AutoSize = true;
            this.rbTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTarjeta.Location = new System.Drawing.Point(11, 88);
            this.rbTarjeta.Name = "rbTarjeta";
            this.rbTarjeta.Size = new System.Drawing.Size(87, 20);
            this.rbTarjeta.TabIndex = 12;
            this.rbTarjeta.TabStop = true;
            this.rbTarjeta.Text = "TARJETA";
            this.rbTarjeta.UseVisualStyleBackColor = true;
            this.rbTarjeta.CheckedChanged += new System.EventHandler(this.rbTarjeta_CheckedChanged);
            // 
            // gbCuotas
            // 
            this.gbCuotas.Controls.Add(this.lstCuotas);
            this.gbCuotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.gbCuotas.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gbCuotas.Location = new System.Drawing.Point(815, 248);
            this.gbCuotas.Name = "gbCuotas";
            this.gbCuotas.Size = new System.Drawing.Size(162, 82);
            this.gbCuotas.TabIndex = 14;
            this.gbCuotas.TabStop = false;
            this.gbCuotas.Text = "CUOTAS";
            // 
            // lstCuotas
            // 
            this.lstCuotas.Font = new System.Drawing.Font("Gadugi", 12F);
            this.lstCuotas.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lstCuotas.FormattingEnabled = true;
            this.lstCuotas.ItemHeight = 19;
            this.lstCuotas.Location = new System.Drawing.Point(14, 36);
            this.lstCuotas.Name = "lstCuotas";
            this.lstCuotas.Size = new System.Drawing.Size(136, 23);
            this.lstCuotas.TabIndex = 15;
            // 
            // gbImporte
            // 
            this.gbImporte.Controls.Add(this.txtImporte);
            this.gbImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.gbImporte.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gbImporte.Location = new System.Drawing.Point(815, 336);
            this.gbImporte.Name = "gbImporte";
            this.gbImporte.Size = new System.Drawing.Size(162, 82);
            this.gbImporte.TabIndex = 16;
            this.gbImporte.TabStop = false;
            this.gbImporte.Text = "IMPORTE";
            // 
            // frmCobrarCuota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1034, 591);
            this.Controls.Add(this.gbImporte);
            this.Controls.Add(this.gbCuotas);
            this.Controls.Add(this.gbMetodoPago);
            this.Controls.Add(this.lstActividad);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNroSocio);
            this.Controls.Add(this.txtNroComprobante);
            this.Controls.Add(this.dtpVencimiento);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblVencimiento);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblActividad);
            this.Controls.Add(this.lblNroSocio);
            this.Controls.Add(this.lblNroComprobante);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblCobrarCuota);
            this.Controls.Add(this.picFondoBoton);
            this.Controls.Add(this.picBanner);
            this.Controls.Add(this.gbTipo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1050, 630);
            this.MinimumSize = new System.Drawing.Size(1050, 630);
            this.Name = "frmCobrarCuota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cobrar Cuota";
            this.Load += new System.EventHandler(this.frmCobrarCuota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFondoBoton)).EndInit();
            this.gbTipo.ResumeLayout(false);
            this.gbTipo.PerformLayout();
            this.gbMetodoPago.ResumeLayout(false);
            this.gbMetodoPago.PerformLayout();
            this.gbCuotas.ResumeLayout(false);
            this.gbImporte.ResumeLayout(false);
            this.gbImporte.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBanner;
        private System.Windows.Forms.PictureBox picFondoBoton;
        private System.Windows.Forms.Label lblCobrarCuota;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblNroComprobante;
        private System.Windows.Forms.TextBox txtNroComprobante;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblVencimiento;
        private System.Windows.Forms.DateTimePicker dtpVencimiento;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNroSocio;
        private System.Windows.Forms.TextBox txtNroSocio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.ListBox lstActividad;
        private System.Windows.Forms.RadioButton rbEfectivo;
        private System.Windows.Forms.GroupBox gbTipo;
        private System.Windows.Forms.GroupBox gbMetodoPago;
        private System.Windows.Forms.RadioButton rbTarjeta;
        private System.Windows.Forms.GroupBox gbCuotas;
        private System.Windows.Forms.ListBox lstCuotas;
        private System.Windows.Forms.GroupBox gbImporte;
        private System.Windows.Forms.RadioButton rbDiaria;
        private System.Windows.Forms.RadioButton rbMensual;
        private System.Windows.Forms.RadioButton rbQR;
    }
}