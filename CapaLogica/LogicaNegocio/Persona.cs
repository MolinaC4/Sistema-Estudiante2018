using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.LogicaNegocio
{
    public class Persona
    {
        #region ATRIBUTOS
        private int cedula;
        private string nombre;
        private string apellido1;
        private string apellido2;
        private string telefono;
        private string direccion;
        private string correo;
        private string fechaNacimiento;
        private string genero;
        private string estado;
        private string tipo;
        // private byte[] foto;
        private string foto;
        #endregion ATRIBUTOS 

        #region CONSTRUCTOR


        public Persona()
        {

        }

        public Persona(int cedula, string nombre, string apellido1, string apellido2, string telefono, string direccion, string correo, string fechaNacimiento, string genero, string estado, string tipo, string foto)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.telefono = telefono;
            this.direccion = direccion;
            this.correo = correo;
            this.fechaNacimiento = fechaNacimiento;
            this.genero = genero;
            this.estado = estado;
            this.tipo = tipo;
            this.foto = foto;
        }

        #endregion CONSTRUCTOR

        #region GET Y SET

        public int Cedula
        {
            get
            {
                return cedula;
            }

            set
            {
                cedula = value;
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

        public string Apellido1
        {
            get
            {
                return apellido1;
            }

            set
            {
                apellido1 = value;
            }
        }

        public string Apellido2
        {
            get
            {
                return apellido2;
            }

            set
            {
                apellido2 = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public string Correo
        {
            get
            {
                return correo;
            }

            set
            {
                correo = value;
            }
        }

        public string FechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }

            set
            {
                fechaNacimiento = value;
            }
        }

        public string Genero
        {
            get
            {
                return genero;
            }

            set
            {
                genero = value;
            }
        }

        public string Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
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

        public string Foto
        {
            get
            {
                return foto;
            }

            set
            {
                foto = value;
            }
        }

        #endregion GET Y SET


    }
}
