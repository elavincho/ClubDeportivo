using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/* Referencia a MySQL (se agraga como librería) */
using MySql.Data.MySqlClient;

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
            this.baseDatos = "Previoproyecto";
            this.servidor = "localhost";
            this.puerto = "3306";
            this.usuario = "root";
            this.clave = "root";
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
                cadena = null;
                MessageBox.Show($"Error de Conexión: {ex.Message}");
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
