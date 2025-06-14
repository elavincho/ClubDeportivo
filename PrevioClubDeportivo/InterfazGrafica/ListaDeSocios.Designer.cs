namespace PrevioClubDeportivo.InterfazGrafica
{
    partial class frmListaDeSocios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaDeSocios));
            this.picBanner = new System.Windows.Forms.PictureBox();
            this.lblListaDeSocios = new System.Windows.Forms.Label();
            this.picFondoBoton = new System.Windows.Forms.PictureBox();
            this.dtgvListaSocios = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFondoBoton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListaSocios)).BeginInit();
            this.SuspendLayout();
            // 
            // picBanner
            // 
            this.picBanner.Image = ((System.Drawing.Image)(resources.GetObject("picBanner.Image")));
            this.picBanner.Location = new System.Drawing.Point(-5, -4);
            this.picBanner.Name = "picBanner";
            this.picBanner.Size = new System.Drawing.Size(1040, 144);
            this.picBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBanner.TabIndex = 5;
            this.picBanner.TabStop = false;
            // 
            // lblListaDeSocios
            // 
            this.lblListaDeSocios.AutoSize = true;
            this.lblListaDeSocios.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.lblListaDeSocios.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblListaDeSocios.Location = new System.Drawing.Point(143, 172);
            this.lblListaDeSocios.Name = "lblListaDeSocios";
            this.lblListaDeSocios.Size = new System.Drawing.Size(252, 39);
            this.lblListaDeSocios.TabIndex = 7;
            this.lblListaDeSocios.Text = "Lista de Socios";
            // 
            // picFondoBoton
            // 
            this.picFondoBoton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.picFondoBoton.Location = new System.Drawing.Point(0, 139);
            this.picFondoBoton.Name = "picFondoBoton";
            this.picFondoBoton.Size = new System.Drawing.Size(100, 456);
            this.picFondoBoton.TabIndex = 8;
            this.picFondoBoton.TabStop = false;
            // 
            // dtgvListaSocios
            // 
            this.dtgvListaSocios.AllowUserToAddRows = false;
            this.dtgvListaSocios.AllowUserToDeleteRows = false;
            this.dtgvListaSocios.BackgroundColor = System.Drawing.Color.White;
            this.dtgvListaSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListaSocios.Location = new System.Drawing.Point(142, 259);
            this.dtgvListaSocios.Name = "dtgvListaSocios";
            this.dtgvListaSocios.ReadOnly = true;
            this.dtgvListaSocios.Size = new System.Drawing.Size(844, 230);
            this.dtgvListaSocios.TabIndex = 9;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Firebrick;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(527, 524);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(138, 36);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmListaDeSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1034, 591);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dtgvListaSocios);
            this.Controls.Add(this.picFondoBoton);
            this.Controls.Add(this.lblListaDeSocios);
            this.Controls.Add(this.picBanner);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1050, 630);
            this.MinimumSize = new System.Drawing.Size(1050, 630);
            this.Name = "frmListaDeSocios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Socios";
            this.Load += new System.EventHandler(this.frmListaDeSocios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFondoBoton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListaSocios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBanner;
        private System.Windows.Forms.Label lblListaDeSocios;
        private System.Windows.Forms.PictureBox picFondoBoton;
        private System.Windows.Forms.DataGridView dtgvListaSocios;
        private System.Windows.Forms.Button btnVolver;
    }
}