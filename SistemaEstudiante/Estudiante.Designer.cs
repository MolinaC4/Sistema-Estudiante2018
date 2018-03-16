namespace SistemaEstudiante
{
    partial class Estudiante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_cedula = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_apellidos = new System.Windows.Forms.Label();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.lbl_correo = new System.Windows.Forms.Label();
            this.lbl_genero = new System.Windows.Forms.Label();
            this.lbl_edad = new System.Windows.Forms.Label();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.txt_cedula = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_primer_apellido1 = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.gb_genero = new System.Windows.Forms.GroupBox();
            this.rb_femenino = new System.Windows.Forms.RadioButton();
            this.rb_masculino = new System.Windows.Forms.RadioButton();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_segundo_apellido2 = new System.Windows.Forms.TextBox();
            this.btn_foto = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeEstudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudiantesInactivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verAyudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_fecha = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_tipo = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ptb_Inactiva = new System.Windows.Forms.PictureBox();
            this.picture_atras = new System.Windows.Forms.PictureBox();
            this.picture_guardar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cboDispositivos = new System.Windows.Forms.ComboBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ValidaFecha = new System.Windows.Forms.Label();
            this.lEmailCorrecto = new System.Windows.Forms.Label();
            this.btn_cargar = new System.Windows.Forms.Button();
            this.gb_genero.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Inactiva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_atras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_guardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_cedula
            // 
            this.lbl_cedula.AutoSize = true;
            this.lbl_cedula.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cedula.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cedula.ForeColor = System.Drawing.Color.White;
            this.lbl_cedula.Location = new System.Drawing.Point(223, 39);
            this.lbl_cedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cedula.Name = "lbl_cedula";
            this.lbl_cedula.Size = new System.Drawing.Size(68, 22);
            this.lbl_cedula.TabIndex = 1;
            this.lbl_cedula.Text = "Cédula";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombre.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.Color.White;
            this.lbl_nombre.Location = new System.Drawing.Point(421, 39);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(73, 22);
            this.lbl_nombre.TabIndex = 2;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_apellidos
            // 
            this.lbl_apellidos.AutoSize = true;
            this.lbl_apellidos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_apellidos.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellidos.ForeColor = System.Drawing.Color.White;
            this.lbl_apellidos.Location = new System.Drawing.Point(617, 39);
            this.lbl_apellidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_apellidos.Name = "lbl_apellidos";
            this.lbl_apellidos.Size = new System.Drawing.Size(138, 22);
            this.lbl_apellidos.TabIndex = 8;
            this.lbl_apellidos.Text = "Primer Apellido";
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_direccion.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direccion.ForeColor = System.Drawing.Color.White;
            this.lbl_direccion.Location = new System.Drawing.Point(421, 191);
            this.lbl_direccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(86, 22);
            this.lbl_direccion.TabIndex = 9;
            this.lbl_direccion.Text = "Dirección";
            // 
            // lbl_correo
            // 
            this.lbl_correo.AutoSize = true;
            this.lbl_correo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_correo.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_correo.ForeColor = System.Drawing.Color.White;
            this.lbl_correo.Location = new System.Drawing.Point(617, 107);
            this.lbl_correo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_correo.Name = "lbl_correo";
            this.lbl_correo.Size = new System.Drawing.Size(153, 22);
            this.lbl_correo.TabIndex = 10;
            this.lbl_correo.Text = "Correo electronico";
            // 
            // lbl_genero
            // 
            this.lbl_genero.AutoSize = true;
            this.lbl_genero.BackColor = System.Drawing.Color.Transparent;
            this.lbl_genero.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_genero.ForeColor = System.Drawing.Color.White;
            this.lbl_genero.Location = new System.Drawing.Point(224, 191);
            this.lbl_genero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_genero.Name = "lbl_genero";
            this.lbl_genero.Size = new System.Drawing.Size(67, 22);
            this.lbl_genero.TabIndex = 11;
            this.lbl_genero.Text = "Genero";
            // 
            // lbl_edad
            // 
            this.lbl_edad.AutoSize = true;
            this.lbl_edad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_edad.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_edad.ForeColor = System.Drawing.Color.White;
            this.lbl_edad.Location = new System.Drawing.Point(223, 110);
            this.lbl_edad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_edad.Name = "lbl_edad";
            this.lbl_edad.Size = new System.Drawing.Size(182, 22);
            this.lbl_edad.TabIndex = 12;
            this.lbl_edad.Text = "Fecha De Nacimiento";
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_regresar.Location = new System.Drawing.Point(1531, 1110);
            this.btn_regresar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(124, 55);
            this.btn_regresar.TabIndex = 28;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = false;
            // 
            // txt_cedula
            // 
            this.txt_cedula.Location = new System.Drawing.Point(227, 67);
            this.txt_cedula.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txt_cedula.MaxLength = 9;
            this.txt_cedula.Name = "txt_cedula";
            this.txt_cedula.Size = new System.Drawing.Size(176, 29);
            this.txt_cedula.TabIndex = 0;
            this.txt_cedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cedula_KeyPress);
            // 
            // txt_nombre
            // 
            this.txt_nombre.AccessibleDescription = "";
            this.txt_nombre.AccessibleName = "";
            this.txt_nombre.Location = new System.Drawing.Point(425, 67);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(176, 29);
            this.txt_nombre.TabIndex = 1;
            this.txt_nombre.Tag = "";
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // txt_primer_apellido1
            // 
            this.txt_primer_apellido1.Location = new System.Drawing.Point(621, 67);
            this.txt_primer_apellido1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txt_primer_apellido1.Name = "txt_primer_apellido1";
            this.txt_primer_apellido1.Size = new System.Drawing.Size(176, 29);
            this.txt_primer_apellido1.TabIndex = 2;
            this.txt_primer_apellido1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_primer_apellido1_KeyPress);
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(425, 225);
            this.txt_direccion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txt_direccion.MaxLength = 512;
            this.txt_direccion.Multiline = true;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(241, 64);
            this.txt_direccion.TabIndex = 8;
            this.txt_direccion.WordWrap = false;
            this.txt_direccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.siguiente_KeyPress);
            // 
            // gb_genero
            // 
            this.gb_genero.BackColor = System.Drawing.Color.Transparent;
            this.gb_genero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gb_genero.Controls.Add(this.rb_femenino);
            this.gb_genero.Controls.Add(this.rb_masculino);
            this.gb_genero.Location = new System.Drawing.Point(227, 216);
            this.gb_genero.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.gb_genero.Name = "gb_genero";
            this.gb_genero.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.gb_genero.Size = new System.Drawing.Size(176, 73);
            this.gb_genero.TabIndex = 9;
            this.gb_genero.TabStop = false;
            // 
            // rb_femenino
            // 
            this.rb_femenino.AutoSize = true;
            this.rb_femenino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_femenino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_femenino.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rb_femenino.Location = new System.Drawing.Point(17, 48);
            this.rb_femenino.Name = "rb_femenino";
            this.rb_femenino.Size = new System.Drawing.Size(86, 20);
            this.rb_femenino.TabIndex = 5;
            this.rb_femenino.TabStop = true;
            this.rb_femenino.Text = "Femenino";
            this.rb_femenino.UseVisualStyleBackColor = true;
            // 
            // rb_masculino
            // 
            this.rb_masculino.AutoSize = true;
            this.rb_masculino.BackColor = System.Drawing.Color.Transparent;
            this.rb_masculino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_masculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_masculino.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rb_masculino.Location = new System.Drawing.Point(16, 19);
            this.rb_masculino.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.rb_masculino.Name = "rb_masculino";
            this.rb_masculino.Size = new System.Drawing.Size(87, 20);
            this.rb_masculino.TabIndex = 4;
            this.rb_masculino.Text = "Masculino";
            this.rb_masculino.UseVisualStyleBackColor = false;
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(621, 135);
            this.txt_correo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(175, 29);
            this.txt_correo.TabIndex = 6;
            this.txt_correo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.siguiente_KeyPress);
            this.txt_correo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_correo_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(421, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 22);
            this.label1.TabIndex = 41;
            this.label1.Text = "Teléfono";
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_salir.Location = new System.Drawing.Point(1717, 1110);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(124, 55);
            this.btn_salir.TabIndex = 44;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(819, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 22);
            this.label2.TabIndex = 45;
            this.label2.Text = "Segundo Apellido";
            // 
            // txt_segundo_apellido2
            // 
            this.txt_segundo_apellido2.Location = new System.Drawing.Point(820, 67);
            this.txt_segundo_apellido2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txt_segundo_apellido2.Name = "txt_segundo_apellido2";
            this.txt_segundo_apellido2.Size = new System.Drawing.Size(176, 29);
            this.txt_segundo_apellido2.TabIndex = 3;
            this.txt_segundo_apellido2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_segundo_apellido2_KeyPress);
            // 
            // btn_foto
            // 
            this.btn_foto.Location = new System.Drawing.Point(1474, 339);
            this.btn_foto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_foto.Name = "btn_foto";
            this.btn_foto.Size = new System.Drawing.Size(124, 69);
            this.btn_foto.TabIndex = 48;
            this.btn_foto.Text = "FOTO";
            this.btn_foto.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1003, 24);
            this.menuStrip1.TabIndex = 51;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoEstudianteToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // nuevoEstudianteToolStripMenuItem
            // 
            this.nuevoEstudianteToolStripMenuItem.Name = "nuevoEstudianteToolStripMenuItem";
            this.nuevoEstudianteToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.nuevoEstudianteToolStripMenuItem.Text = "Nuevo Estudiante";
            this.nuevoEstudianteToolStripMenuItem.Click += new System.EventHandler(this.nuevoEstudianteToolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeEstudiantesToolStripMenuItem,
            this.estudiantesInactivosToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.herramientasToolStripMenuItem.Text = "Ver";
            // 
            // listaDeEstudiantesToolStripMenuItem
            // 
            this.listaDeEstudiantesToolStripMenuItem.Name = "listaDeEstudiantesToolStripMenuItem";
            this.listaDeEstudiantesToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.listaDeEstudiantesToolStripMenuItem.Text = "Lista de estudiantes activos";
            this.listaDeEstudiantesToolStripMenuItem.Click += new System.EventHandler(this.listaDeEstudiantesToolStripMenuItem_Click);
            // 
            // estudiantesInactivosToolStripMenuItem
            // 
            this.estudiantesInactivosToolStripMenuItem.Name = "estudiantesInactivosToolStripMenuItem";
            this.estudiantesInactivosToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.estudiantesInactivosToolStripMenuItem.Text = "Estudiantes inactivos";
            this.estudiantesInactivosToolStripMenuItem.Click += new System.EventHandler(this.estudiantesInactivosToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verAyudaToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // verAyudaToolStripMenuItem
            // 
            this.verAyudaToolStripMenuItem.Name = "verAyudaToolStripMenuItem";
            this.verAyudaToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.verAyudaToolStripMenuItem.Text = "Ver Ayuda";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(227, 135);
            this.txt_fecha.Mask = "00/00/0000";
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(176, 29);
            this.txt_fecha.TabIndex = 4;
            this.txt_fecha.ValidatingType = typeof(System.DateTime);
            this.txt_fecha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_fecha_KeyPress);
            this.txt_fecha.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_fecha_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(816, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 22);
            this.label3.TabIndex = 53;
            this.label3.Text = "Tipo de estudiante";
            // 
            // cbx_tipo
            // 
            this.cbx_tipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_tipo.FormattingEnabled = true;
            this.cbx_tipo.Items.AddRange(new object[] {
            "Bachiller Por Madurez",
            "Por Centros",
            "Regular(Colegio)"});
            this.cbx_tipo.Location = new System.Drawing.Point(820, 135);
            this.cbx_tipo.Name = "cbx_tipo";
            this.cbx_tipo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbx_tipo.Size = new System.Drawing.Size(176, 29);
            this.cbx_tipo.Sorted = true;
            this.cbx_tipo.TabIndex = 7;
            this.cbx_tipo.ValueMemberChanged += new System.EventHandler(this.cbx_tipo_ValueMemberChanged);
            this.cbx_tipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.siguiente_KeyPress);
            // 
            // ptb_Inactiva
            // 
            this.ptb_Inactiva.BackColor = System.Drawing.Color.Transparent;
            this.ptb_Inactiva.BackgroundImage = global::SistemaEstudiante.Properties.Resources.if_edit_delete_118920;
            this.ptb_Inactiva.InitialImage = global::SistemaEstudiante.Properties.Resources.if_edit_delete_118920;
            this.ptb_Inactiva.Location = new System.Drawing.Point(823, 225);
            this.ptb_Inactiva.Name = "ptb_Inactiva";
            this.ptb_Inactiva.Size = new System.Drawing.Size(64, 63);
            this.ptb_Inactiva.TabIndex = 71;
            this.ptb_Inactiva.TabStop = false;
            this.toolTip1.SetToolTip(this.ptb_Inactiva, "Inctivar");
            this.ptb_Inactiva.Click += new System.EventHandler(this.ptb_Inactiva_Click);
            // 
            // picture_atras
            // 
            this.picture_atras.BackColor = System.Drawing.Color.Transparent;
            this.picture_atras.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.picture_atras.Image = global::SistemaEstudiante.Properties.Resources.FontAwesome_f060_0__641;
            this.picture_atras.Location = new System.Drawing.Point(928, 225);
            this.picture_atras.Name = "picture_atras";
            this.picture_atras.Size = new System.Drawing.Size(63, 61);
            this.picture_atras.TabIndex = 68;
            this.picture_atras.TabStop = false;
            this.toolTip1.SetToolTip(this.picture_atras, "Atrás");
            this.picture_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // picture_guardar
            // 
            this.picture_guardar.BackColor = System.Drawing.Color.Transparent;
            this.picture_guardar.Image = global::SistemaEstudiante.Properties.Resources.if_floppy_disk_save_103863;
            this.picture_guardar.Location = new System.Drawing.Point(718, 225);
            this.picture_guardar.Name = "picture_guardar";
            this.picture_guardar.Size = new System.Drawing.Size(64, 64);
            this.picture_guardar.TabIndex = 67;
            this.picture_guardar.TabStop = false;
            this.toolTip1.SetToolTip(this.picture_guardar, "Guardar");
            this.picture_guardar.Click += new System.EventHandler(this.btn_insertar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox2.BackgroundImage = global::SistemaEstudiante.Properties.Resources.if_Add_Male_User_49576__1_;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(27, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(167, 155);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Agregar foto");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // cboDispositivos
            // 
            this.cboDispositivos.FormattingEnabled = true;
            this.cboDispositivos.Location = new System.Drawing.Point(27, 216);
            this.cboDispositivos.Name = "cboDispositivos";
            this.cboDispositivos.Size = new System.Drawing.Size(167, 29);
            this.cboDispositivos.TabIndex = 69;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(27, 259);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(167, 30);
            this.btnIniciar.TabIndex = 70;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(425, 135);
            this.txt_telefono.MaxLength = 8;
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(180, 29);
            this.txt_telefono.TabIndex = 5;
            this.txt_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefono_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1391, 36);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 273);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // ValidaFecha
            // 
            this.ValidaFecha.AutoSize = true;
            this.ValidaFecha.BackColor = System.Drawing.Color.Transparent;
            this.ValidaFecha.Location = new System.Drawing.Point(239, 167);
            this.ValidaFecha.Name = "ValidaFecha";
            this.ValidaFecha.Size = new System.Drawing.Size(0, 21);
            this.ValidaFecha.TabIndex = 73;
            // 
            // lEmailCorrecto
            // 
            this.lEmailCorrecto.AutoSize = true;
            this.lEmailCorrecto.BackColor = System.Drawing.Color.Transparent;
            this.lEmailCorrecto.Location = new System.Drawing.Point(633, 167);
            this.lEmailCorrecto.Name = "lEmailCorrecto";
            this.lEmailCorrecto.Size = new System.Drawing.Size(0, 21);
            this.lEmailCorrecto.TabIndex = 75;
            // 
            // btn_cargar
            // 
            this.btn_cargar.Location = new System.Drawing.Point(311, 35);
            this.btn_cargar.Name = "btn_cargar";
            this.btn_cargar.Size = new System.Drawing.Size(69, 29);
            this.btn_cargar.TabIndex = 76;
            this.btn_cargar.Text = "Cargar";
            this.btn_cargar.UseVisualStyleBackColor = true;
            this.btn_cargar.Click += new System.EventHandler(this.btn_cargar_Click);
            // 
            // Estudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImage = global::SistemaEstudiante.Properties.Resources.Abstracto;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1003, 329);
            this.Controls.Add(this.lbl_genero);
            this.Controls.Add(this.btn_cargar);
            this.Controls.Add(this.lEmailCorrecto);
            this.Controls.Add(this.ValidaFecha);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.ptb_Inactiva);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.cboDispositivos);
            this.Controls.Add(this.picture_atras);
            this.Controls.Add(this.picture_guardar);
            this.Controls.Add(this.cbx_tipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_foto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_segundo_apellido2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.gb_genero);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.txt_primer_apellido1);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_cedula);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.lbl_edad);
            this.Controls.Add(this.lbl_correo);
            this.Controls.Add(this.lbl_direccion);
            this.Controls.Add(this.lbl_apellidos);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_cedula);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Estudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CREAR ESTUDIANTES";
            this.Load += new System.EventHandler(this.Estudiante_Load);
            this.gb_genero.ResumeLayout(false);
            this.gb_genero.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Inactiva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_atras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_guardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cedula;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_apellidos;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.Label lbl_correo;
        private System.Windows.Forms.Label lbl_genero;
        private System.Windows.Forms.Label lbl_edad;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.TextBox txt_cedula;
        private System.Windows.Forms.TextBox txt_primer_apellido1;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.GroupBox gb_genero;
        private System.Windows.Forms.RadioButton rb_masculino;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_segundo_apellido2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_foto;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton rb_femenino;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verAyudaToolStripMenuItem;
        private System.Windows.Forms.MaskedTextBox txt_fecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_tipo;
        private System.Windows.Forms.PictureBox picture_guardar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox picture_atras;
        private System.Windows.Forms.ComboBox cboDispositivos;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.PictureBox ptb_Inactiva;
        private System.Windows.Forms.TextBox txt_telefono;
        protected System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripMenuItem listaDeEstudiantesToolStripMenuItem;
        private System.Windows.Forms.Label lEmailCorrecto;
        private System.Windows.Forms.Label ValidaFecha;
        private System.Windows.Forms.Button btn_cargar;
        protected System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.ToolStripMenuItem estudiantesInactivosToolStripMenuItem;
    }
}