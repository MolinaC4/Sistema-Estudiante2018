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
    public partial class RecuperarClave : Form
    {
        public RecuperarClave()
        {
            InitializeComponent();
            cbx_opcion.SelectedIndex = 0;
        }

        public void recuperarClave()
        {
            if (string.IsNullOrEmpty(txt_usuario.Text) || string.IsNullOrEmpty(txt_respuestaS.Text))
            {

                MessageBox.Show("Todos los campos deben estar llenos!!");

            }
            else
            {
                Usuario pUsuario = new Usuario();

                pUsuario = Gestor_usuario.RecuperarClave(txt_usuario.Text.Trim(), txt_respuestaS.Text.Trim(), cbx_opcion.SelectedIndex);
                if (pUsuario.RespuestaS == txt_respuestaS.Text.Trim() && pUsuario.Nombre == txt_usuario.Text.Trim() && pUsuario.TipoPregunta.Equals(cbx_opcion.SelectedIndex))
                {
                    MessageBox.Show("Su contraseña es: "+ pUsuario.Contrasenna, "Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Login mostrar = new Login();
                    this.Hide();
                    mostrar.Show();
                }
                else
                {
                    MessageBox.Show("El nombre de usuario o respuesta de seguridad ingresados son incorrectos!!", "Error de login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
        private void btn_recuperar_Click(object sender, EventArgs e)
        {
            recuperarClave();
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
