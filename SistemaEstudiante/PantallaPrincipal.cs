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
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
       
        }

        private void btnEstudiante_Click(object sender, EventArgs e)
        {
            Estudiante est = new Estudiante();
            this.Hide();
            est.Show();
          
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            Curso cur = new Curso();
            this.Hide();
            cur.Show();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
            Gestor_usuario.AgregarInicio("Cerrar Sesion");
        }

        private void btnMatricula_Click(object sender, EventArgs e)
        {
            GestorCurso Cursos = new GestorCurso();

            if (!Cursos.CheckearCursos())
            {
                MessageBox.Show("Debe ingresar al menos 1 curso.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Matriculas mostrar = new Matriculas();
                this.Hide();
                mostrar.Show();
            }
        }

        private void btn_deuda_Click(object sender, EventArgs e)
        {

            //MessageBox.Show("Formulario CONTROL DE PAGOS en desarrollo", "CONSTRUCCÍON", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Deuda mostrar = new Deuda();
            this.Hide();
            mostrar.Show();
        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btn_asistencia_Click(object sender, EventArgs e)
        {
            GestorCurso Cursos = new GestorCurso();

            if (!Cursos.CheckearCursos())
            {
                MessageBox.Show("Debe ingresar al menos 1 curso.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Asistencia mostrar = new Asistencia();
                this.Hide();
                mostrar.Show();
            }


            
        }

        private void btn_actividades_Click(object sender, EventArgs e)
        {
            Actividades mostrar = new Actividades();
            this.Hide();
            mostrar.Show();
        }

        private void btn_usuario_Click(object sender, EventArgs e)
        {
            MenuConfiguracion mnc = new MenuConfiguracion();
            this.Hide();
            mnc.Show();
            
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

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            //Si pasa por encimar cambia la imagen
            //pictureBox3.Image = Image.FromFile("C:\\Users\\Luis Duarte\\Desktop\\SistemaEstudiante\\SistemaEstudiante\\Resources\\atras1.png");
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            //Si deja de pasar por encima se cambia la imagen a la original
            //pictureBox3.Image = Image.FromFile("C:\\Users\\Luis Duarte\\Desktop\\SistemaEstudiante\\SistemaEstudiante\\Resources\\if_edit-find_38991.png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pago = Gestor_pagos.crear_deuda();
            if (pago > 0)
            {
                MessageBox.Show("Sea a generado la lista de pendientes con exito", "Deuda generada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                groupBox1.Hide();
            }
            else
            {
                MessageBox.Show("No se ha generado la lista de pendientes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
        }
    }
}
