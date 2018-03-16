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
    public partial class ListaUsuarios : Form
    {
        public ListaUsuarios()
        {
            InitializeComponent();

            Gestor_usuario.MostrarDatosInvitados(dgv_usuario);
        }

        //Atras
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MenuConfiguracion mnc = new MenuConfiguracion();
            mnc.Show();
            this.Hide();
        }
        //Cerrar sesion
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

        private void btn_eliminar_invitado_Click(object sender, EventArgs e)
        {
            CapaLogica.LogicaNegocio.Usuario pUsuario = new CapaLogica.LogicaNegocio.Usuario();
            pUsuario.Id_administrador = int.Parse(txt_codigo.Text.Trim());
            pUsuario.Nombre = txt_usuario.Text.Trim();



            int resultado = Gestor_usuario.EliminarUsuarioInvitado(pUsuario);
            if (resultado > 0)
            {
                MessageBox.Show("Usuario Eliminado Con Exito!!", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Gestor_usuario.MostrarDatosInvitados(dgv_usuario);

                txt_codigo.Clear();
                txt_usuario.Clear();

            }
            else
            {
                MessageBox.Show("No se pudo eliminar el usuario", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgv_usuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string columna1 = string.Empty;
            string columna2 = string.Empty;
            string columna3 = string.Empty;
            DataGridViewRow fila = dgv_usuario.CurrentRow; // obtengo la fila actualmente seleccionada en el dataGridView

            columna1 = Convert.ToString(fila.Cells[0].Value); //obtengo el valor de la primer columna
            columna2 = Convert.ToString(fila.Cells[1].Value); //obtengo el valor de la segunda columna
            columna3 = Convert.ToString(fila.Cells[2].Value); //obtengo el valor de la tercera columna

            txt_codigo.Text = columna1.ToString();
            txt_usuario.Text = columna2.ToString();

            if (columna3.ToString() == "A")
            {
                rb_admi.Checked = true;
            }
            else
            {
                rb_invitado.Checked = true;
            }
        }
    }
}
