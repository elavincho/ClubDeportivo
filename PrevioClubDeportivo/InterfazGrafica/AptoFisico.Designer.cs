namespace PrevioClubDeportivo.InterfazGrafica
{
    partial class frmAptoFisico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAptoFisico));
            this.picBanner = new System.Windows.Forms.PictureBox();
            this.picFondoBoton = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNroSocio = new System.Windows.Forms.Label();
            this.txtNroSocio = new System.Windows.Forms.TextBox();
            this.lblEsApto = new System.Windows.Forms.Label();
            this.lstEsApto = new System.Windows.Forms.ListBox();
            this.lblVtoAptoFisico = new System.Windows.Forms.Label();
            this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbDatosMedico = new System.Windows.Forms.GroupBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblNombreMedico = new System.Windows.Forms.Label();
            this.txtNombreMedico = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFondoBoton)).BeginInit();
            this.gbDatosMedico.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBanner
            // 
            this.picBanner.Image = ((System.Drawing.Image)(resources.GetObject("picBanner.Image")));
            this.picBanner.Location = new System.Drawing.Point(-5, 0);
            this.picBanner.Name = "picBanner";
            this.picBanner.Size = new System.Drawing.Size(1039, 144);
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
            this.lblTitulo.Location = new System.Drawing.Point(129, 174);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(304, 39);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Cargar Apto Físico";
            // 
            // lblNroSocio
            // 
            this.lblNroSocio.AutoSize = true;
            this.lblNroSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroSocio.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNroSocio.Location = new System.Drawing.Point(685, 213);
            this.lblNroSocio.Name = "lblNroSocio";
            this.lblNroSocio.Size = new System.Drawing.Size(130, 29);
            this.lblNroSocio.TabIndex = 4;
            this.lblNroSocio.Text = "N° SOCIO";
            // 
            // txtNroSocio
            // 
            this.txtNroSocio.BackColor = System.Drawing.Color.White;
            this.txtNroSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroSocio.Location = new System.Drawing.Point(833, 210);
            this.txtNroSocio.Name = "txtNroSocio";
            this.txtNroSocio.ReadOnly = true;
            this.txtNroSocio.Size = new System.Drawing.Size(167, 35);
            this.txtNroSocio.TabIndex = 5;
            this.txtNroSocio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblEsApto
            // 
            this.lblEsApto.AutoSize = true;
            this.lblEsApto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblEsApto.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEsApto.Location = new System.Drawing.Point(30, 52);
            this.lblEsApto.Name = "lblEsApto";
            this.lblEsApto.Size = new System.Drawing.Size(84, 20);
            this.lblEsApto.TabIndex = 4;
            this.lblEsApto.Text = "ES APTO";
            // 
            // lstEsApto
            // 
            this.lstEsApto.Font = new System.Drawing.Font("Gadugi", 14.25F);
            this.lstEsApto.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lstEsApto.FormattingEnabled = true;
            this.lstEsApto.ItemHeight = 22;
            this.lstEsApto.Location = new System.Drawing.Point(32, 74);
            this.lstEsApto.Name = "lstEsApto";
            this.lstEsApto.Size = new System.Drawing.Size(218, 26);
            this.lstEsApto.TabIndex = 6;
            // 
            // lblVtoAptoFisico
            // 
            this.lblVtoAptoFisico.AutoSize = true;
            this.lblVtoAptoFisico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblVtoAptoFisico.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblVtoAptoFisico.Location = new System.Drawing.Point(30, 117);
            this.lblVtoAptoFisico.Name = "lblVtoAptoFisico";
            this.lblVtoAptoFisico.Size = new System.Drawing.Size(130, 20);
            this.lblVtoAptoFisico.TabIndex = 4;
            this.lblVtoAptoFisico.Text = "VENCIMIENTO";
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dtpVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVencimiento.Location = new System.Drawing.Point(32, 140);
            this.dtpVencimiento.MinDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(218, 26);
            this.dtpVencimiento.TabIndex = 7;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(254, 516);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(138, 36);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(745, 516);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(138, 36);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gbDatosMedico
            // 
            this.gbDatosMedico.Controls.Add(this.txtMatricula);
            this.gbDatosMedico.Controls.Add(this.lblMatricula);
            this.gbDatosMedico.Controls.Add(this.lblNombreMedico);
            this.gbDatosMedico.Controls.Add(this.txtNombreMedico);
            this.gbDatosMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.gbDatosMedico.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gbDatosMedico.Location = new System.Drawing.Point(183, 284);
            this.gbDatosMedico.Name = "gbDatosMedico";
            this.gbDatosMedico.Size = new System.Drawing.Size(280, 190);
            this.gbDatosMedico.TabIndex = 17;
            this.gbDatosMedico.TabStop = false;
            this.gbDatosMedico.Text = "DATOS DEL MEDICO";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.txtMatricula.Location = new System.Drawing.Point(33, 140);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(215, 25);
            this.txtMatricula.TabIndex = 16;
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblMatricula.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMatricula.Location = new System.Drawing.Point(32, 117);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(111, 20);
            this.lblMatricula.TabIndex = 15;
            this.lblMatricula.Text = "MATRICULA";
            // 
            // lblNombreMedico
            // 
            this.lblNombreMedico.AutoSize = true;
            this.lblNombreMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblNombreMedico.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNombreMedico.Location = new System.Drawing.Point(32, 52);
            this.lblNombreMedico.Name = "lblNombreMedico";
            this.lblNombreMedico.Size = new System.Drawing.Size(194, 20);
            this.lblNombreMedico.TabIndex = 14;
            this.lblNombreMedico.Text = "NOMBRE Y APELLIDO";
            // 
            // txtNombreMedico
            // 
            this.txtNombreMedico.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.txtNombreMedico.Location = new System.Drawing.Point(33, 75);
            this.txtNombreMedico.Name = "txtNombreMedico";
            this.txtNombreMedico.Size = new System.Drawing.Size(215, 25);
            this.txtNombreMedico.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstEsApto);
            this.groupBox1.Controls.Add(this.lblEsApto);
            this.groupBox1.Controls.Add(this.lblVtoAptoFisico);
            this.groupBox1.Controls.Add(this.dtpVencimiento);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(676, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 190);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "APTO FÍSICO";
            // 
            // frmAptoFisico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1034, 591);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbDatosMedico);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtNroSocio);
            this.Controls.Add(this.lblNroSocio);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.picFondoBoton);
            this.Controls.Add(this.picBanner);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1050, 630);
            this.MinimumSize = new System.Drawing.Size(1050, 630);
            this.Name = "frmAptoFisico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AptoFisico";
            this.Load += new System.EventHandler(this.frmAptoFisico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFondoBoton)).EndInit();
            this.gbDatosMedico.ResumeLayout(false);
            this.gbDatosMedico.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBanner;
        private System.Windows.Forms.PictureBox picFondoBoton;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNroSocio;
        private System.Windows.Forms.TextBox txtNroSocio;
        private System.Windows.Forms.Label lblEsApto;
        private System.Windows.Forms.ListBox lstEsApto;
        private System.Windows.Forms.Label lblVtoAptoFisico;
        private System.Windows.Forms.DateTimePicker dtpVencimiento;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox gbDatosMedico;
        private System.Windows.Forms.TextBox txtNombreMedico;
        private System.Windows.Forms.Label lblNombreMedico;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}