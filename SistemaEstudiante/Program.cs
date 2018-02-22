using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaIntegracion;
using CapaLogica.LogicaNegocio;

namespace SistemaEstudiante
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Gestor_usuario usuario = new Gestor_usuario();

            if (!usuario.CheckearPerfiles())
            {
                Application.Run(new RegNewUser());
            }
            else
            {
                Application.Run(new Login());
            }

        }
    }
}
