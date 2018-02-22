using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica.LogicaNegocio;
using CapaIntegracion;

namespace SistemaEstudiante
{
    public partial class CursosEliminados : Form
    {
        public CursosEliminados()
        {
            InitializeComponent();

            //Carga los datos en el data grip
            GestorCurso.MostrarDatosInactivados(dgv_curso_eliminados);
        }

        private void picture_atras_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de abandonar esta ventana?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Curso cur = new Curso();
                this.Hide();
                cur.Show();
            }
            
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de cerrar sesión?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Login log = new Login();
                log.Show();
                this.Hide();
            }
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //Busca y muestra los cursos inactivados
        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            GestorCurso.BuscarDatosCursoInactivados(dgv_curso_eliminados, txt_buscar.Text.Trim());
        }

        //Activa los cursos eliminados
        private void btn_activar_curso_Click(object sender, EventArgs e)
        {
            CapaLogica.LogicaNegocio.Curso pCurso = new CapaLogica.LogicaNegocio.Curso();
            //pCurso.Id_curso = int.Parse(txt_id_curso.Text.Trim());
            pCurso.Nombre = txt_curso.Text.Trim();
            pCurso.Descripcion = txt_descripcion.Text.Trim();
            pCurso.Estado = "A";
            //pCurso.Cupo = "20";

            int resultado = GestorCurso.Activar(pCurso);
            if (resultado > 0)
            {
                MessageBox.Show("Curso Activado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GestorCurso.MostrarDatosInactivados(dgv_curso_eliminados);

                txt_curso.Clear();
                txt_descripcion.Clear();
                txt_id_curso.Clear();
            }
            else
            {
                MessageBox.Show("No se pudo activar el curso", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Al precionar una fila o columna se pone en los campos de texto
        private void dgv_curso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string columna1 = string.Empty;
            string columna2 = string.Empty;
            //string columna3 = string.Empty;

            DataGridViewRow fila = dgv_curso_eliminados.CurrentRow; // obtengo la fila actualmente seleccionada en el dataGridView

            columna1 = Convert.ToString(fila.Cells[0].Value); //obtengo el valor de la primer columna
            columna2 = Convert.ToString(fila.Cells[1].Value); //obtengo el valor de la segunda columna
            //columna3 = Convert.ToString(fila.Cells[2].Value); //obtengo el valor de la tercera columna

            //txt_id_curso.Text = columna1.ToString();
            txt_descripcion.Text = columna1.ToString();
            txt_curso.Text = columna2.ToString();
            

        }

        private void CursosEliminados_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            

            if (txt_descripcion.Text.Trim() == "")
            {
                //MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider1.SetError(txt_descripcion, "No se permiten espacios en blanco");
                txt_curso.Focus();
                /*e.Handled = true;
                return;*/
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txt_curso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_curso.Text.Trim() == "")
            {
                //MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider1.SetError(txt_curso, "No se permiten espacios en blanco");
                txt_curso.Focus();
                /*e.Handled = true;
                return;*/
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void cursosEliminadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de abandonar esta ventana?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Curso cur = new Curso();
                this.Hide();
                cur.Show();
            }

            
        }
    }
}
