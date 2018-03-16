using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica.LogicaNegocio;
using CapaIntegracion;


namespace SistemaEstudiante
{
    public partial class CambiarContrasenna : Form
    {
        public CambiarContrasenna()
        {
            InitializeComponent();
            cbx_opcion.SelectedIndex = 0;
            Gestor_usuario.MostrarDatos(dgv_usuario);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CambiarContrasenna_Load(object sender, EventArgs e)
        {

        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MenuConfiguracion mnc = new MenuConfiguracion();
            mnc.Show();
            this.Hide();
        }
        //Al presionar en el data grip se rellenan los campos
        private void dgv_usuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string columna1 = string.Empty;
            string columna2 = string.Empty;
            string columna3 = string.Empty;
            string columna4 = string.Empty;
            //string columna5 = string.Empty;
            DataGridViewRow fila = dgv_usuario.CurrentRow; // obtengo la fila actualmente seleccionada en el dataGridView

            columna1 = Convert.ToString(fila.Cells[0].Value); //obtengo el valor de la primer columna
            columna2 = Convert.ToString(fila.Cells[1].Value); //obtengo el valor de la segunda columna
            columna3 = Convert.ToString(fila.Cells[2].Value); //obtengo el valor de la tercera columna
            //columna4 = Convert.ToString(fila.Cells[3].Value); //obtengo el valor de la cuarta columna
            //columna5 = Convert.ToString(fila.Cells[4].Value); //obtengo el valor de la quinta columna

            txt_usuario.Text = columna2.ToString();
            txt_contrasenna.Text = columna3.ToString();
            //txt_confirmacion.Text = columna4.ToStrin

            if (columna4.ToString() == "A")
            {
                rb_admi.Checked = true;
            }
            else
            {
                rb_invitado.Checked = true;
            }
        }
        //Boton de cambiar la contraseña
        private void btn_cambiar_Click(object sender, EventArgs e)
        {
            CapaLogica.LogicaNegocio.Usuario pUsuario = new CapaLogica.LogicaNegocio.Usuario();

            if (string.IsNullOrEmpty(txt_confirmacion.Text) || string.IsNullOrEmpty(txt_contrasenna.Text) || string.IsNullOrEmpty(txt_usuario.Text))
            {

                MessageBox.Show("Todos los campos deben estar llenos!!");

            }
            else
            {
                if (txt_contrasenna.Text == txt_confirmacion.Text)
                {
                    pUsuario.Nombre = txt_usuario.Text.Trim();
                    pUsuario.Contrasenna = txt_contrasenna.Text.Trim();
                    //pUsuario.Estado = "A";

                    if (Gestor_usuario.CarmbiarContrasenna(pUsuario) == 1)
                    {
                        MessageBox.Show("Contraseña cambiada Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Gestor_usuario.MostrarDatos(dgv_usuario);

                        txt_usuario.Clear();
                        txt_contrasenna.Clear();
                        txt_confirmacion.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña cambiada Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txt_confirmacion.Clear();
                        txt_contrasenna.Clear();
                        txt_usuario.Clear();

                        Gestor_usuario.MostrarDatos(dgv_usuario);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden!!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_confirmacion.Clear();
                    txt_contrasenna.Clear();
                    txt_usuario.Clear();
                }
            }
        }
    }
}

