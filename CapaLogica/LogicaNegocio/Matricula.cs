using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.LogicaNegocio
{
    public class Matricula
    {
        private int id_matricula;
        private string estado;
        private int curso_id_curso;
        private int tbl_estudiante_cedula;
        private string fecha;



        public Matricula()
        {

        }

        public Matricula(int curso_id_curso, int tbl_estudiante_cedula)
        {
            this.Curso_id_curso = curso_id_curso;
            this.Tbl_estudiante_cedula = tbl_estudiante_cedula;
        }

        public Matricula(string estado, int curso_id_curso, int tbl_estudiante_cedula, string fecha)
        {
            this.Estado = estado;
            this.Curso_id_curso = curso_id_curso;
            this.Tbl_estudiante_cedula = tbl_estudiante_cedula;
            this.Fecha = fecha;
        }

        public int Id_matricula { get => id_matricula; set => id_matricula = value; }
        public string Estado { get => estado; set => estado = value; }
        public int Curso_id_curso { get => curso_id_curso; set => curso_id_curso = value; }
        public int Tbl_estudiante_cedula { get => tbl_estudiante_cedula; set => tbl_estudiante_cedula = value; }
        public string Fecha { get => fecha; set => fecha = value; }
    }
}
