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
    public partial class ListaEstudiantes : Form
    {
        public ListaEstudiantes()
        {
            InitializeComponent();
            GestorPersona.MostrarDatos(dgv_estudiante);
        }

        #region Eventos
        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            GestorMatricula.BuscarDatosEstudiantes(dgv_estudiante, txt_buscar.Text.Trim());
        }

        private void picture_atras_Click(object sender, EventArgs e)
        {
            Estudiante est = new Estudiante();
            this.Hide();
            est.Show();
        }
        #endregion Eventos
    }
}
