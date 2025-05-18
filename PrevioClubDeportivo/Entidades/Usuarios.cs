using System;
using System.Data;
using System.Windows.Forms;

/* Referencia a MySQL */
using MySql.Data.MySqlClient;
using PrevioClubDeportivo.Datos;

namespace PrevioClubDeportivo.Entidades
{
    internal class Usuarios
    {
        /* Creamos un metodo que retorne una tabla con la informacion */
        public DataTable Log_Usuario(string L_Usuario, string P_Usuario)
        {
            MySqlDataReader resultado; /* variable de tipo datareader */
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                /* El comando es un elemento que almacena en este caso el nombre
                 * del procedimiento almacenado y la referencia a la conexion */

                MySqlCommand comando = new MySqlCommand("IngresoLogin", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                /* Definimos los parametros que tiene el procedure */

                comando.Parameters.Add("Usuario",
               MySqlDbType.VarChar).Value = L_Usuario;
                comando.Parameters.Add("Pass", MySqlDbType.VarChar).Value = P_Usuario;

                /* Abrimos la conexion */
                sqlCon.Open();
                resultado = comando.ExecuteReader(); /* almacenamos el resulatdo en la variable */
                tabla.Load(resultado); /* cargamos la tabla con el resultado */

                return tabla;
                /*  de esta forma esta asociado el metodo con el procedure que esta almacenado en MySQL */
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intertar iniciar sesión: " + ex.Message);
                throw;
            }
            /* como proceso final */
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); }
                ;
            }
        }
    }
}
