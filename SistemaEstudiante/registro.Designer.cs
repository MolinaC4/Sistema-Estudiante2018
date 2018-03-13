namespace SistemaEstudiante
{
    partial class registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registro));
            this.label4 = new System.Windows.Forms.Label();
            this.gb_genero = new System.Windows.Forms.GroupBox();
            this.rb_admi = new System.Windows.Forms.RadioButton();
            this.rb_invitado = new System.Windows.Forms.RadioButton();
            this.txt_confirmacion = new System.Windows.Forms.TextBox();
            this.txt_contrasenna = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.picture_atras = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verAyudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_respuestaS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_opcion = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ch_contrasenna = new System.Windows.Forms.CheckBox();
            this.gb_genero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_atras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(22, 307);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 23);
            this.label4.TabIndex = 48;
            this.label4.Text = "Tipo de usuario:";
            // 
            // gb_genero
            // 
            this.gb_genero.BackColor = System.Drawing.Color.Transparent;
            this.gb_genero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gb_genero.Controls.Add(this.rb_admi);
            this.gb_genero.Controls.Add(this.rb_invitado);
            this.gb_genero.Location = new System.Drawing.Point(225, 307);
            this.gb_genero.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.gb_genero.Name = "gb_genero";
            this.gb_genero.Padding = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.gb_genero.Size = new System.Drawing.Size(252, 69);
            this.gb_genero.TabIndex = 47;
            this.gb_genero.TabStop = false;
            // 
            // rb_admi
            // 
            this.rb_admi.AutoSize = true;
            this.rb_admi.BackColor = System.Drawing.Color.Transparent;
            this.rb_admi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_admi.Enabled = false;
            this.rb_admi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_admi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rb_admi.Location = new System.Drawing.Point(12, 28);
            this.rb_admi.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.rb_admi.Name = "rb_admi";
            this.rb_admi.Size = new System.Drawing.Size(120, 23);
            this.rb_admi.TabIndex = 3;
            this.rb_admi.Text = "Administrador";
            this.rb_admi.UseVisualStyleBackColor = false;
            this.rb_admi.CheckedChanged += new System.EventHandler(this.rb_masculino_CheckedChanged);
            this.rb_admi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rb_masculino_KeyPress);
            // 
            // rb_invitado
            // 
            this.rb_invitado.AutoSize = true;
            this.rb_invitado.BackColor = System.Drawing.Color.Transparent;
            this.rb_invitado.Checked = true;
            this.rb_invitado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_invitado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_invitado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rb_invitado.Location = new System.Drawing.Point(159, 28);
            this.rb_invitado.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.rb_invitado.Name = "rb_invitado";
            this.rb_invitado.Size = new System.Drawing.Size(81, 23);
            this.rb_invitado.TabIndex = 69;
            this.rb_invitado.TabStop = true;
            this.rb_invitado.Text = "Invitado";
            this.rb_invitado.UseVisualStyleBackColor = false;
            this.rb_invitado.CheckedChanged += new System.EventHandler(this.rb_invitado_CheckedChanged);
            // 
            // txt_confirmacion
            // 
            this.txt_confirmacion.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confirmacion.Location = new System.Drawing.Point(223, 159);
            this.txt_confirmacion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_confirmacion.MaxLength = 10;
            this.txt_confirmacion.Name = "txt_confirmacion";
            this.txt_confirmacion.Size = new System.Drawing.Size(252, 29);
            this.txt_confirmacion.TabIndex = 42;
            this.txt_confirmacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_confirmacion_KeyPress);
            this.txt_confirmacion.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_confirmacion_KeyUp);
            // 
            // txt_contrasenna
            // 
            this.txt_contrasenna.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contrasenna.Location = new System.Drawing.Point(223, 116);
            this.txt_contrasenna.Margin = new System.Windows.Forms.Padding(4);
            this.txt_contrasenna.MaxLength = 8;
            this.txt_contrasenna.Name = "txt_contrasenna";
            this.txt_contrasenna.Size = new System.Drawing.Size(252, 29);
            this.txt_contrasenna.TabIndex = 41;
            this.txt_contrasenna.TextChanged += new System.EventHandler(this.ch_contrasenna_CheckedChanged);
            this.txt_contrasenna.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_contrasenna_KeyPress);
            this.txt_contrasenna.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_contrasenna_KeyUp);
            // 
            // txt_usuario
            // 
            this.txt_usuario.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.Location = new System.Drawing.Point(225, 70);
            this.txt_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_usuario.MaxLength = 20;
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(252, 29);
            this.txt_usuario.TabIndex = 40;
            this.txt_usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_usuario_KeyPress);
            // 
            // toolTip1
            // 
            this.toolTip1.Tag = "Hola";
            // 
            // picture_atras
            // 
            this.picture_atras.BackColor = System.Drawing.Color.Transparent;
            this.picture_atras.Image = global::SistemaEstudiante.Properties.Resources.FontAwesome_f060_0__641;
            this.picture_atras.Location = new System.Drawing.Point(721, 440);
            this.picture_atras.Name = "picture_atras";
            this.picture_atras.Size = new System.Drawing.Size(63, 61);
            this.picture_atras.TabIndex = 67;
            this.picture_atras.TabStop = false;
            this.toolTip1.SetToolTip(this.picture_atras, "Atrás");
            this.picture_atras.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SistemaEstudiante.Properties.Resources.if_f_check_256_2824741;
            this.pictureBox1.Location = new System.Drawing.Point(623, 440);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 61);
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Registrar Usuario");
            this.pictureBox1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(8, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 23);
            this.label3.TabIndex = 66;
            this.label3.Text = "Confirmar contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(8, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 65;
            this.label2.Text = "Contraseña:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(8, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 23);
            this.label5.TabIndex = 64;
            this.label5.Text = "Nombre de usuario:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(854, 24);
            this.menuStrip1.TabIndex = 68;
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
            this.nuevoEstudianteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuevoEstudianteToolStripMenuItem.Text = "Nuevo Usuario";
            this.nuevoEstudianteToolStripMenuItem.Click += new System.EventHandler(this.nuevoEstudianteToolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.ch_contrasenna);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_respuestaS);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbx_opcion);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_usuario);
            this.panel1.Controls.Add(this.txt_contrasenna);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.gb_genero);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_confirmacion);
            this.panel1.Location = new System.Drawing.Point(74, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 390);
            this.panel1.TabIndex = 82;
            // 
            // txt_respuestaS
            // 
            this.txt_respuestaS.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_respuestaS.Location = new System.Drawing.Point(223, 259);
            this.txt_respuestaS.Margin = new System.Windows.Forms.Padding(4);
            this.txt_respuestaS.MaxLength = 10;
            this.txt_respuestaS.Multiline = true;
            this.txt_respuestaS.Name = "txt_respuestaS";
            this.txt_respuestaS.Size = new System.Drawing.Size(250, 29);
            this.txt_respuestaS.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(8, 235);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 23);
            this.label1.TabIndex = 73;
            this.label1.Text = "Pregunta de Seguridad";
            // 
            // cbx_opcion
            // 
            this.cbx_opcion.FormattingEnabled = true;
            this.cbx_opcion.Items.AddRange(new object[] {
            "Nombre de un familiar",
            "Nombre de su mascota",
            "Color favorito",
            "Comida favorita"});
            this.cbx_opcion.Location = new System.Drawing.Point(12, 261);
            this.cbx_opcion.Name = "cbx_opcion";
            this.cbx_opcion.Size = new System.Drawing.Size(188, 27);
            this.cbx_opcion.TabIndex = 71;
            this.cbx_opcion.SelectedIndexChanged += new System.EventHandler(this.cbx_opcion_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(165, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 36);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nuevo Usuario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(482, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 19);
            this.label7.TabIndex = 83;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(482, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 19);
            this.label8.TabIndex = 84;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            // 
            // ch_contrasenna
            // 
            this.ch_contrasenna.AutoSize = true;
            this.ch_contrasenna.BackColor = System.Drawing.Color.Transparent;
            this.ch_contrasenna.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ch_contrasenna.Location = new System.Drawing.Point(398, 195);
            this.ch_contrasenna.Name = "ch_contrasenna";
            this.ch_contrasenna.Size = new System.Drawing.Size(77, 23);
            this.ch_contrasenna.TabIndex = 85;
            this.ch_contrasenna.Text = "Mostrar";
            this.ch_contrasenna.UseVisualStyleBackColor = true;
            this.ch_contrasenna.CheckedChanged += new System.EventHandler(this.ch_contrasenna_CheckedChanged);
            // 
            // registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaEstudiante.Properties.Resources.Abstracto;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 513);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.picture_atras);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRO DE USUARIOS";
            this.Load += new System.EventHandler(this.registro_Load);
            this.gb_genero.ResumeLayout(false);
            this.gb_genero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_atras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gb_genero;
        private System.Windows.Forms.RadioButton rb_admi;
        private System.Windows.Forms.TextBox txt_confirmacion;
        private System.Windows.Forms.TextBox txt_contrasenna;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picture_atras;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verAyudaToolStripMenuItem;
        private System.Windows.Forms.RadioButton rb_invitado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_respuestaS;
        private System.Windows.Forms.ComboBox cbx_opcion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox ch_contrasenna;
    }
}