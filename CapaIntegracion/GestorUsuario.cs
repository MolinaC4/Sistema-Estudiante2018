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
    public class Gestor_usuario
    {
        public bool CheckearPerfiles()
        {
            MySqlCommand comando = new MySqlCommand(string.Format("Select COUNT(*) FROM tbl_usuario a where a.tipo = 'A'; " +
                                                                  "INSERT INTO tbl_usuario_actual (id, actual) VALUES(1, 'Usuario')" +
                                                                  " ON DUPLICATE KEY UPDATE  actual = 'Usuario';"
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

        public static Usuario Login(string nombre, string contrasenna)
        {
            Usuario pUsuario = new Usuario();
            MySqlCommand comando = new MySqlCommand(string.Format("SELECT nombreUsuario,contraseña,tipo,respuestaS,tipoPregunta FROM tbl_usuario WHERE nombreUsuario = '" + nombre + "' AND contraseña = '" + contrasenna + "' AND contraseña = '" + contrasenna + "'; UPDATE `bd_sistema_estudiante`.`tbl_usuario_actual` SET `actual`= '" +  nombre + "' WHERE  `id`= 1; ",
               pUsuario.Nombre, pUsuario.Contrasenna, pUsuario.Tipo), conexion.ObtenerConexion());
            MySqlDataReader _reader = comando.ExecuteReader();

            while (_reader.Read())
            {
                pUsuario.Nombre = _reader.GetString(0);
                pUsuario.Contrasenna = _reader.GetString(1);
                pUsuario.Tipo = _reader.GetString(2);
            }

            return pUsuario;
        }

        public static Usuario RecuperarClave(string nombre, string respuestaS, int tipoP)
        {
            Usuario pUsuario = new Usuario();
            MySqlCommand comando = new MySqlCommand(string.Format("SELECT nombreUsuario, contraseña, respuestaS, tipoPregunta FROM tbl_usuario WHERE nombreUsuario = '" + nombre + "' AND respuestaS = '" + respuestaS + "' AND tipoPregunta = '" + tipoP + "'; UPDATE `bd_sistema_estudiante`.`tbl_usuario_actual` SET `actual`= '" + nombre + "' WHERE  `id`= 1; ",
               pUsuario.Nombre, pUsuario.RespuestaS, pUsuario.TipoPregunta), conexion.ObtenerConexion());
            MySqlDataReader _reader = comando.ExecuteReader();

            while (_reader.Read())
            {
                pUsuario.Nombre = _reader.GetString(0);
                pUsuario.Contrasenna = _reader.GetString(1);
                pUsuario.RespuestaS = _reader.GetString(2);
                pUsuario.TipoPregunta = _reader.GetInt32(3);
            }

            return pUsuario;
        }

        public static int AgregarInicio(string accion)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO `bd_sistema_estudiante`.`tbl_actividades` (`nombre`, `fecha`, `hora`, `accion`) " +
                "VALUES((SELECT actual from tbl_usuario_actual where id = 1), CURDATE(), curTime(), '" + accion + "');"), conexion.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        //Agrega el usuario desde el formulario nuevo usuario
        public static int Agregar(Usuario pUsuario)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into tbl_usuario(nombreUsuario, contraseña, tipo, respuestaS, tipoPregunta) values ('" + pUsuario.Nombre + "','" + pUsuario.Contrasenna + "','" + pUsuario.Tipo + "','" + pUsuario.RespuestaS + "','" + pUsuario.TipoPregunta + "')",
               pUsuario.Nombre, pUsuario.Contrasenna, pUsuario.Tipo, pUsuario.RespuestaS, pUsuario.TipoPregunta), conexion.ObtenerConexion()); 
               retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        //Muestra los datos de los usuarios en el data grip de Lista de usuario (Son los usuarios invitados)
        public static void MostrarDatosInvitados(DataGridView data)
        {
            //conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand();

            comando.Connection = conexion.ObtenerConexion();
            comando.CommandText = ("CALL ListaUsuariosInvitados();");

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
        //Eiminar usuarios invitados no sirve aun
        public static int EliminarUsuarioInvitado(Usuario pUsuario)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("DELETE FROM tbl_usuario  WHERE id_administrador = {0};" +
                "        INSERT INTO `bd_sistema_estudiante`.`tbl_actividades` (`nombre`, `fecha`, `hora`, `accion`)" +
                " VALUES((SELECT actual from tbl_usuario_actual where id = 1), CURDATE(), curTime(), 'Cambio contraseña'); ", pUsuario.Id_administrador,
               pUsuario.Nombre, pUsuario.Contrasenna, pUsuario.Tipo), conexion.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }


        //Muestra los datos de los usuarios en el data grip de cambiar contraseña
        public static void MostrarDatos(DataGridView data)
        {
            //conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand();

            comando.Connection = conexion.ObtenerConexion();
            comando.CommandText = ("CALL ListarUsuarios();");

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
        
        //Cambiar contraseña 
        public static int CarmbiarContrasenna(Usuario pUsuario)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Update tbl_usuario SET contraseña = '{2}'  Where id_administrador = {0};" +
                "        INSERT INTO `bd_sistema_estudiante`.`tbl_actividades` (`nombre`, `fecha`, `hora`, `accion`)" +
                " VALUES((SELECT actual from tbl_usuario_actual where id = 1), CURDATE(), curTime(), 'Cambio contraseña'); ", pUsuario.Id_administrador,
               pUsuario.Nombre, pUsuario.Contrasenna, pUsuario.Tipo), conexion.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        
        public static int AgregarInicio(Usuario pUsuario)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("UPDATE `bd_sistema_estudiante`.`tbl_usuario_actual` SET `actual`='" + pUsuario.Nombre + "' WHERE  `id`=1",
               pUsuario.Nombre, pUsuario.Contrasenna, pUsuario.Tipo), conexion.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        // INSERT INTO `bd_sistema_estudiante`.`tbl_actividades` (`nombre`, `fecha`, `hora`, `accion`)
        //VALUES((SELECT actual from tbl_usuario_actual where id= 1), CURDATE(), curTime(), 'eliminar');
    }
}
