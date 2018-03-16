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
    public partial class registro : Form
    {
        public registro()
        {
            InitializeComponent();
            cbx_opcion.SelectedIndex = 0;
        }

        #region Metodos
        public void registrar()
        {
            if (string.IsNullOrEmpty(txt_confirmacion.Text) || string.IsNullOrEmpty(txt_contrasenna.Text) || string.IsNullOrEmpty(txt_usuario.Text))
            {

                MessageBox.Show("Todos los campos deben estar llenos!!");

            }
            else
            {
                Usuario pUsuario = new Usuario();
                if (txt_contrasenna.Text == txt_confirmacion.Text)
                {
                    pUsuario.Nombre = txt_usuario.Text.Trim();
                    pUsuario.Contrasenna = txt_contrasenna.Text.Trim();
                    pUsuario.TipoPregunta = cbx_opcion.SelectedIndex;
                    pUsuario.RespuestaS = txt_respuestaS.Text.Trim();
                    if (rb_admi.Checked)
                    {
                        pUsuario.Tipo = "A";
                    }
                    else
                    {
                        pUsuario.Tipo = "I";
                    }
                    int resultado = Gestor_usuario.Agregar(pUsuario);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Registro exitoso!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    txt_confirmacion.Clear();
                    txt_contrasenna.Clear();
                    txt_usuario.Clear();
                    txt_respuestaS.Clear();
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden!!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_confirmacion.Clear();
                    txt_contrasenna.Clear();
                }
            }

        }
        #endregion Metodos 

        #region Eventos

        private void button1_Click(object sender, EventArgs e)
        {
            registrar();
        }

        private void registro_Load(object sender, EventArgs e)
        {
            rb_invitado.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                registrar();
            }
        }

        private void rb_masculino_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                registrar();
            }
        }

        private void rb_femenino_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                registrar();
            }
        }


        private void txt_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void txt_contrasenna_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void txt_confirmacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            registrar();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MenuConfiguracion mnc = new MenuConfiguracion();
            mnc.Show();
            this.Hide();
        }

        #endregion

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

        private void nuevoEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_usuario.Clear();
            txt_contrasenna.Clear();
            txt_confirmacion.Clear();
            txt_respuestaS.Clear();
        }

        private void rb_masculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_invitado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbx_opcion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
