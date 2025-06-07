using System;

namespace PrevioClubDeportivo.Entidades
{
    internal class AptFisico
    {


        /* Atributos con Get y Set */

        public int idAptoFisico { get; set; }
        public string nombreMedico { get; set; }
        public string matricula { get; set; }
        public int numeroSocio { get; set; }
        public string esApto { get; set; }
        public DateTime vtoAptoFisico { get; set; }

        /* Constructor Vacio */
        public AptFisico()
        {
        }

        /* Constructor con Parametros*/
        public AptFisico(int idAptoFisico, string nombreMedico, string matricula, int numeroSocio, string esApto, DateTime vtoAptoFisico)
        {
            this.idAptoFisico = idAptoFisico;
            this.numeroSocio = numeroSocio;
            this.esApto = esApto;
            this.vtoAptoFisico = vtoAptoFisico;
            this.nombreMedico = nombreMedico;
            this.matricula = matricula;
        }

        /* To String */
        public override string ToString()
        {
            return "N° Socio: " + numeroSocio + " Es Apto: " + esApto + " Vencimiento Apto Físico: " + vtoAptoFisico;
        }
    }
}
