namespace SistemaEstudiante
{
    partial class Asistencia
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_curso = new System.Windows.Forms.Label();
            this.Dgv_Estudiante = new System.Windows.Forms.DataGridView();
            this.picture_ausente = new System.Windows.Forms.PictureBox();
            this.picture_presente = new System.Windows.Forms.PictureBox();
            this.picture_atras = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asistenciaPorCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asistenciaPorEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_asistencia = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_buscar_estudiante = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Estudiante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_ausente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_presente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_atras)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 39);
            this.button1.TabIndex = 52;
            this.button1.Text = "Generar Asistencia";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(60, 106);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(202, 29);
            this.comboBox1.TabIndex = 51;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(60, 268);
            this.txt_id.MaxLength = 9;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(202, 29);
            this.txt_id.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(56, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 21);
            this.label4.TabIndex = 49;
            this.label4.Text = "Cédula del estudiante:";
            // 
            // lbl_curso
            // 
            this.lbl_curso.AutoSize = true;
            this.lbl_curso.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_curso.ForeColor = System.Drawing.Color.White;
            this.lbl_curso.Location = new System.Drawing.Point(56, 75);
            this.lbl_curso.Name = "lbl_curso";
            this.lbl_curso.Size = new System.Drawing.Size(64, 21);
            this.lbl_curso.TabIndex = 48;
            this.lbl_curso.Text = "Cursos";
            // 
            // Dgv_Estudiante
            // 
            this.Dgv_Estudiante.AllowUserToAddRows = false;
            this.Dgv_Estudiante.AllowUserToDeleteRows = false;
            this.Dgv_Estudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Estudiante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dgv_Estudiante.Location = new System.Drawing.Point(55, 156);
            this.Dgv_Estudiante.Name = "Dgv_Estudiante";
            this.Dgv_Estudiante.ReadOnly = true;
            this.Dgv_Estudiante.RowHeadersVisible = false;
            this.Dgv_Estudiante.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Estudiante.ShowEditingIcon = false;
            this.Dgv_Estudiante.Size = new System.Drawing.Size(709, 262);
            this.Dgv_Estudiante.TabIndex = 47;
            this.Dgv_Estudiante.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Estudiante_CellContentClick);
            this.Dgv_Estudiante.DoubleClick += new System.EventHandler(this.Dgv_Estudiante_DoubleClick);
            // 
            // picture_ausente
            // 
            this.picture_ausente.BackColor = System.Drawing.Color.Transparent;
            this.picture_ausente.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.picture_ausente.Image = global::SistemaEstudiante.Properties.Resources.if_f_cross_256_282471;
            this.picture_ausente.Location = new System.Drawing.Point(165, 332);
            this.picture_ausente.Name = "picture_ausente";
            this.picture_ausente.Size = new System.Drawing.Size(63, 61);
            this.picture_ausente.TabIndex = 70;
            this.picture_ausente.TabStop = false;
            this.toolTip1.SetToolTip(this.picture_ausente, "Ausente");
            this.picture_ausente.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // picture_presente
            // 
            this.picture_presente.BackColor = System.Drawing.Color.Transparent;
            this.picture_presente.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.picture_presente.Image = global::SistemaEstudiante.Properties.Resources.if_f_check_256_282474;
            this.picture_presente.Location = new System.Drawing.Point(60, 332);
            this.picture_presente.Name = "picture_presente";
            this.picture_presente.Size = new System.Drawing.Size(63, 61);
            this.picture_presente.TabIndex = 69;
            this.picture_presente.TabStop = false;
            this.toolTip1.SetToolTip(this.picture_presente, "Presente");
            this.picture_presente.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // picture_atras
            // 
            this.picture_atras.BackColor = System.Drawing.Color.Transparent;
            this.picture_atras.Image = global::SistemaEstudiante.Properties.Resources.FontAwesome_f060_0__641;
            this.picture_atras.Location = new System.Drawing.Point(1248, 606);
            this.picture_atras.Name = "picture_atras";
            this.picture_atras.Size = new System.Drawing.Size(63, 61);
            this.picture_atras.TabIndex = 66;
            this.picture_atras.TabStop = false;
            this.picture_atras.Click += new System.EventHandler(this.button4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1354, 24);
            this.menuStrip1.TabIndex = 71;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asistenciaPorCursoToolStripMenuItem,
            this.asistenciaPorEstudianteToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.herramientasToolStripMenuItem.Text = "Ver";
            this.herramientasToolStripMenuItem.Click += new System.EventHandler(this.herramientasToolStripMenuItem_Click);
            // 
            // asistenciaPorCursoToolStripMenuItem
            // 
            this.asistenciaPorCursoToolStripMenuItem.Name = "asistenciaPorCursoToolStripMenuItem";
            this.asistenciaPorCursoToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.asistenciaPorCursoToolStripMenuItem.Text = "Asistencia por curso";
            this.asistenciaPorCursoToolStripMenuItem.Click += new System.EventHandler(this.asistenciaPorCursoToolStripMenuItem_Click);
            // 
            // asistenciaPorEstudianteToolStripMenuItem
            // 
            this.asistenciaPorEstudianteToolStripMenuItem.Name = "asistenciaPorEstudianteToolStripMenuItem";
            this.asistenciaPorEstudianteToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.asistenciaPorEstudianteToolStripMenuItem.Text = "Asistencia por estudiante";
            this.asistenciaPorEstudianteToolStripMenuItem.Click += new System.EventHandler(this.asistenciaPorEstudianteToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_asistencia);
            this.panel1.Controls.Add(this.lbl_curso);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.picture_presente);
            this.panel1.Controls.Add(this.picture_ausente);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_id);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(47, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 495);
            this.panel1.TabIndex = 81;
            // 
            // lbl_asistencia
            // 
            this.lbl_asistencia.AutoSize = true;
            this.lbl_asistencia.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_asistencia.ForeColor = System.Drawing.Color.White;
            this.lbl_asistencia.Location = new System.Drawing.Point(108, 15);
            this.lbl_asistencia.Name = "lbl_asistencia";
            this.lbl_asistencia.Size = new System.Drawing.Size(143, 36);
            this.lbl_asistencia.TabIndex = 0;
            this.lbl_asistencia.Text = "Asistencia";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lbl_buscar_estudiante);
            this.panel2.Controls.Add(this.txt_buscar);
            this.panel2.Controls.Add(this.Dgv_Estudiante);
            this.panel2.Location = new System.Drawing.Point(503, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(808, 493);
            this.panel2.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(280, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 36);
            this.label1.TabIndex = 59;
            this.label1.Text = "Lista de Estudiantes";
            // 
            // lbl_buscar_estudiante
            // 
            this.lbl_buscar_estudiante.AutoSize = true;
            this.lbl_buscar_estudiante.BackColor = System.Drawing.Color.Transparent;
            this.lbl_buscar_estudiante.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar_estudiante.ForeColor = System.Drawing.Color.White;
            this.lbl_buscar_estudiante.Location = new System.Drawing.Point(51, 75);
            this.lbl_buscar_estudiante.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbl_buscar_estudiante.Name = "lbl_buscar_estudiante";
            this.lbl_buscar_estudiante.Size = new System.Drawing.Size(145, 21);
            this.lbl_buscar_estudiante.TabIndex = 58;
            this.lbl_buscar_estudiante.Text = "Buscar estudiante:";
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(55, 106);
            this.txt_buscar.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.txt_buscar.Multiline = true;
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(289, 29);
            this.txt_buscar.TabIndex = 4;
            this.txt_buscar.TextChanged += new System.EventHandler(this.txt_buscar_TextChanged_1);
            this.txt_buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_buscar_KeyPress);
            // 
            // Asistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::SistemaEstudiante.Properties.Resources.Abstracto;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 689);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.picture_atras);
            this.Name = "Asistencia";
            this.Text = "Asistencia";
            this.Load += new System.EventHandler(this.Asistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Estudiante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_ausente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_presente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_atras)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_curso;
        private System.Windows.Forms.DataGridView Dgv_Estudiante;
        private System.Windows.Forms.PictureBox picture_atras;
        private System.Windows.Forms.PictureBox picture_presente;
        private System.Windows.Forms.PictureBox picture_ausente;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_asistencia;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_buscar_estudiante;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem asistenciaPorCursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asistenciaPorEstudianteToolStripMenuItem;
    }
}