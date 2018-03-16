using CapaIntegracion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEstudiante
{
    public partial class Invitado : Form
    {
        public Invitado()
        {
            InitializeComponent();
            Gestor_usuario.AgregarInicio("Inicio Sesion");
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login mostrar = new Login();
            mostrar.Show();
        }

        private void btnMatricula_Click(object sender, EventArgs e)
        {
            Matriculas mostrar = new Matriculas();
            mostrar.Show();
        }

        private void btnEstudiante_Click(object sender, EventArgs e)
        {
            Estudiante est = new Estudiante();
            est.Show();
            
        }

        private void btn_deuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Formulario DEUDA en desarrollo", "CONSTRUCCÍON", MessageBoxButtons.OK, MessageBoxIcon.Information);
            /*Deuda mostrar = new Deuda();
            this.Hide();
            mostrar.Show();*/
        }

        private void btn_asistencia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Formulario ASISTENCIA en desarrollo", "CONSTRUCCÍON", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lbl_asistencia_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
            Gestor_usuario.AgregarInicio("Cerrar Sesion");
        }

        private void Invitado_Load(object sender, EventArgs e)
        {

        }
    }
}
