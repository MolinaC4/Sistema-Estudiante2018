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
    public partial class Busqueda_asistencia : Form
    {
        public Busqueda_asistencia()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            GestorAsistencia.BuscarDatosAsistenciaEstudiantes(dataGridView1, txt_nombre.Text.Trim(), dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"), dateTimePicker2.Value.Date.ToString("yyyy-MM-dd"));
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            GestorAsistencia.BuscarDatosAsistenciaEstudiantes(dataGridView1, txt_nombre.Text.Trim(), dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"), dateTimePicker2.Value.Date.ToString("yyyy-MM-dd"));
        }

        private void Busqueda_asistencia_Load(object sender, EventArgs e)
        {

        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            GestorAsistencia.BuscarDatosAsistenciaEstudiantes(dataGridView1,txt_nombre.Text.Trim(),dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"), dateTimePicker2.Value.Date.ToString("yyyy-MM-dd"));
        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void picture_atras_Click(object sender, EventArgs e)
        {
            Asistencia asi = new Asistencia();
            asi.Show();
            this.Hide();
        }

        //Es para seleccionar de que fecha a que fecha quiere ver la asistencia
        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            GestorAsistencia.BuscarDatosAsistenciaEstudiantes(dataGridView1, txt_nombre.Text.Trim(), dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"), dateTimePicker2.Value.Date.ToString("yyyy-MM-dd"));
        }

        private void txt_nombre_TextChanged_1(object sender, EventArgs e)
        {

        }
        //Buscar los datos de las asistencias de los estudiantes
        private void txt_nombre_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            GestorAsistencia.BuscarDatosAsistenciaEstudiantes(dataGridView1, txt_nombre.Text.Trim(), dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"), dateTimePicker2.Value.Date.ToString("yyyy-MM-dd"));
        }
        //Es para seleccionar de que fecha a que fecha quiere ver la asistencia
        private void dateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {
            GestorAsistencia.BuscarDatosAsistenciaEstudiantes(dataGridView1, txt_nombre.Text.Trim(), dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"), dateTimePicker2.Value.Date.ToString("yyyy-MM-dd"));
        }
    }
}
