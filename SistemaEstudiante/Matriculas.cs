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
    public partial class Matriculas : Form
    {
        public Matriculas()
        {
            InitializeComponent();
            GestorMatricula.MostrarDatosEstudiantes(dgv_estudiante);
            GestorMatricula.llenarCombo(comboBox1);
            GestorMatricula.MostrarDatos(dgv_curso, int.Parse(comboBox1.SelectedValue.ToString()));
        }

        public void llenarcampos()
        {
            string columna1 = string.Empty;

            DataGridViewRow fila = dgv_estudiante.CurrentRow; // obtengo la fila actualmente seleccionada en el dataGridView

            columna1 = Convert.ToString(fila.Cells[0].Value); //obtengo el valor de la primer columna

            txt_id.Text = columna1.ToString();
        }
        private void dgv_estudiante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            llenarcampos();
        }

        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            GestorMatricula.BuscarDatosEstudiantes(dgv_estudiante, txt_buscar.Text.Trim());
        }

        private void btn_matricula_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_id.Text) )
            {

                MessageBox.Show("Todos los campos deben estar llenos!!");

            }
            else
            {
                Matricula pMatricula = new Matricula();

                pMatricula.Tbl_estudiante_cedula = int.Parse(txt_id.Text.Trim());
                pMatricula.Curso_id_curso = int.Parse(comboBox1.SelectedValue.ToString());

                int resultado = GestorMatricula.Agregar(pMatricula);
                if (resultado > 0)
                {
                    MessageBox.Show("Matricula exitosa!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GestorMatricula.MostrarDatos(dgv_curso, int.Parse(comboBox1.SelectedValue.ToString()));
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el cliente", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void dgv_curso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            llenarcampos();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GestorMatricula.MostrarDatos(dgv_curso, int.Parse(comboBox1.SelectedValue.ToString()));
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            PantallaPrincipal pan = new PantallaPrincipal();
            this.Hide();
            pan.Show();
        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
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

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void Matriculas_Load(object sender, EventArgs e)
        {
            txt_id.ReadOnly = true;
        }

        private void dgv_estudiante_DoubleClick(object sender, EventArgs e)
        {
            llenarcampos();
        }

        private void dgv_curso_DoubleClick(object sender, EventArgs e)
        {
            llenarcampos();
        }
    }
}
