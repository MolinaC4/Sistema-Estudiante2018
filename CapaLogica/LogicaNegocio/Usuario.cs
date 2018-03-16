using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.LogicaNegocio
{
    public class Usuario
    {
        #region ATRIBUTOS
        private int id_administrador;
        private string nombre;
        private string contrasenna;
        private string tipo;
        private int tipoP;
        private string respuestaS;
        #endregion

        #region CONSTRUCTOR
        public Usuario(int id_administrador, string nombre, string contrasenna, string tipo, int tipoP, string respuestaS)
        {
            this.Id_administrador = id_administrador; 
            this.Nombre = nombre;
            this.Contrasenna = contrasenna;
            this.Tipo = tipo;
            this.TipoPregunta = tipoP;
            this.RespuestaS = respuestaS;
        }

        public Usuario(){}
        #endregion

        #region GET AND SET

        public int Id_administrador
        {
            get
            {
                return id_administrador;
            }

            set
            {
                id_administrador = value;
            }
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Contrasenna
        {
            get
            {
                return contrasenna;
            }

            set
            {
                contrasenna = value;
            }
        }

        public string Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }

        public int TipoPregunta
        {
            get
            {
                return tipoP;
            }

            set
            {
                tipoP = value;
            }
        }

        public string RespuestaS
        {
            get
            {
                return respuestaS;
            }

            set
            {
                respuestaS = value;
            }
        }
        #endregion

    }
}