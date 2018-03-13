using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace CapaConexion
{
    public class conexion
    {
        protected MySqlConnection conectar;

        public static MySqlConnection ObtenerConexion()
        {
            // Luis
<<<<<<< HEAD
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=bd_sistema_estudiante; Uid=root; pwd=N/A;");
=======
            //MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=bd_sistema_estudiante; Uid=root; pwd=1234;");
>>>>>>> 50cd3ba83e6d1711f32b3829cf8560a31d0b50da
            // Ale
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=bd_sistema_estudiante; Uid=root; pwd=782221mm;");
            conectar.Open();
            return conectar;
        }

        //abrir la conexion
        protected void abrirConexion()
        {
            conectar.Open();
        }

        //Cerrar la conexion
        protected void cerrarConexion()
        {
            conectar.Close();
        }

        protected DataSet seleccionarInformacion(string sentencia)
        {
            DataSet miDataSet = new DataSet();
            MySqlCommand miSqlCommand = conectar.CreateCommand();

            miSqlCommand.CommandText = sentencia;
            MySqlDataAdapter miSqlDataAdapter = new MySqlDataAdapter();

            miSqlDataAdapter.SelectCommand = miSqlCommand;
            miSqlDataAdapter.Fill(miDataSet);

            return miDataSet;
        }
    }
}
