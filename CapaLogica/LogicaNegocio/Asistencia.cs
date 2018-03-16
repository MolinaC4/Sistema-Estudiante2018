using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.LogicaNegocio
{
    public class Asistencia
    {
        private int id_asistencia;
        private int id_curso;
        private int id_estudiante;

        public Asistencia(int id_asistencia, int id_curso, int id_estudiante)
        {
            this.Id_asistencia = id_asistencia;
            this.Id_curso = id_curso;
            this.Id_estudiante = id_estudiante;
        }
        public Asistencia(int id_curso, int id_estudiante)
        {
            this.Id_curso = id_curso;
            this.Id_estudiante = id_estudiante;
        }

        public Asistencia()
        {

        }

        public int Id_asistencia { get => id_asistencia; set => id_asistencia = value; }
        public int Id_curso { get => id_curso; set => id_curso = value; }
        public int Id_estudiante { get => id_estudiante; set => id_estudiante = value; }
    }
}
