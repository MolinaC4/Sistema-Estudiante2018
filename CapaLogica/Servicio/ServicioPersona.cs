using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaConexion;
using CapaLogica.LogicaNegocio;
using MySql.Data.MySqlClient;
using System.Data;

namespace CapaLogica.Servicio
{
    public class ServicioPersona 
        //: conexion, IDisposable
    {
        //private string respuesta;
        //private MySqlCommand miComando;

        //public ServicioPersona()
        //{
        //    respuesta = "";
        //    miComando = new MySqlCommand();
        //}

        //Este metodo es solicitado por la interfaz IDisposable
        //public void Dispose()
        //{
        //}

        //Metodo para la SP de ConsultarCitaXVeterinario
        //public DataSet ConsultaCitaPorFecha(string Cita_fecha)
        //{
        //    miComando.CommandText = "ConsultaCitaPorFecha";
        //    miComando.Parameters.AddWithValue("@Cita_fecha", MySqlDbType.VarChar);
        //    miComando.Parameters["@Cita_fecha"].Value = Cita_fecha;

        //    DataSet miDataSet = new DataSet();
        //    this.abrirConexion();

        //    miDataSet = this.seleccionarInformacion(miComando);
        //    this.cerrarConexion();

        //    return miDataSet;
        //}

    }
}
