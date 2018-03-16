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
    public class Gestor_pagos
    {
        public static int crear_deuda()
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("call insertar_deuda(); "), conexion.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static void MostrarDatosDeudas(DataGridView data)
        {
            //conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand();

            comando.Connection = conexion.ObtenerConexion();
            comando.CommandText = ("SELECT d.tbl_estudiante_cedula as 'Cedula de estudiante', e.nombre as 'Nombre', e.apellido1 as 'Apellido', d.deuda as 'Debe(D) o Pago(P)', d.fecha as 'Fecha Inicio Deuda', d.observaciones as 'Observación'  FROM tbl_deuda d, tbl_estudiante e WHERE e.cedula = d.tbl_estudiante_cedula AND d.estado = 'A' AND e.estado = 'A'");

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

        public static void BuscarDatosEstudiantes(DataGridView data, string dato)
        {
            //conexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand();
            //Buscar datos estudiantes en estudiantes 
            comando.Connection = conexion.ObtenerConexion();
            comando.CommandText = ("SELECT d.tbl_estudiante_cedula as 'Cedula de estudiante', e.nombre as 'Nombre', e.apellido1 as 'Apellido', d.deuda as 'Debe(D) o Pago(P)', d.fecha as 'Fecha Inicio Deuda', d.observaciones as 'Observación'  FROM tbl_deuda d, tbl_estudiante e WHERE e.cedula = d.tbl_estudiante_cedula AND d.estado = 'A' AND e.estado = 'A'"+
                                    "AND (e.cedula like '" + dato + "%' OR e.nombre like '" + dato + "%' OR e.apellido1 like '" + dato + "%')");

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