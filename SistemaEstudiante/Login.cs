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

    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        #region Metodos

        public void loguear()
        {
            if (string.IsNullOrEmpty(txt_username.Text) || string.IsNullOrEmpty(txt_pssw.Text))
            {

                MessageBox.Show("Todos los campos deben estar llenos!!");

            }
            else
            {
                Usuario pUsuario = new Usuario();

                pUsuario = Gestor_usuario.Login(txt_username.Text.Trim(), txt_pssw.Text.Trim());
                if (pUsuario.Contrasenna == txt_pssw.Text.Trim() && pUsuario.Nombre == txt_username.Text.Trim())
                {
                    if (pUsuario.Tipo == "I")
                    {
                        Invitado mostrar = new Invitado();
                        this.Hide();
                        mostrar.Show();
                        Gestor_usuario.AgregarInicio("Inicio Sesion");
                    }
                    else
                    {
                        PantallaPrincipal mostrar = new PantallaPrincipal();
                        this.Hide();
                        mostrar.Show();
                        Gestor_usuario.AgregarInicio("Inicio Sesion");
                    }
                }
                else
                {
                    MessageBox.Show("El nombre de usuario o contraseña ingresados son incorrectos!!", "Error de login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        #endregion Metodos

        #region Eventos
        private void btn_login_Click(object sender, EventArgs e)
        {
            loguear();
            txt_username.Clear();
            txt_pssw.Clear();
        }


        private void txt_pssw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                loguear();
                txt_username.Clear();
                txt_pssw.Clear();
            }
        }

        private void txt_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            registro mostrar = new registro();
            mostrar.Show();
        }

        private void btn_login_Click_1(object sender, EventArgs e)
        {
            loguear();
            txt_username.Clear();
            txt_pssw.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            registro mostrar = new registro();
            mostrar.Show();
            
        }
        #endregion Eventos 

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecuperarClave rc = new RecuperarClave();
            rc.Show();
            this.Hide();
        }

        private void Ch_contrasenna_CheckedChanged(object sender, EventArgs e) 
        {
            //Es un check box que hace que oculte la contraseña o la muestra
            //txt_pssw.UseSystemPasswordChar = !ch_contrasenna.Checked;

            //Este pedazo de codigo hace lo mismo que el de arriba, ocultar la contraseña
             string text = txt_pssw.Text;
             if (ch_contrasenna.Checked)
             {
                 txt_pssw.UseSystemPasswordChar = false;
                 txt_pssw.Text = text;

             }
             else
             {
                 txt_pssw.UseSystemPasswordChar = true;
                 txt_pssw.Text = text;
             }
        }
    }
}