namespace PrevioClubDeportivo.InterfazGrafica
{
    partial class frmVencimientosDelDia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVencimientosDelDia));
            this.lblVencimientoDelDia = new System.Windows.Forms.Label();
            this.picFondoBoton = new System.Windows.Forms.PictureBox();
            this.picBanner = new System.Windows.Forms.PictureBox();
            this.dtgvVencimientos = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picFondoBoton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVencimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVencimientoDelDia
            // 
            this.lblVencimientoDelDia.AutoSize = true;
            this.lblVencimientoDelDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.lblVencimientoDelDia.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblVencimientoDelDia.Location = new System.Drawing.Point(143, 172);
            this.lblVencimientoDelDia.Name = "lblVencimientoDelDia";
            this.lblVencimientoDelDia.Size = new System.Drawing.Size(343, 39);
            this.lblVencimientoDelDia.TabIndex = 6;
            this.lblVencimientoDelDia.Text = "Vencimientos del Día";
            // 
            // picFondoBoton
            // 
            this.picFondoBoton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.picFondoBoton.Location = new System.Drawing.Point(0, 139);
            this.picFondoBoton.Name = "picFondoBoton";
            this.picFondoBoton.Size = new System.Drawing.Size(100, 456);
            this.picFondoBoton.TabIndex = 5;
            this.picFondoBoton.TabStop = false;
            // 
            // picBanner
            // 
            this.picBanner.Image = ((System.Drawing.Image)(resources.GetObject("picBanner.Image")));
            this.picBanner.Location = new System.Drawing.Point(-5, -4);
            this.picBanner.Name = "picBanner";
            this.picBanner.Size = new System.Drawing.Size(1040, 144);
            this.picBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBanner.TabIndex = 4;
            this.picBanner.TabStop = false;
            // 
            // dtgvVencimientos
            // 
            this.dtgvVencimientos.AllowUserToAddRows = false;
            this.dtgvVencimientos.AllowUserToDeleteRows = false;
            this.dtgvVencimientos.BackgroundColor = System.Drawing.Color.White;
            this.dtgvVencimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvVencimientos.Location = new System.Drawing.Point(142, 259);
            this.dtgvVencimientos.Name = "dtgvVencimientos";
            this.dtgvVencimientos.ReadOnly = true;
            this.dtgvVencimientos.Size = new System.Drawing.Size(844, 230);
            this.dtgvVencimientos.TabIndex = 7;
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
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmVencimientosDelDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1034, 591);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dtgvVencimientos);
            this.Controls.Add(this.lblVencimientoDelDia);
            this.Controls.Add(this.picFondoBoton);
            this.Controls.Add(this.picBanner);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1050, 630);
            this.MinimumSize = new System.Drawing.Size(1050, 630);
            this.Name = "frmVencimientosDelDia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vencimientos del Día";
            this.Load += new System.EventHandler(this.frmVencimientosDelDia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFondoBoton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVencimientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblVencimientoDelDia;
        private System.Windows.Forms.PictureBox picFondoBoton;
        private System.Windows.Forms.PictureBox picBanner;
        private System.Windows.Forms.DataGridView dtgvVencimientos;
        private System.Windows.Forms.Button btnVolver;
    }
}