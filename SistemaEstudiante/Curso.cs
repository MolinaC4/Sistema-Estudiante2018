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
    public partial class Curso : Form
    {
        public Curso()
        {
            InitializeComponent();

            GestorCurso.MostrarDatos(dgv_curso);
        }

        public void Guardar() {
            CapaLogica.LogicaNegocio.Curso pCurso = new CapaLogica.LogicaNegocio.Curso();

            if (string.IsNullOrEmpty(txt_curso.Text) || string.IsNullOrEmpty(txt_descripcion.Text))
            {

                MessageBox.Show("Todos los campos deben estar llenos!!");

            }
            else
            {
              // pCurso.Id_curso = int.Parse(txt_id_curso.Text.Trim());
                pCurso.Nombre = txt_curso.Text.Trim();
                pCurso.Descripcion = txt_descripcion.Text.Trim();
                pCurso.Estado = "A";

                if (GestorCurso.Agregar(pCurso) == 1)
                {
                    MessageBox.Show("Curso Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GestorCurso.MostrarDatos(dgv_curso);

                    txt_curso.Clear();
                    txt_descripcion.Clear();
                    txt_id_curso.Clear();
                }
                else
                {
                    
                    MessageBox.Show("Curso Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GestorCurso.MostrarDatos(dgv_curso);

                    txt_curso.Clear();
                    txt_descripcion.Clear();
                    txt_id_curso.Clear();
                }
            }
        }

        //Insertar
        private void btn_insertar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        //Atras
        private void btn_atras_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de abandonar esta ventana?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                PantallaPrincipal pan = new PantallaPrincipal();
                this.Hide();
                pan.Show();
            }
            
        }

        //Al precionar una fila o columna se pone en los campos de texto
        private void dgv_curso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string columna1 = string.Empty;
            string columna2 = string.Empty;
            //string columna3 = string.Empty;
            DataGridViewRow fila = dgv_curso.CurrentRow; // obtengo la fila actualmente seleccionada en el dataGridView

            columna1 = Convert.ToString(fila.Cells[0].Value); //obtengo el valor de la primer columna
            columna2 = Convert.ToString(fila.Cells[1].Value); //obtengo el valor de la segunda columna
            //columna3 = Convert.ToString(fila.Cells[2].Value); //obtengo el valor de la tercera columna

            // txt_id_curso.Text = columna1.ToString();

            //txt_id_curso.Text = columna1.ToString();
            txt_descripcion.Text = columna1.ToString();
            txt_curso.Text = columna2.ToString();
        }

        //Buscar y se muestra en el data grip
        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            GestorCurso.BuscarDatosCurso(dgv_curso, txt_buscar.Text.Trim());
        }


        //Inactivar 
        private void Inactivar_Click(object sender, EventArgs e)
        {
            CapaLogica.LogicaNegocio.Curso pCurso = new CapaLogica.LogicaNegocio.Curso();
            //pCurso.Id_curso = int.Parse(txt_id_curso.Text.Trim());
            pCurso.Nombre = txt_curso.Text.Trim();
            pCurso.Descripcion = txt_descripcion.Text.Trim();
            pCurso.Estado = "A";
            

            int resultado = GestorCurso.Inactivar(pCurso);
            if (resultado > 0)
            {
                MessageBox.Show("Curso Eliminado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GestorCurso.MostrarDatos(dgv_curso);

                txt_curso.Clear();
                txt_descripcion.Clear();
                txt_id_curso.Clear();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el curso", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                txt_curso.Clear();
                txt_descripcion.Clear();
                txt_id_curso.Clear();

            }
        }

        //Cerrar sesion
        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de cerrar sesión?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Login log = new Login();
                log.Show();
                this.Hide();
            }
        }

        //salir
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
             if (MessageBox.Show("¿Desea salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //Hacer un nuevo estudiante
        private void nuevoEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_curso.Clear();
            txt_descripcion.Clear();
            txt_id_curso.Clear();
        }

        //Atras
        private void picture_atras_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Esta seguro de abandonar esta ventana?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                PantallaPrincipal pan = new PantallaPrincipal();
                this.Hide();
                pan.Show();
            }
            
        }

        private void picture_atras_BackgroundImageChanged(object sender, EventArgs e)
        {

        }

        private void cursosEliminadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de abandonar esta ventana?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                CursosEliminados cur = new CursosEliminados();
                this.Hide();
                cur.Show();
            }
            
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {

        }

        private void txt_descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Guardar();
            }
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void Curso_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_id_curso_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_id_curso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;

                MessageBox.Show("Solo puede digitar numeros", "Error!",
                MessageBoxButtons.OK, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RtlReading
              | MessageBoxOptions.RightAlign);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_descripcion_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //Metodo que no permite caracteres especiales, solo caracteres alafanumericos
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        
            
            
           /* if (e.KeyChar != 32){
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            if (txt_descripcion.Text.Trim() == "")
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider1.SetError(txt_descripcion, "No se permiten espacios en blanco");
               
             }
             else
             {
                 errorProvider1.Clear();
             }*/
         }

         private void txt_curso_KeyPress(object sender, KeyPressEventArgs e)
         {
              /*if (txt_curso.Text.Trim() == "")
              {
                  MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  errorProvider1.SetError(txt_curso, "No se permiten espacios en blanco");
                 
        }
             else
             {
                 errorProvider1.Clear();
             }*/
        }

        private void txt_descripcion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
