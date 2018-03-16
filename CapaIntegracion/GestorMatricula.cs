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
    public class GestorMatricula
    {
        public static int Agregar(Matricula pMatricula)
        {

            int retorno = 0;
            //Insertar datos de los estudiantes
            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO tbl_matricula (fecha, estado, curso_id_curso, tbl_estudiante_cedula) VALUES (YEAR(NOW()), 'A',{0}, {1});" +
                                                                 "INSERT INTO `bd_sistema_estudiante`.`tbl_actividades` (`nombre`, `fecha`, `hora`, `accion`)" +
                                                                 " VALUES((SELECT actual from tbl_usuario_actual where id = 1), CURDATE(), curTime(), 'A matriculado un curso'); ",
               pMatricula.Curso_id_curso, pMatricula.Tbl_estudiante_cedula), conexion.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        public static void llenarCombo(ComboBox combo)
        {
            MySqlCommand comando = new MySqlCommand();

            comando.Connection = conexion.ObtenerConexion();
            comando.CommandText = ("Select id_curso,nombre from tbl_curso");

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
        public static void BuscarDatosEstudiantes(DataGridView data,string dato)
        {
            //conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand();
            //Buscar datos estudiantes en estudiantes 
            comando.Connection = conexion.ObtenerConexion();
            comando.CommandText = ("Select cedula,nombre,apellido1,apellido2,telefono,direccion,correo,fechaNacimiento,genero,tipo from tbl_estudiante Where cedula like '" + dato + "%' OR nombre like '" + dato + "%' OR apellido1 like '" + dato + "%' OR telefono like '" + dato + "%'");

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
        public static void MostrarDatosEstudiantes(DataGridView data)
        {
            //conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand();
            //Mostrar datos de los estudiantes en matricula
            comando.Connection = conexion.ObtenerConexion();
            comando.CommandText = ("Select  cedula,nombre,apellido1,apellido2,telefono,direccion,correo,fechaNacimiento,genero,tipo from tbl_estudiante Where estado = 'A'");

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
        public static void MostrarDatos(DataGridView data,int id)
        {
            //conexion.ObtenerConexion();
            //Mostrar estudiantes matriculados segun el curso
            MySqlCommand comando = new MySqlCommand();

            comando.Connection = conexion.ObtenerConexion();
            comando.CommandText = ("Select distinct cedula,a.nombre,apellido1,apellido2,telefono from tbl_estudiante a,tbl_matricula b,tbl_curso c Where a.cedula = b.tbl_estudiante_cedula and "+id+ " = b.curso_id_curso and a.estado = 'A' and fecha= YEAR(NOW())");

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