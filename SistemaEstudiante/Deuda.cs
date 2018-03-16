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
    public partial class Deuda : Form
    {
        public Deuda()
        {
            InitializeComponent();
            Gestor_pagos.MostrarDatosDeudas(dgv_deuda);
        }

        private void picture_atras_Click(object sender, EventArgs e)
        {
            PantallaPrincipal pan = new PantallaPrincipal();
            this.Hide();
            pan.Show();
        }

        private void txt_busqueda_KeyUp(object sender, KeyEventArgs e)
        {
            Gestor_pagos.BuscarDatosEstudiantes(dgv_deuda, txt_busqueda.Text.Trim());
        }
    }
}
