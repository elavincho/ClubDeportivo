/* Referencia a MySQL (se agraga como librería) */
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Windows.Forms;

namespace PrevioClubDeportivo.Datos
{
    /* La clase debe ser pública */
    public class Conexion
    {
        /* Declaramos las variables */
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion con = null;

        /* Asignamos valores a las variables de la conexion */
        private Conexion()
        {
            /* variables usadas para larepetición de líneas de código */
            bool correcto = false;
            int mensaje;

            /* Creamos las variables para recibir los datos desde el teclado,
             * anteponemos T para indicar que vienen desde el telcado*/
            string T_servidor = "Servidor";
            string T_puerto = "Puerto";
            string T_usuario = "Usuario";
            string T_clave = "Clave";

            /* Ciclo while para volver a repetir el ingreso de datos la variable 
             * correcto la inicializamos para ingresar al ciclo */
            while (correcto != true)
            {
                /* Tuve que instalar el paquete Microsoft.VisualBasic desde el paquete de NuGet*/

                /* Armamos los cuadros de dialogo para el ingreso de datos */
                T_servidor = Microsoft.VisualBasic.Interaction.InputBox
                ("Ingrese Servidor", "Datos de Instalación MySQL");
                T_puerto = Microsoft.VisualBasic.Interaction.InputBox
                ("Ingrese Puerto", "Datos de Instalación MySQL");
                T_usuario = Microsoft.VisualBasic.Interaction.InputBox
                ("Ingrese Usuario", "Datos de Instalación MySQL");
                T_clave = Microsoft.VisualBasic.Interaction.InputBox
                ("Ingrese Clave", "Datos de Instalación MySQL");
                
                /* Controlamos que los datos ingresados para acceder a MySQL sean correctos */
                mensaje = (int)MessageBox.Show("Su ingreso: Servidor: " +
                T_servidor + " Puerto: " + T_puerto + " Usuario: " +
                T_usuario + " Clave: " + T_clave,
                "Aviso del Sistema", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);
                if (mensaje != 6)  /* El valor 6 corresponde al SI */
                {
                    MessageBox.Show("Ingrese nuevamente los datos");
                    correcto = false;
                }
                else
                {
                    correcto = true;
                }
            }

            /* Reemplazamos los datos concretos que teniamos por las variables */

            this.baseDatos = "Proyecto";
            this.servidor = T_servidor;
            this.puerto = T_puerto;
            this.usuario = T_usuario;
            this.clave = T_clave;
        }

        /* Proceso de interacción*/
        public MySqlConnection CrearConexion()
        {
            /* Instanciamos una conexion*/
            MySqlConnection cadena = new MySqlConnection();

            /* El bloque try permite controlar errores*/
            try
            {
                cadena.ConnectionString = "datasource=" + this.servidor +
                ";port=" + this.puerto +
                ";username=" + this.usuario +
                ";password=" + this.clave +
                ";Database=" + this.baseDatos;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error de conexión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cadena = null;
                throw;
            }
            return cadena;
        }

        /* Para evaluar la instancia de la conectividad*/
        public static Conexion getInstancia()
        {
            if (con == null) /* quiere decir que la conexion esta cerrada */
            {
                con = new Conexion(); /* se crea una nueva */
            }
            return con;
        }
    }
}
