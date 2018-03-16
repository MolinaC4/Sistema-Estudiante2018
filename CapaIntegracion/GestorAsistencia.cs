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
    public class GestorAsistencia
    {
        //Llena el combo box
        public static void llenarCombo(ComboBox combo)
        {
            MySqlCommand comando = new MySqlCommand();

            comando.Connection = conexion.ObtenerConexion();
            comando.CommandText = ("SELECT id_curso,nombre  from tbl_curso where estado = 'A'");

            try
            {
                MySqlDataAdapter seleccionar = new MySqlDataAdapter();
                seleccionar.SelectCommand = comando;

                DataTable datostabla = new DataTable();
                seleccionar.Fill(datostabla);

                combo.ValueMember = "id_curso";
                combo.DisplayMember = "nombre";

                combo.DataSource = datostabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //Chekea si hay estudiantes en un curso ya
        public static bool CheckearAsistencia(int curso)
        {
            MySqlCommand comando = new MySqlCommand(string.Format("SELECT COUNT(*)  from tbl_asistencia a where a.Fecha = CURDATE() and id_curso = " + curso + ""
              ), conexion.ObtenerConexion());
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

        //Agrega la asistencia
        public static int Agregar(int curso)
        {

            int retorno = 0;
            //Insertar datos de los estudiantes
            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO tbl_asistencia (`id_estudiante`,id_curso,Fecha,Hora,Estado) " +
                                                                "SELECT DISTINCT a.cedula, c.id_curso, CURDATE(), curTime(), 'Ausente'  from tbl_estudiante a " +
                                                                "INNER JOIN tbl_matricula b ON a.cedula = b.tbl_estudiante_cedula " +
                                                                "INNER JOIN tbl_curso c ON c.id_curso = b.curso_id_curso WHERE b.estado = 'A' AND c.id_curso = " + curso + ";" +
                                                                "        INSERT INTO `bd_sistema_estudiante`.`tbl_actividades` (`nombre`, `fecha`, `hora`, `accion`) " +
                                                                "  VALUES((SELECT actual from tbl_usuario_actual where id = 1), CURDATE(), curTime(), 'Generado Asistencia'); "
                ), conexion.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        //Los hace presentes a los estudiantes
        public static int ControlAusencias(int curso, int estudiante)
        {

            int retorno = 0;
            //Insertar datos de los estudiantes
            MySqlCommand comando = new MySqlCommand(string.Format("UPDATE `bd_sistema_estudiante`.`tbl_asistencia` " +
                                                                  "SET `Estado`= 'Presente' " +
                                                                  "WHERE  id_estudiante = " + estudiante + " AND id_curso = " + curso + " AND Fecha = CURDATE(); "
                ), conexion.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        //Los hace ausentes a los estudiantes
        public static int ControlAsistencias(int curso, int estudiante)
        {

            int retorno = 0;
            //Insertar datos de los estudiantes
            MySqlCommand comando = new MySqlCommand(string.Format("UPDATE `bd_sistema_estudiante`.`tbl_asistencia` " +
                                                                  "SET `Estado`= 'Ausente' " +
                                                                  "WHERE  id_estudiante = " + estudiante + " AND id_curso = " + curso + " AND Fecha = CURDATE(); "
                ), conexion.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        //Muestra los datos de los estudiantes
        public static void MostrarDatosAsistencia(DataGridView data, int curso)
        {
            //conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand();
            //Mostrar datos de los estudiantes en matricula
            comando.Connection = conexion.ObtenerConexion();
            comando.CommandText = ("SELECT b.cedula as Cedula, b.nombre as Nombre,b.apellido1 as 'Apellido',c.nombre as Curso,a.Fecha,a.Hora,a.Estado  " +
                                    "from tbl_asistencia a INNER JOIN tbl_estudiante b ON a.id_estudiante = b.cedula " +
                                    "INNER JOIN tbl_curso c ON c.id_curso  = a.id_curso  where c.id_curso = " + curso + " AND Fecha = CURDATE()");

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

        //Buscar datos de los estudiantes
        public static void BuscarDatosEstudiantes(DataGridView data, string dato, int curso)
        {
            //conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand();
            //Buscar datos estudiantes en estudiantes 
            comando.Connection = conexion.ObtenerConexion();
            comando.CommandText = ("SELECT b.cedula as Cedula, b.nombre as Nombre,b.apellido1 as 'Apellido',c.nombre as Curso,a.Fecha,a.Hora,a.Estado  " +
                                    "from tbl_asistencia a INNER JOIN tbl_estudiante b ON a.id_estudiante = b.cedula " +
                                    "INNER JOIN tbl_curso c ON c.id_curso  = a.id_curso  where c.id_curso = " + curso + " AND Fecha = CURDATE() AND (cedula like '" + dato + "%' OR b.nombre like '" + dato + "%' OR apellido1 like '" + dato + "%' OR telefono like '" + dato + "%')" );
                /*("Select cedula AS 'Cédula',nombre AS 'Nombre',apellido1 AS 'Primer Apellido',apellido2 AS 'Segundo Apellido',telefono AS 'Teléfono',direccion AS 'Direccíon',correo AS 'Correo',fechaNacimiento AS 'Fecha de Nacimiento',genero AS 'Genero',tipo AS 'Tipo' from tbl_estudiante Where cedula like '" + dato + "%' OR nombre like '" + dato + "%' OR apellido1 like '" + dato + "%' OR telefono like '" + dato + "%'");*/

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
        //Busca los datos de la asistencia por curso
        public static void BuscarDatosAsistenciaCurso(DataGridView data, int curso, string fecha1, string fecha2)
        {
            //conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand();
            //Buscar datos estudiantes en estudiantes 
            comando.Connection = conexion.ObtenerConexion();
            comando.CommandText = ("Select a.nombre AS 'Nombre de curso',b.cedula AS Cedula,b.nombre AS Nombre, c.Fecha,c.Hora,c.Estado " +
                "from tbl_asistencia c " +
                "INNER JOIN tbl_estudiante b ON b.cedula = c.id_estudiante " +
                "INNER JOIN tbl_curso a ON c.id_curso = a.id_curso " +
                "where a.id_curso = " + curso + " and fecha between '" + fecha1 + "' and '" + fecha2 + "'; ");

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
        //Busca los datos de la asistencia por estudiante
        public static void BuscarDatosAsistenciaEstudiantes(DataGridView data, string dato, string fecha1, string fecha2)
        {
            //conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand();
            //Buscar datos estudiantes en estudiantes 
            comando.Connection = conexion.ObtenerConexion();
            comando.CommandText = ("Select Distinct b.cedula AS Cedula,b.nombre AS Nombre,b.apellido1 AS 'Primer apellido',b.apellido2 AS 'Segundo apellido',a.nombre AS Curso,c.Fecha,c.Hora,c.Estado from tbl_curso a,tbl_estudiante b, tbl_asistencia c WHERE(c.id_estudiante like '" + dato + "%' OR b.nombre like '" + dato + "%') AND a.id_curso = c.id_curso AND b.cedula = c.id_estudiante AND c.Fecha BETWEEN '" + fecha1 + "' AND '" + fecha2 + "'; ");

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
