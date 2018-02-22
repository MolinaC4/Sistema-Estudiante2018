using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaLogica.LogicaNegocio;
using CapaConexion;
using System.Data.SqlClient;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace CapaIntegracion
{
    public class GestorActividades
    {
        public static void MostrarDatos(DataGridView data)
        {
            //conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand();

            comando.Connection = conexion.ObtenerConexion();
            comando.CommandText = ("SELECT a.nombre AS  Nombre,a.fecha as Fecha,a.hora AS Hora,a.accion AS Accion from tbl_actividades a ");

            try
            {
                MySqlDataAdapter seleccionar = new MySqlDataAdapter();
                seleccionar.SelectCommand = comando;

                DataTable datostabla = new DataTable();
                seleccionar.Fill(datostabla);

                BindingSource formulario = new BindingSource();
                formulario.DataSource = datostabla;
                data.DataSource = formulario;

                seleccionar.Update(datostabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
