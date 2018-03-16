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
using System.IO;
using CapaLogica.LogicaNegocio;

namespace SistemaEstudiante
{
    public partial class RegNewUser : Form
    {
        bool contraseña = false;
        bool confirmacion = false;
        public RegNewUser()
        {
            InitializeComponent();
            cbx_opcion.SelectedIndex = 0;
        }
        public void registrar()
        {
            if (string.IsNullOrEmpty(txt_confirmacion.Text) || string.IsNullOrEmpty(txt_contrasenna.Text) || string.IsNullOrEmpty(txt_usuario.Text) || string.IsNullOrEmpty(txt_respuestaS.Text))
            {

                MessageBox.Show("Todos los campos deben estar llenos!!");

            }
            else
            {
                if (confirmacion == true)
                {
                    Usuario pUsuario = new Usuario();
                    if (txt_contrasenna.Text == txt_confirmacion.Text)
                    {
                        pUsuario.Nombre = txt_usuario.Text.Trim();
                        pUsuario.Contrasenna = txt_contrasenna.Text.Trim();
                        pUsuario.Nombre = txt_usuario.Text.Trim();
                        pUsuario.TipoPregunta = cbx_opcion.SelectedIndex;
                        pUsuario.RespuestaS = txt_respuestaS.Text.Trim();

                        pUsuario.Tipo = "A";
                        int resultado = Gestor_usuario.Agregar(pUsuario);
                        if (resultado > 0)
                        {
                            MessageBox.Show("Registro exitoso!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Login loguear = new Login();
                            loguear.Show();
                            this.Hide();
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
                else
                {
                    MessageBox.Show("Se produjo un error en los datos ingresados", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            registrar();
        }

        private void RegNewUser_Load(object sender, EventArgs e)
        {
            this.toolTip1.SetToolTip(this.txt_usuario,"Ingrese el nombre de usuario"); 
            this.toolTip1.SetToolTip(this.txt_contrasenna, "Ingrese Contraseña.El formato debe tener almenos una mayuscula,un numero,letra minuscula y debe tener 8 caracteres.");
            this.toolTip1.SetToolTip(this.txt_confirmacion, "Ingrese la misma contraseña.Verifica si ingreso la contrasña correctamente.");
            this.toolTip1.SetToolTip(this.txt_respuestaS, "Ingrese la respuesta a la pregunta de seguridad."); 
        }

        private void txt_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void txt_confirmacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                registrar();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            registrar();
        }



        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_confirmacion.Clear();
            txt_contrasenna.Clear();
            txt_usuario.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_contrasenna_TextChanged(object sender, EventArgs e)
        {
  
        }

        private void txt_contrasenna_KeyUp(object sender, KeyEventArgs e)
        {
            int mayuscula = 0;
            int minuscula = 0;
            int numeros = 0;
            int cantidad = 0;
            string cadena = txt_contrasenna.ToString();
            for (int i = 0; i < cadena.Length; i++)
            {
                if (char.IsNumber(cadena[i]))
                {
                    numeros = numeros + 1;
                }
                else
                {
                    if (char.IsLower(cadena[i]))
                    {
                        minuscula = minuscula + 1;
                    }
                    else
                    {
                        if (char.IsUpper(cadena[i]))
                        {
                            mayuscula = mayuscula + 1;
                        }
                    }
                }
            }
            mayuscula = mayuscula - 6;
            minuscula = minuscula - 23;
            cantidad = cadena.Length - 36;
            if (numeros > 0 && minuscula > 0 && mayuscula > 0 && cantidad == 8)
            {
                label7.Text = "Formato Correcto";
                label7.ForeColor = Color.White;
                label7.Visible = true;
                contraseña = true;
            }
            else
            {
                label7.Text = "Formato invalido. Ejemplo:Luis1997";
                label7.ForeColor = Color.FromArgb(255, 0, 0);
                label7.Visible = true;
            }
        }

        private void txt_confirmacion_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_contrasenna.Text == txt_confirmacion.Text && contraseña == true)
            {
                label8.Text = "Las contraseñas coinciden";
                label8.ForeColor = Color.White;
                label8.Visible = true;
                confirmacion = true;
            }
            else
            {
                label8.Text = "Las contraseñas no coinciden";
                label8.ForeColor = Color.FromArgb(255, 0, 0);
                label8.Visible = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}