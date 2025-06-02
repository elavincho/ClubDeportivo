namespace PrevioClubDeportivo
{
    partial class frmRegistrarSocio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarSocio));
            this.picBanner = new System.Windows.Forms.PictureBox();
            this.picFondoBoton = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCargarAptoFisico = new System.Windows.Forms.Button();
            this.lblNroSocio = new System.Windows.Forms.Label();
            this.txtNroSocio = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lstTipoSocio = new System.Windows.Forms.ListBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblFecNac = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNroDocumento = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblNroDocumento = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lstTipoDoc = new System.Windows.Forms.ListBox();
            this.dtpFecNac = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblFechaAlta = new System.Windows.Forms.Label();
            this.dtpFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaPago = new System.Windows.Forms.Label();
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.lblEstadoPago = new System.Windows.Forms.Label();
            this.lstEstadoPago = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFondoBoton)).BeginInit();
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
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTitulo.Location = new System.Drawing.Point(143, 164);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(273, 39);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Registrar Socios";
            // 
            // btnCargarAptoFisico
            // 
            this.btnCargarAptoFisico.BackColor = System.Drawing.Color.Moccasin;
            this.btnCargarAptoFisico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarAptoFisico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarAptoFisico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCargarAptoFisico.Location = new System.Drawing.Point(150, 226);
            this.btnCargarAptoFisico.Name = "btnCargarAptoFisico";
            this.btnCargarAptoFisico.Size = new System.Drawing.Size(167, 66);
            this.btnCargarAptoFisico.TabIndex = 4;
            this.btnCargarAptoFisico.Text = "Cargar Apto Físico";
            this.btnCargarAptoFisico.UseVisualStyleBackColor = false;
            this.btnCargarAptoFisico.Click += new System.EventHandler(this.btnCargarAptoFisico_Click);
            // 
            // lblNroSocio
            // 
            this.lblNroSocio.AutoSize = true;
            this.lblNroSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroSocio.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNroSocio.Location = new System.Drawing.Point(754, 198);
            this.lblNroSocio.Name = "lblNroSocio";
            this.lblNroSocio.Size = new System.Drawing.Size(88, 20);
            this.lblNroSocio.TabIndex = 5;
            this.lblNroSocio.Text = "N° SOCIO";
            // 
            // txtNroSocio
            // 
            this.txtNroSocio.BackColor = System.Drawing.Color.White;
            this.txtNroSocio.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroSocio.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtNroSocio.Location = new System.Drawing.Point(848, 195);
            this.txtNroSocio.Name = "txtNroSocio";
            this.txtNroSocio.ReadOnly = true;
            this.txtNroSocio.Size = new System.Drawing.Size(154, 25);
            this.txtNroSocio.TabIndex = 6;
            this.txtNroSocio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTipo.Location = new System.Drawing.Point(793, 228);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(49, 20);
            this.lblTipo.TabIndex = 5;
            this.lblTipo.Text = "TIPO";
            // 
            // lstTipoSocio
            // 
            this.lstTipoSocio.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTipoSocio.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lstTipoSocio.FormattingEnabled = true;
            this.lstTipoSocio.ItemHeight = 19;
            this.lstTipoSocio.Location = new System.Drawing.Point(848, 226);
            this.lstTipoSocio.Name = "lstTipoSocio";
            this.lstTipoSocio.Size = new System.Drawing.Size(154, 23);
            this.lstTipoSocio.TabIndex = 7;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNombre.Location = new System.Drawing.Point(143, 353);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(76, 16);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "NOMBRE:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(225, 348);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(224, 25);
            this.txtNombre.TabIndex = 9;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblApellido.Location = new System.Drawing.Point(689, 357);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(83, 16);
            this.lblApellido.TabIndex = 8;
            this.lblApellido.Text = "APELLIDO:";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(778, 351);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(224, 25);
            this.txtApellido.TabIndex = 9;
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDoc.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTipoDoc.Location = new System.Drawing.Point(137, 395);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(82, 16);
            this.lblTipoDoc.TabIndex = 8;
            this.lblTipoDoc.Text = "TIPO DOC:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(225, 470);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(224, 25);
            this.txtEmail.TabIndex = 9;
            // 
            // lblFecNac
            // 
            this.lblFecNac.AutoSize = true;
            this.lblFecNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecNac.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFecNac.Location = new System.Drawing.Point(140, 435);
            this.lblFecNac.Name = "lblFecNac";
            this.lblFecNac.Size = new System.Drawing.Size(79, 16);
            this.lblFecNac.TabIndex = 8;
            this.lblFecNac.Text = "FEC. NAC:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEmail.Location = new System.Drawing.Point(164, 475);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(55, 16);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "EMAIL:";
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroDocumento.Location = new System.Drawing.Point(778, 394);
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.Size = new System.Drawing.Size(224, 25);
            this.txtNroDocumento.TabIndex = 9;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(778, 437);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(224, 25);
            this.txtDireccion.TabIndex = 9;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(778, 476);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(224, 25);
            this.txtTelefono.TabIndex = 9;
            // 
            // lblNroDocumento
            // 
            this.lblNroDocumento.AutoSize = true;
            this.lblNroDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroDocumento.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNroDocumento.Location = new System.Drawing.Point(644, 400);
            this.lblNroDocumento.Name = "lblNroDocumento";
            this.lblNroDocumento.Size = new System.Drawing.Size(128, 16);
            this.lblNroDocumento.TabIndex = 8;
            this.lblNroDocumento.Text = "N° DOCUMENTO:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDireccion.Location = new System.Drawing.Point(679, 441);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(93, 16);
            this.lblDireccion.TabIndex = 8;
            this.lblDireccion.Text = "DIRECCIÓN:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTelefono.Location = new System.Drawing.Point(679, 481);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(91, 16);
            this.lblTelefono.TabIndex = 8;
            this.lblTelefono.Text = "TELÉFONO:";
            // 
            // lstTipoDoc
            // 
            this.lstTipoDoc.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTipoDoc.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lstTipoDoc.FormattingEnabled = true;
            this.lstTipoDoc.ItemHeight = 22;
            this.lstTipoDoc.Location = new System.Drawing.Point(225, 389);
            this.lstTipoDoc.Name = "lstTipoDoc";
            this.lstTipoDoc.Size = new System.Drawing.Size(224, 26);
            this.lstTipoDoc.TabIndex = 7;
            // 
            // dtpFecNac
            // 
            this.dtpFecNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecNac.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecNac.Location = new System.Drawing.Point(225, 431);
            this.dtpFecNac.Name = "dtpFecNac";
            this.dtpFecNac.Size = new System.Drawing.Size(224, 24);
            this.dtpFecNac.TabIndex = 10;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(311, 532);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(138, 36);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(747, 532);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(138, 36);
            this.btnRegistrar.TabIndex = 11;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblFechaAlta
            // 
            this.lblFechaAlta.AutoSize = true;
            this.lblFechaAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaAlta.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblFechaAlta.Location = new System.Drawing.Point(773, 169);
            this.lblFechaAlta.Name = "lblFechaAlta";
            this.lblFechaAlta.Size = new System.Drawing.Size(69, 20);
            this.lblFechaAlta.TabIndex = 5;
            this.lblFechaAlta.Text = "FECHA";
            // 
            // dtpFechaAlta
            // 
            this.dtpFechaAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaAlta.Location = new System.Drawing.Point(848, 165);
            this.dtpFechaAlta.Name = "dtpFechaAlta";
            this.dtpFechaAlta.Size = new System.Drawing.Size(154, 24);
            this.dtpFechaAlta.TabIndex = 10;
            // 
            // lblFechaPago
            // 
            this.lblFechaPago.AutoSize = true;
            this.lblFechaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaPago.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblFechaPago.Location = new System.Drawing.Point(718, 284);
            this.lblFechaPago.Name = "lblFechaPago";
            this.lblFechaPago.Size = new System.Drawing.Size(124, 20);
            this.lblFechaPago.TabIndex = 5;
            this.lblFechaPago.Text = "FECHA PAGO";
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaPago.Location = new System.Drawing.Point(848, 284);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(154, 24);
            this.dtpFechaPago.TabIndex = 10;
            // 
            // lblEstadoPago
            // 
            this.lblEstadoPago.AutoSize = true;
            this.lblEstadoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoPago.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblEstadoPago.Location = new System.Drawing.Point(706, 257);
            this.lblEstadoPago.Name = "lblEstadoPago";
            this.lblEstadoPago.Size = new System.Drawing.Size(136, 20);
            this.lblEstadoPago.TabIndex = 5;
            this.lblEstadoPago.Text = "ESTADO PAGO";
            // 
            // lstEstadoPago
            // 
            this.lstEstadoPago.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEstadoPago.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lstEstadoPago.FormattingEnabled = true;
            this.lstEstadoPago.ItemHeight = 19;
            this.lstEstadoPago.Location = new System.Drawing.Point(848, 255);
            this.lstEstadoPago.Name = "lstEstadoPago";
            this.lstEstadoPago.Size = new System.Drawing.Size(154, 23);
            this.lstEstadoPago.TabIndex = 7;
            // 
            // frmRegistrarSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1034, 591);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dtpFechaPago);
            this.Controls.Add(this.dtpFechaAlta);
            this.Controls.Add(this.dtpFecNac);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNroDocumento);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblNroDocumento);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblFecNac);
            this.Controls.Add(this.lblTipoDoc);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lstTipoDoc);
            this.Controls.Add(this.lstEstadoPago);
            this.Controls.Add(this.lstTipoSocio);
            this.Controls.Add(this.lblEstadoPago);
            this.Controls.Add(this.txtNroSocio);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblFechaPago);
            this.Controls.Add(this.lblFechaAlta);
            this.Controls.Add(this.lblNroSocio);
            this.Controls.Add(this.btnCargarAptoFisico);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.picBanner);
            this.Controls.Add(this.picFondoBoton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1050, 630);
            this.MinimumSize = new System.Drawing.Size(1050, 630);
            this.Name = "frmRegistrarSocio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Socio";
            this.Load += new System.EventHandler(this.frmRegistrarSocio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFondoBoton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBanner;
        private System.Windows.Forms.PictureBox picFondoBoton;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCargarAptoFisico;
        private System.Windows.Forms.Label lblNroSocio;
        private System.Windows.Forms.TextBox txtNroSocio;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ListBox lstTipoSocio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblFecNac;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNroDocumento;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblNroDocumento;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.ListBox lstTipoDoc;
        private System.Windows.Forms.DateTimePicker dtpFecNac;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblFechaAlta;
        private System.Windows.Forms.DateTimePicker dtpFechaAlta;
        private System.Windows.Forms.Label lblFechaPago;
        private System.Windows.Forms.DateTimePicker dtpFechaPago;
        private System.Windows.Forms.Label lblEstadoPago;
        private System.Windows.Forms.ListBox lstEstadoPago;
    }
}