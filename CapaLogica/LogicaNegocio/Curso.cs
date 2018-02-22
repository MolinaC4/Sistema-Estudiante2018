using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.LogicaNegocio
{
    public class Curso
    {

        #region ATRIBUTOS
        private int id_curso;
        private string nombre;
        private string descripcion;
        private string estado;
        #endregion ATRIBUTOS

        #region CONSTRUCTOR
        public Curso(int id_curso, string nombre, string descripcion, string estado)
        {
            this.id_curso = id_curso;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.estado = estado;
        }

        public Curso()

        {
        }

        #endregion CONSTRUCTOR

        #region GET Y SET
        public int Id_curso
        {
            get
            {
                return id_curso;
            }

            set
            {
                id_curso = value;
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

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
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

        #endregion GET Y SET
    }
}
