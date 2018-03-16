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
    public partial class MenuConfiguracion : Form
    {
        public MenuConfiguracion()
        {
            InitializeComponent();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void nuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registro reg = new registro();
            reg.Show();
            this.Hide();
        }

        private void herramientasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void picture_atras_Click(object sender, EventArgs e)
        {
            PantallaPrincipal pan = new PantallaPrincipal();
            pan.Show();
            this.Hide();
        }

        private void btn_agregar_usuario_Click(object sender, EventArgs e)
        {
            registro reg = new registro();
            reg.Show();
            this.Hide();
        }

        private void btn_cambiar_contraseña_Click(object sender, EventArgs e)
        {
            CambiarContrasenna camc = new CambiarContrasenna();
            camc.Show();
            this.Hide();
        }

        private void btn_lista_usuarios_Click(object sender, EventArgs e)
        {
            ListaUsuarios list = new ListaUsuarios();
            list.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Actividades mostrar = new Actividades();
            this.Hide();
            mostrar.Show();
        }
    }
}
