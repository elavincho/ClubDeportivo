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
using PrevioClubDeportivo.InterfazGrafica;

namespace PrevioClubDeportivo
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();

            /* Mostramos la información del usuario aquí */
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

        /* Cuando cerramos el formulario principal, cerramos la aplicación */
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        private void btnRegistrarSocios_Click(object sender, EventArgs e)
        {
            /* Ocultamos el formulario Home */
            this.Hide();

            /* Abrimos el formulario Registrar Socios */
            frmRegistrarSocio registrarSocio = new frmRegistrarSocio();
            registrarSocio.Show();
        }

        private void btnCobrarCuota_Click(object sender, EventArgs e)
        {
            /* Ocultamos el formulario Home */
            this.Hide();

            /* Abrimos el formulario Cobrar Cuota */
            frmCobrarCuota cobrarCuota = new frmCobrarCuota();
            cobrarCuota.Show();
        }
    }
}
