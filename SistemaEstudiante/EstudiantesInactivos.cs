using CapaIntegracion;
using CapaLogica.LogicaNegocio;
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
    public partial class EstudiantesInactivos : Form
    {
        public EstudiantesInactivos()
        {
            InitializeComponent();
            GestorPersona.MostrarDatosI(dgv_estinactivo);
        }

        private void picture_atras_Click(object sender, EventArgs e)
        {
            Estudiante est = new Estudiante();
            this.Hide();
            est.Show();
        }

        private void btnActiva_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_cedula1.Text))
            {
                MessageBox.Show("Debe Ingresar un estudiante para Activarlo");
            }
            else
            {
                Persona pPersona = new Persona();
                pPersona.Cedula = int.Parse(txt_cedula1.Text.Trim());

                int resultado = GestorPersona.ActivarEst(pPersona);

                if (resultado > 0)
                {
                    MessageBox.Show("Estudiante Activado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GestorPersona.MostrarDatosI(dgv_estinactivo);

                    txt_cedula1.Clear();

                }
                else
                {
                    MessageBox.Show("No se pudo activar el estudiante", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        public void llenarcampo(){
            string columna1 = string.Empty;

            DataGridViewRow fila = dgv_estinactivo.CurrentRow; // obtengo la fila actualmente seleccionada en el dataGridView

            columna1 = Convert.ToString(fila.Cells[0].Value); //obtengo el valor de las columnas

            txt_cedula1.Text = columna1.ToString();

        }

        private void dgv_estinactivo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            llenarcampo();
        }
    }
}
