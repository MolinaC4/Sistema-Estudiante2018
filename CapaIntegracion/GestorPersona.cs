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
using System.Drawing;

namespace CapaIntegracion
{
    public class GestorPersona
    {
        public static int Agregar(Persona pPersona)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("CALL inModEsT('{0}','{1}','{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}');" +
                "        INSERT INTO `bd_sistema_estudiante`.`tbl_actividades` (`nombre`, `fecha`, `hora`, `accion`)" +
                " VALUES((SELECT actual from tbl_usuario_actual where id = 1), CURDATE(), curTime(), 'Agrego un nuevo estudiante'); ",
                pPersona.Cedula, pPersona.Nombre, pPersona.Apellido1, pPersona.Apellido2, pPersona.Telefono, pPersona.Direccion, pPersona.Correo, pPersona.FechaNacimiento, pPersona.Genero, pPersona.Estado, pPersona.Tipo, pPersona.Foto), conexion.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        //Inactivar curso
        public static int Inactivar(Persona pPersona)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Update tbl_estudiante SET estado = 'I'  Where cedula = {0};" +
                "        INSERT INTO `bd_sistema_estudiante`.`tbl_actividades` (`nombre`, `fecha`, `hora`, `accion`) " +
                " VALUES((SELECT actual from tbl_usuario_actual where id = 1), CURDATE(), curTime(), 'Inactivo estudiante'); ", 
                pPersona.Cedula, pPersona.Nombre, pPersona.Apellido1, pPersona.Apellido2, pPersona.Telefono, pPersona.Direccion, pPersona.Correo, pPersona.FechaNacimiento, pPersona.Genero, pPersona.Estado, pPersona.Tipo, pPersona.Foto), conexion.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static void MostrarDatos(DataGridView data)
        {
            //conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand();

            comando.Connection = conexion.ObtenerConexion(); 
            comando.CommandText = ("CALL ListarEstA();");

            try {
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

        public static void MostrarDatosI(DataGridView data)
        {
            //conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand();

            comando.Connection = conexion.ObtenerConexion();
            comando.CommandText = ("CALL ListaEstI();");

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

        //Inactivar curso
        public static int ActivarEst(Persona pPersona)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Update tbl_estudiante SET estado = 'A'  Where cedula = {0};" +
                "        INSERT INTO `bd_sistema_estudiante`.`tbl_actividades` (`nombre`, `fecha`, `hora`, `accion`) " +
                " VALUES((SELECT actual from tbl_usuario_actual where id = 1), CURDATE(), curTime(), 'Activo estudiante'); ",
                pPersona.Cedula, pPersona.Nombre, pPersona.Apellido1, pPersona.Apellido2, pPersona.Telefono, pPersona.Direccion, pPersona.Correo, pPersona.FechaNacimiento, pPersona.Genero, pPersona.Estado, pPersona.Tipo, pPersona.Foto), conexion.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
    }
}