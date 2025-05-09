using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrevioClubDeportivo.Entidades;

namespace PrevioClubDeportivo
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();

            // Puedes usar la información del usuario aquí
            lblUsuario.Text = $"{SesionUsuario.nombreUsuario}";

            lblRol.Text = $"{SesionUsuario.rol}";

        }

        private void frmRegistrarSocio_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            /* Cierra completamente la aplicación */
            Application.Exit();
        }

        // Cuando cerramos el formulario principal, cerramos la aplicación
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

    }
}
