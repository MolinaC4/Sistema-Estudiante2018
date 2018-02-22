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
    public partial class AsistenciaCurso : Form
    {
        public AsistenciaCurso()
        {
            InitializeComponent();
            GestorMatricula.llenarCombo(comboBox1);
        }

        private void AsistenciaCurso_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           GestorAsistencia.BuscarDatosAsistenciaCurso(dataGridView1, int.Parse(comboBox1.SelectedValue.ToString()), dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"), dateTimePicker2.Value.Date.ToString("yyyy-MM-dd"));
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            GestorAsistencia.BuscarDatosAsistenciaCurso(dataGridView1, int.Parse(comboBox1.SelectedValue.ToString()), dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"), dateTimePicker2.Value.Date.ToString("yyyy-MM-dd"));
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            GestorAsistencia.BuscarDatosAsistenciaCurso(dataGridView1, int.Parse(comboBox1.SelectedValue.ToString()), dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"), dateTimePicker2.Value.Date.ToString("yyyy-MM-dd"));
        }

        private void picture_atras_Click(object sender, EventArgs e)
        {
            Asistencia asi = new Asistencia();
            asi.Show();
            this.Hide();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void asistenciaPorEsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Asistencia asi = new Asistencia();
            asi.Show();
            this.Hide();
        }

        private void asistenciaPorEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Busqueda_asistencia asi = new Busqueda_asistencia();
            asi.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            GestorAsistencia.BuscarDatosAsistenciaCurso(dataGridView1, int.Parse(comboBox1.SelectedValue.ToString()), dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"), dateTimePicker2.Value.Date.ToString("yyyy-MM-dd"));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GestorAsistencia.BuscarDatosAsistenciaCurso(dataGridView1, int.Parse(comboBox1.SelectedValue.ToString()), dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"), dateTimePicker2.Value.Date.ToString("yyyy-MM-dd"));
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            GestorAsistencia.BuscarDatosAsistenciaCurso(dataGridView1, int.Parse(comboBox1.SelectedValue.ToString()), dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"), dateTimePicker2.Value.Date.ToString("yyyy-MM-dd"));
        }

        private void dateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {
            GestorAsistencia.BuscarDatosAsistenciaCurso(dataGridView1, int.Parse(comboBox1.SelectedValue.ToString()), dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"), dateTimePicker2.Value.Date.ToString("yyyy-MM-dd"));
        }
    }
}
