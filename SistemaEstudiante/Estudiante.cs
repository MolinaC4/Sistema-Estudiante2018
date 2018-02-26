using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaIntegracion;
using CapaLogica.LogicaNegocio;
using System.IO;
using System.Drawing.Imaging;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace SistemaEstudiante
{
    public partial class Estudiante : Form
    {
        string destino;
        string archivo;

        public Estudiante()
        {
            InitializeComponent();

            //GestorPersona.MostrarDatos(dgv_estudiante);
            BuscarDispositivos();


        }

        /*Me falta validacion de la cedula y quitar doble conexion*/

        #region Metodos

        /*public void llenarcampos(){
            string columna1 = string.Empty;
            string columna2 = string.Empty;
            string columna3 = string.Empty;
            string columna4 = string.Empty;
            string columna5 = string.Empty;
            string columna6 = string.Empty;
            string columna7 = string.Empty;
            string columna8 = string.Empty;
            string columna9 = string.Empty;
            string columna10 = string.Empty;
            string columna11 = string.Empty;

            DataGridViewRow fila = dgv_estudiante.CurrentRow; // obtengo la fila actualmente seleccionada en el dataGridView

            columna1 = Convert.ToString(fila.Cells[0].Value); //obtengo el valor de las columnas
            columna2 = Convert.ToString(fila.Cells[1].Value);
            columna3 = Convert.ToString(fila.Cells[2].Value);
            columna4 = Convert.ToString(fila.Cells[3].Value);
            columna5 = Convert.ToString(fila.Cells[4].Value);
            columna6 = Convert.ToString(fila.Cells[5].Value);
            columna7 = Convert.ToString(fila.Cells[6].Value);
            columna8 = Convert.ToString(fila.Cells[7].Value);
            columna9 = Convert.ToString(fila.Cells[8].Value);
            columna10 = Convert.ToString(fila.Cells[9].Value);
            columna11 = Convert.ToString(fila.Cells[10].Value);

            txt_cedula.Text = columna1.ToString();
            txt_nombre.Text = columna2.ToString();
            txt_primer_apellido1.Text = columna3.ToString();
            txt_segundo_apellido2.Text = columna4.ToString();
            txt_telefono.Text = columna5.ToString();
            txt_direccion.Text = columna6.ToString();
            txt_correo.Text = columna7.ToString();
            txt_fecha.Text = columna8.ToString();

            if (columna9.ToString() == "M")
            {
                rb_masculino.Checked = true;
            }
            else
            {
                rb_femenino.Checked = true;
            }

            cbx_tipo.Text = columna10.ToString();
            pictureBox2.ImageLocation = columna11;
        }*/

        private bool ExistenDispositivos = false;
        private FilterInfoCollection DispositivosDeVideo;
        private VideoCaptureDevice FuenteDeVideo = null;

        public void registro()
        {
            if (string.IsNullOrEmpty(txt_cedula.Text) || string.IsNullOrEmpty(txt_nombre.Text) || string.IsNullOrEmpty(txt_primer_apellido1.Text)
                || string.IsNullOrEmpty(txt_segundo_apellido2.Text) || string.IsNullOrEmpty(txt_telefono.Text) || string.IsNullOrEmpty(txt_direccion.Text)
                || string.IsNullOrEmpty(txt_correo.Text) || string.IsNullOrEmpty(txt_fecha.Text) || pictureBox2.Image == null)
            {
                MessageBox.Show("Todos los campos deben estar llenos!!");
            }
            else
            {

                Persona pPersona = new Persona();

                pPersona.Nombre = txt_nombre.Text.Trim();
                pPersona.Apellido1 = txt_primer_apellido1.Text.Trim();
                pPersona.Apellido2 = txt_segundo_apellido2.Text.Trim();

                //MessageBox.Show(txt_nombre.Text.Trim(), "prueba", MessageBoxButtons.OK);

                pPersona.Direccion = txt_direccion.Text.Trim();
                pPersona.Correo = txt_correo.Text.Trim();
                pPersona.Estado = "A";
                pPersona.Tipo = cbx_tipo.Text.Trim();

                if (rb_masculino.Checked)
                {
                    pPersona.Genero = "M";
                }
                else
                {
                    pPersona.Genero = "F";
                }

                String t = txt_fecha.Text;
                t = t.Replace("/", "");

                if (ValidaFecha.Text == "Fecha Invalida")
                {
                    MessageBox.Show("Error en el formato de fecha, Debe ser: dd/mm/aaaa. dd: Día, mm: Mes, aaaa: Año", "Error!", MessageBoxButtons.OK);
                    //errorProvider1.SetError(txt_fecha, "Error en el formato de fecha, Debe ser: dd/mm/aaaa. dd: Día, mm: Mes, aaaa: Año");
                }
                else if (txt_telefono.TextLength != 8)
                {
                    MessageBox.Show("Número No Valido. ", "Error!", MessageBoxButtons.OK);
                }
                else if (txt_cedula.TextLength < 9)
                {
                    MessageBox.Show("Cédula No Valida, Debe Incluir los '0' ", "Error!", MessageBoxButtons.OK);
                }
                else if (lEmailCorrecto.Text == "Dirección Invalida") {
                    MessageBox.Show("Correo No valido","Error!", MessageBoxButtons.OK);
                }
                else
                {
                    //archivo = @"C:\Users\Ale Molina\Pictures\" + txt_cedula.Text + ".png";
                    archivo = Application.StartupPath + @"\Recursos\" + txt_cedula.Text + ".png";
                    //pictureBox2.Image.Save(archivo, ImageFormat.Png);
                    //pictureBox2.Image.Save(@"C:\Users\Ale Molina\Pictures\" + txt_nombre.Text + ".png", ImageFormat.Png);
                    //MessageBox.Show("Imagen guardada", "prueba", MessageBoxButtons.OK);

                    pPersona.Cedula = int.Parse(txt_cedula.Text.Trim());
                    pPersona.FechaNacimiento = txt_fecha.Text.Trim();
                    pPersona.Telefono = txt_telefono.Text.Trim();
                    pPersona.Foto = archivo.Replace("\\", "\\\\");
                    //MessageBox.Show(archivo.Replace("\\", "\\\\"), "prueba", MessageBoxButtons.OK);

                    int resultado = GestorPersona.Agregar(pPersona);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Cliente Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //GestorPersona.MostrarDatos(dgv_estudiante);

                        txt_cedula.Clear();
                        txt_correo.Clear();
                        txt_direccion.Clear();
                        txt_fecha.Clear();
                        txt_nombre.Clear();
                        txt_primer_apellido1.Clear();
                        txt_segundo_apellido2.Clear();
                        txt_telefono.Clear();
                        rb_femenino.Checked = false;
                        rb_masculino.Checked = true;
                        pictureBox2.Image = null;
                        ValidaFecha.Text = String.Empty;
                        lEmailCorrecto.Text = String.Empty;
                        errorProvider1.Clear();

                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar el cliente", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        //Inicia la camara
        private void Iniciar_camara()
        {
            if (btnIniciar.Text == "Iniciar")
            {
                if (ExistenDispositivos)
                {
                    FuenteDeVideo = new VideoCaptureDevice(DispositivosDeVideo[cboDispositivos.SelectedIndex].MonikerString);
                    FuenteDeVideo.NewFrame += new NewFrameEventHandler(video_NuevoFrame);
                    FuenteDeVideo.Start();
                    btnIniciar.Text = "Detener";
                    cboDispositivos.Enabled = false;
                    //gbMenu.Text = DispositivosDeVideo[cboDispositivos.SelectedIndex].Name.ToString();
                }
                else
                    MessageBox.Show("Error: No se encuentra dispositivo.");
            }
            else
            {
                if (FuenteDeVideo.IsRunning)
                {
                    TerminarFuenteDeVideo();
                    btnIniciar.Text = "Iniciar";
                    cboDispositivos.Enabled = true;
                }
            }
        }

        public void CargarDispositivos(FilterInfoCollection Dispositivos)
        {
            for (int i = 0; i < Dispositivos.Count; i++)
                cboDispositivos.Items.Add(Dispositivos[i].Name.ToString()); //cboDispositivos es nuestro combobox
            cboDispositivos.Text = cboDispositivos.Items[0].ToString();
        }

        public void BuscarDispositivos()
        {
            DispositivosDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (DispositivosDeVideo.Count == 0)
                ExistenDispositivos = false;
            else
            {
                ExistenDispositivos = true;
                CargarDispositivos(DispositivosDeVideo);
            }
        }

        public void TerminarFuenteDeVideo()
        {
            if (!(FuenteDeVideo == null))
                if (FuenteDeVideo.IsRunning)
                {
                    FuenteDeVideo.SignalToStop();
                    FuenteDeVideo = null;
                }
        }

        private void video_NuevoFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            pictureBox2.Image = Imagen; //pbFotoUser es nuestro pictureBox
        }

        public static bool ComprobarFormatoEmail(string sEmailAComprobar)
        {
            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(sEmailAComprobar, sFormato))
            {
                if (Regex.Replace(sEmailAComprobar, sFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool isValidDate(string strDate)
        {
            DateTime date;
            if (DateTime.TryParseExact(strDate, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo, System.Globalization.DateTimeStyles.None, out date))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Boton de cargar estudiante
        private void btn_cargar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_cedula.Text))
            {
                MessageBox.Show("Digite la cedula");
            }
            else
            {
                int cedula = int.Parse(txt_cedula.Text);
                // GestorPersona.CargarDatos(cedula, txt_nombre, txt_primer_apellido1);

                // conexion.ObtenerConexion();
                string connstring = "SERVER=127.0.0.1;" + "DATABASE=bd_sistema_estudiante;" + "UID=root;" + "PASSWORD=1234;";
                MySqlConnection cnn = new MySqlConnection(connstring);


                cnn.Open();
                string sql = "SELECT nombre,apellido1, apellido2, telefono, direccion, correo, fechaNacimiento, genero, tipo, foto FROM tbl_estudiante WHERE cedula = " + cedula + "; ";
                MySqlCommand cmd = new MySqlCommand(sql, cnn);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txt_nombre.Text = Convert.ToString(reader["nombre"]);
                    txt_primer_apellido1.Text = Convert.ToString(reader["apellido1"]);
                    txt_segundo_apellido2.Text = Convert.ToString(reader["apellido2"]);
                    txt_telefono.Text = Convert.ToString(reader["telefono"]);
                    txt_direccion.Text = Convert.ToString(reader["direccion"]);
                    txt_correo.Text = Convert.ToString(reader["correo"]);
                    txt_fecha.Text = Convert.ToDateTime(reader["fechaNacimiento"]).ToString("dd/MM/yyyy");

                    if (Convert.ToString(reader["genero"]) == "F")
                    {
                        rb_femenino.Checked = true;
                    }
                    else
                    {
                        rb_masculino.Checked = true;
                    }

                    cbx_tipo.Text = Convert.ToString(reader["tipo"]);
                    pictureBox2.ImageLocation = Convert.ToString(reader["foto"]);
                }
                else
                {
                    MessageBox.Show("No hay registros", "prueba", MessageBoxButtons.OK);
                }
            }
        }

        #endregion Metodos

        #region Eventos

        private void Estudiante_Load(object sender, EventArgs e)
        {
            rb_masculino.Checked = true;
        }

        private void btn_insertar_Click(object sender, EventArgs e)
        {
            registro();
        }

        private void txt_cedula_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                errorProvider1.Clear();
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
                errorProvider1.Clear();
            }
            else
            {
                e.Handled = true;
                errorProvider1.SetError(txt_telefono, "Solo puede digitar numeros");

                //  MessageBox.Show("Solo puede digitar numeros", "Error!",
                //  MessageBoxButtons.OK, MessageBoxIcon.Question,
                //  MessageBoxDefaultButton.Button1,
                //  MessageBoxOptions.RtlReading
                //| MessageBoxOptions.RightAlign);
            }
            if (txt_telefono.TextLength != 8)
            {
                //MessageBox.Show("Número No Valido. ", "Error!", MessageBoxButtons.OK);
                errorProvider1.SetError(txt_telefono, "Número No Valido. Debe tener 8 números");
            }
            else
            {
                errorProvider1.Clear();
            }

        }

        /*private void dgv_estudiante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            llenarcampos();
        }*/

        private void siguiente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                //MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider1.SetError(txt_nombre, "Solo se permiten letras");
                e.Handled = true;
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txt_primer_apellido1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                //MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider1.SetError(txt_primer_apellido1, "Solo se permiten letras");
                e.Handled = true;
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txt_segundo_apellido2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                //MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                errorProvider1.SetError(txt_segundo_apellido2, "Solo se permiten letras");
                e.Handled = true;
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Esta seguro de abandonar esta ventana?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                PantallaPrincipal pan = new PantallaPrincipal();
                this.Hide();
                TerminarFuenteDeVideo();
                btnIniciar.Text = "Iniciar";
                cboDispositivos.Enabled = true;
                pan.Show();
            }
            
        }

        /*private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            GestorMatricula.BuscarDatosEstudiantes(dgv_estudiante, txt_buscar.Text.Trim());
        }*/

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Se crea el OpenFileDialog
            OpenFileDialog dialog = new OpenFileDialog();
            // Se muestra al usuario esperando una acción
            dialog.Filter = "png|*.png| jpg|*.jpg";
            //dialog.InitialDirectory = "C:\\";
            DialogResult result = dialog.ShowDialog();

            // Si seleccionó un archivo (asumiendo que es una imagen lo que seleccionó)
            // la mostramos en el PictureBox de la inferfaz
            if (result == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(dialog.FileName);
                archivo = dialog.FileName;
                //txt_buscar.Text = archivo;

                destino = Path.Combine(Application.StartupPath, string.Format("Recursos\\{0}", Path.GetFileName(archivo)));
                File.Copy(archivo, destino);

                //txt_buscar.Text = destino;
            }

        }

        private void cbx_tipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void nuevoEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
            txt_cedula.Clear();
            txt_correo.Clear();
            txt_direccion.Clear();
            txt_fecha.Clear();
            txt_nombre.Clear();
            txt_primer_apellido1.Clear();
            txt_segundo_apellido2.Clear();
            txt_telefono.Clear();
            rb_femenino.Checked = false;
            rb_masculino.Checked = true;
        }

        private void AyudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //add scrollable messagebox with manual content
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Iniciar_camara();
        }

        private void ptb_Inactiva_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_cedula.Text))
            {
                MessageBox.Show("Debe Ingresar un estudiante para eliminarlo/inactivarlo");
            }
            else
            {
                Persona pPersona = new Persona();
                pPersona.Cedula = int.Parse(txt_cedula.Text.Trim());
                pPersona.Nombre = txt_nombre.Text.Trim();
                pPersona.Apellido1 = txt_primer_apellido1.Text.Trim();
                pPersona.Apellido2 = txt_segundo_apellido2.Text.Trim();
                pPersona.Telefono = txt_telefono.Text.Trim();
                pPersona.Direccion = txt_direccion.Text.Trim();
                pPersona.Correo = txt_correo.Text.Trim();
                pPersona.Estado = "A";
                pPersona.Tipo = cbx_tipo.Text.Trim();
                //pPersona.Foto = archivo.Replace("\\", "\\\\");
                pPersona.FechaNacimiento = txt_fecha.Text.Trim();

                if (rb_masculino.Checked)
                {
                    pPersona.Genero = "M";
                }
                else
                {
                    pPersona.Genero = "F";
                }

                int resultado = GestorPersona.Inactivar(pPersona);

                if (resultado > 0)
                {
                    MessageBox.Show("Estudiante Eliminado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // GestorPersona.MostrarDatos(dgv_estudiante);

                    txt_cedula.Clear();
                    txt_correo.Clear();
                    txt_direccion.Clear();
                    txt_fecha.Clear();
                    txt_nombre.Clear();
                    txt_primer_apellido1.Clear();
                    txt_segundo_apellido2.Clear();
                    txt_telefono.Clear();
                    rb_femenino.Checked = false;
                    rb_masculino.Checked = true;
                    pictureBox2.Image = null;
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el estudiante", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void cbx_tipo_ValueMemberChanged(object sender, EventArgs e)
        {
            if (cbx_tipo.Text == "Regular(Colegio)")
            {
                cbx_tipo.ValueMember = "Regular(Colegio)";
            }
            else if (cbx_tipo.Text == "Bachiller Por Madurez")
            {
                cbx_tipo.ValueMember = "Bachiller Por Madurez";
            }
            else
            {
                cbx_tipo.ValueMember = "Por Centros";
            }
        }

        /* private void dgv_estudiante_DoubleClick(object sender, EventArgs e)
         {
             llenarcampos();
         }*/

        private void listaDeEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de abandonar esta ventana?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                ListaEstudiantes lista = new ListaEstudiantes();
                this.Hide();
                lista.Show();
            }
        }

        private void txt_correo_KeyUp(object sender, KeyEventArgs e)
        {
            lEmailCorrecto.Visible = true;

            if (ComprobarFormatoEmail(txt_correo.Text))
            {
                lEmailCorrecto.Text = "Dirección valida";
                lEmailCorrecto.ForeColor = Color.Green;
            }
            else
            {
                lEmailCorrecto.Text = "Dirección Invalida";
                lEmailCorrecto.ForeColor = Color.Red;
            }
        }

        private void txt_fecha_KeyUp(object sender, KeyEventArgs e)
        {
            ValidaFecha.Visible = true;

            if (isValidDate(txt_fecha.Text))
            {
                ValidaFecha.Text = "Fecha Valida";
                ValidaFecha.ForeColor = Color.Green;
            }
            else
            {
                ValidaFecha.Text = "Fecha Invalida";
                ValidaFecha.ForeColor = Color.Red;
            }
        }

        private void txt_fecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //e.Handled = true;

                errorProvider1.SetError(txt_telefono, "Solo puede digitar numeros");

            }

        }

        #endregion Eventos

        private void estudiantesInactivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de abandonar esta ventana?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                EstudiantesInactivos inactivo = new EstudiantesInactivos();
                this.Hide();
                inactivo.Show();
            }
        }
    }
}