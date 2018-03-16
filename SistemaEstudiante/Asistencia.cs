using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaIntegracion;
using CapaLogica.LogicaNegocio;


namespace SistemaEstudiante
{
    public partial class Asistencia : Form
    {
        public Asistencia()
        {
            InitializeComponent();
            GestorMatricula.llenarCombo(comboBox1);
            checkearAsistencia();
        }

        public void llenarcampos()
        {
            button1.Visible = false;
            string columna1 = string.Empty;

            DataGridViewRow fila = Dgv_Estudiante.CurrentRow; // obtengo la fila actualmente seleccionada en el dataGridView

            columna1 = Convert.ToString(fila.Cells[0].Value); //obtengo el valor de la primer columna

            txt_id.Text = columna1.ToString();
        }

        private void Asistencia_Load(object sender, EventArgs e)
        {
            txt_id.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            int curso = int.Parse(comboBox1.SelectedValue.ToString());
            int resultado = GestorAsistencia.Agregar(curso);
            if (resultado > 0)
            {
                MessageBox.Show("Lista generada!!", "Lista generada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GestorAsistencia.MostrarDatosAsistencia(Dgv_Estudiante, curso);
            }
            else
            {
                MessageBox.Show("No se pudo generar la lista", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void Dgv_Estudiante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            llenarcampos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_id.Text))
            {

                MessageBox.Show("Todos los campos deben estar llenos!!");

            }
            else
            {
                int resultado = GestorAsistencia.ControlAusencias(int.Parse(comboBox1.SelectedValue.ToString()), int.Parse(txt_id.Text.Trim()));
                if (resultado > 0)
                {
                    txt_id.Clear();
                    MessageBox.Show("Estudiante presente!!", "Asistencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GestorAsistencia.MostrarDatosAsistencia(Dgv_Estudiante, int.Parse(comboBox1.SelectedValue.ToString()));
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el cliente", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //button1.Visible = true;
            GestorAsistencia.MostrarDatosAsistencia(Dgv_Estudiante, int.Parse(comboBox1.SelectedValue.ToString()));
            checkearAsistencia();
            txt_id.Clear();
           
        }


        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            PantallaPrincipal pan = new PantallaPrincipal();
            this.Hide();
            pan.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_id.Text))
            {

                MessageBox.Show("Todos los campos deben estar llenos!!");

            }
            else
            {
                int resultado = GestorAsistencia.ControlAsistencias(int.Parse(comboBox1.SelectedValue.ToString()), int.Parse(txt_id.Text.Trim()));
                if (resultado > 0)
                {
                    txt_id.Clear();
                    MessageBox.Show("Estudiante presente!!", "Asistencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GestorAsistencia.MostrarDatosAsistencia(Dgv_Estudiante, int.Parse(comboBox1.SelectedValue.ToString()));
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el cliente", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private void checkearAsistencia()
        {
            if (!GestorAsistencia.CheckearAsistencia(int.Parse(comboBox1.SelectedValue.ToString())))
            {
                button1.Visible = true;
            }
            else
            {
                button1.Visible = false;
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            int curso = int.Parse(comboBox1.SelectedValue.ToString());
            int resultado = GestorAsistencia.Agregar(curso);
            if (resultado > 0)
            {
                MessageBox.Show("Lista generada!!", "Lista generada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GestorAsistencia.MostrarDatosAsistencia(Dgv_Estudiante, curso);
                checkearAsistencia();
            }
            else
            {
                MessageBox.Show("No se pudo guardar el cliente", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Boton de presente
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_id.Text))
            {

                MessageBox.Show("Todos los campos deben estar llenos!!");

            }
            else
            {
                int resultado = GestorAsistencia.ControlAusencias(int.Parse(comboBox1.SelectedValue.ToString()), int.Parse(txt_id.Text.Trim()));
                if (resultado > 0)
                {
                    txt_id.Clear();
                    MessageBox.Show("Estudiante presente!!", "Asistencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GestorAsistencia.MostrarDatosAsistencia(Dgv_Estudiante, int.Parse(comboBox1.SelectedValue.ToString()));
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el cliente", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        //boton de ausente
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_id.Text))
            {

                MessageBox.Show("Todos los campos deben estar llenos!!");

            }
            else
            {
                int resultado = GestorAsistencia.ControlAsistencias(int.Parse(comboBox1.SelectedValue.ToString()), int.Parse(txt_id.Text.Trim()));
                if (resultado > 0)
                {
                    txt_id.Clear();
                    MessageBox.Show("Estudiante ausente!!", "Asistencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GestorAsistencia.MostrarDatosAsistencia(Dgv_Estudiante, int.Parse(comboBox1.SelectedValue.ToString()));
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el cliente", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        //Boton de atras
        private void button4_Click_1(object sender, EventArgs e)
        {
            PantallaPrincipal pan = new PantallaPrincipal();
            this.Hide();
            pan.Show();
        }

        //Cerrar sesion
        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        //Salir
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txt_buscar_TextChanged_1(object sender, EventArgs e)
        {

        }

        //Buscar y se muestra en el data grip
        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            button1.Visible = false;
            int curso = int.Parse(comboBox1.SelectedValue.ToString());
            GestorAsistencia.BuscarDatosEstudiantes(Dgv_Estudiante, txt_buscar.Text.Trim(),curso);
        }

        private void herramientasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void asistenciaPorCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsistenciaCurso mostrar = new AsistenciaCurso();
            this.Hide();
            mostrar.Show();
        }

        private void asistenciaPorEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Busqueda_asistencia mostrar = new Busqueda_asistencia();
            this.Hide();
            mostrar.Show();
        }

        private void Dgv_Estudiante_DoubleClick(object sender, EventArgs e)
        {
            llenarcampos();
        }
    }
}
