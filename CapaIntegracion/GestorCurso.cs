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
    public class GestorCurso
    {
        //Guardar curso
        public static int Agregar(Curso pCurso)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("CALL InsertarCurso('{1}','{2}', '{3}');" +
                "        INSERT INTO `bd_sistema_estudiante`.`tbl_actividades` (`nombre`, `fecha`, `hora`, `accion`) " +
                "VALUES((SELECT actual from tbl_usuario_actual where id = 1), CURDATE(), curTime(), 'Agrego un curso'); ",
               pCurso.Id_curso, pCurso.Nombre, pCurso.Descripcion, pCurso.Estado), conexion.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }



        //Inactivar curso
        public static int Inactivar(Curso pCurso)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Update tbl_curso SET estado = 'I'  Where descripcion = '{2}';" +
                "        INSERT INTO `bd_sistema_estudiante`.`tbl_actividades` (`nombre`, `fecha`, `hora`, `accion`) " +
                " VALUES((SELECT actual from tbl_usuario_actual where id = 1), CURDATE(), curTime(), 'Inactivo curso'); ", pCurso.Id_curso,
               pCurso.Nombre, pCurso.Descripcion, pCurso.Estado), conexion.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        //Activar cursos eliminados curso 
        public static int Activar(Curso pCurso)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Update tbl_curso SET estado = 'A'  Where descripcion = '{2}';" +
                "        INSERT INTO `bd_sistema_estudiante`.`tbl_actividades` (`nombre`, `fecha`, `hora`, `accion`) " +
                " VALUES((SELECT actual from tbl_usuario_actual where id = 1), CURDATE(), curTime(), 'Inactivo curso'); ", pCurso.Id_curso,
               pCurso.Nombre, pCurso.Descripcion, pCurso.Estado), conexion.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        //Mostras datos
        public static void MostrarDatos(DataGridView data)
        {
            //conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand();

            comando.Connection = conexion.ObtenerConexion();
            comando.CommandText = ("CALL ListarCurso();");

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

        //Mostrar datos de cursos inactivados
        public static void MostrarDatosInactivados(DataGridView data)
        {
            //conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand();

            comando.Connection = conexion.ObtenerConexion();
            comando.CommandText = ("Select descripcion AS 'Código del curso',nombre AS 'Nombre del Curso' from tbl_curso Where estado = 'I' ");

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
        //Buscar curso
        public static void BuscarDatosCurso(DataGridView data, string dato)
        {
            //conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand();

            comando.Connection = conexion.ObtenerConexion();
            comando.CommandText = ("Select descripcion AS 'Código del curso',nombre AS 'Nombre del Curso'  from tbl_curso Where estado = 'A' AND (nombre like '" + dato + "%' OR descripcion like '" + dato + "%')");

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

        //Buscar cursos inactivados
        public static void BuscarDatosCursoInactivados(DataGridView data, string dato)
        {
            //conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand();

            comando.Connection = conexion.ObtenerConexion();
            comando.CommandText = ("Select descripcion AS 'Código del curso',nombre AS 'Nombre del Curso' from tbl_curso Where estado = 'I' AND (nombre like '" + dato + "%' OR descripcion like '" + dato + "%')");

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

        public bool CheckearCursos()
        {
            MySqlCommand comando = new MySqlCommand(string.Format("Select COUNT(*) FROM tbl_curso a where a.estado = 'A'; "), conexion.ObtenerConexion());
            object result = comando.ExecuteScalar();
            int res = Convert.ToInt32(result);

            if (res > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
