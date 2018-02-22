namespace SistemaEstudiante
{
    partial class Matriculas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_curso = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_curso_matricula = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaMatriculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picture_atras = new System.Windows.Forms.PictureBox();
            this.picture_eliminar = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.picture_matricular = new System.Windows.Forms.PictureBox();
            this.dgv_estudiante = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_curso)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_atras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_eliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_matricular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estudiante)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(502, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estudiantes matriculados";
            // 
            // dgv_curso
            // 
            this.dgv_curso.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgv_curso.AllowUserToAddRows = false;
            this.dgv_curso.AllowUserToDeleteRows = false;
            this.dgv_curso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_curso.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_curso.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dgv_curso.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_curso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgv_curso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_curso.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_curso.DefaultCellStyle = dataGridViewCellStyle22;
            this.dgv_curso.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_curso.Location = new System.Drawing.Point(421, 413);
            this.dgv_curso.Name = "dgv_curso";
            this.dgv_curso.ReadOnly = true;
            this.dgv_curso.RowHeadersVisible = false;
            this.dgv_curso.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_curso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_curso.Size = new System.Drawing.Size(771, 242);
            this.dgv_curso.TabIndex = 1;
            this.dgv_curso.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_curso_CellContentClick);
            this.dgv_curso.DoubleClick += new System.EventHandler(this.dgv_curso_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(487, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 31);
            this.label2.TabIndex = 33;
            this.label2.Text = "Estudiantes registrados";
            // 
            // lbl_curso_matricula
            // 
            this.lbl_curso_matricula.AutoSize = true;
            this.lbl_curso_matricula.BackColor = System.Drawing.Color.Transparent;
            this.lbl_curso_matricula.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_curso_matricula.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_curso_matricula.Location = new System.Drawing.Point(29, 71);
            this.lbl_curso_matricula.Name = "lbl_curso_matricula";
            this.lbl_curso_matricula.Size = new System.Drawing.Size(151, 21);
            this.lbl_curso_matricula.TabIndex = 34;
            this.lbl_curso_matricula.Text = "Curso a matricular:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(31, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 21);
            this.label4.TabIndex = 35;
            this.label4.Text = "Cédula del estudiante:";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(33, 213);
            this.txt_id.MaxLength = 9;
            this.txt_id.Multiline = true;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(226, 29);
            this.txt_id.TabIndex = 36;
            this.txt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(33, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(226, 29);
            this.comboBox1.TabIndex = 37;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(508, 64);
            this.txt_buscar.Multiline = true;
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(226, 29);
            this.txt_buscar.TabIndex = 40;
            this.txt_buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_buscar_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(417, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 21);
            this.label5.TabIndex = 41;
            this.label5.Text = "Buscar:";
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
            this.menuStrip1.TabIndex = 43;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaMatriculaToolStripMenuItem,
            this.cerrarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // nuevaMatriculaToolStripMenuItem
            // 
            this.nuevaMatriculaToolStripMenuItem.Name = "nuevaMatriculaToolStripMenuItem";
            this.nuevaMatriculaToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.nuevaMatriculaToolStripMenuItem.Text = "Nueva Matricula";
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
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
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // picture_atras
            // 
            this.picture_atras.BackColor = System.Drawing.Color.Transparent;
            this.picture_atras.Image = global::SistemaEstudiante.Properties.Resources.FontAwesome_f060_0__641;
            this.picture_atras.Location = new System.Drawing.Point(1256, 650);
            this.picture_atras.Name = "picture_atras";
            this.picture_atras.Size = new System.Drawing.Size(63, 61);
            this.picture_atras.TabIndex = 65;
            this.picture_atras.TabStop = false;
            this.toolTip1.SetToolTip(this.picture_atras, "Atrás");
            this.picture_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // picture_eliminar
            // 
            this.picture_eliminar.BackColor = System.Drawing.Color.Transparent;
            this.picture_eliminar.Image = global::SistemaEstudiante.Properties.Resources.if_edit_delete_118920;
            this.picture_eliminar.Location = new System.Drawing.Point(195, 277);
            this.picture_eliminar.Name = "picture_eliminar";
            this.picture_eliminar.Size = new System.Drawing.Size(64, 64);
            this.picture_eliminar.TabIndex = 66;
            this.picture_eliminar.TabStop = false;
            this.toolTip1.SetToolTip(this.picture_eliminar, "Eliminar Matricula");
            // 
            // picture_matricular
            // 
            this.picture_matricular.BackColor = System.Drawing.Color.Transparent;
            this.picture_matricular.Image = global::SistemaEstudiante.Properties.Resources.if_compose_1055085;
            this.picture_matricular.Location = new System.Drawing.Point(33, 277);
            this.picture_matricular.Name = "picture_matricular";
            this.picture_matricular.Size = new System.Drawing.Size(64, 64);
            this.picture_matricular.TabIndex = 68;
            this.picture_matricular.TabStop = false;
            this.toolTip1.SetToolTip(this.picture_matricular, "Matricular");
            this.picture_matricular.Click += new System.EventHandler(this.btn_matricula_Click);
            // 
            // dgv_estudiante
            // 
            this.dgv_estudiante.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_estudiante.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_estudiante.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dgv_estudiante.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_estudiante.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dgv_estudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_estudiante.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_estudiante.DefaultCellStyle = dataGridViewCellStyle24;
            this.dgv_estudiante.Location = new System.Drawing.Point(421, 113);
            this.dgv_estudiante.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dgv_estudiante.Name = "dgv_estudiante";
            this.dgv_estudiante.ReadOnly = true;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_estudiante.RowHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dgv_estudiante.RowHeadersVisible = false;
            this.dgv_estudiante.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_estudiante.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_estudiante.Size = new System.Drawing.Size(771, 242);
            this.dgv_estudiante.TabIndex = 69;
            this.dgv_estudiante.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_estudiante_CellContentClick);
            this.dgv_estudiante.DoubleClick += new System.EventHandler(this.dgv_estudiante_DoubleClick);
            // 
            // Matriculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaEstudiante.Properties.Resources.Abstracto;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 720);
            this.Controls.Add(this.dgv_estudiante);
            this.Controls.Add(this.picture_matricular);
            this.Controls.Add(this.picture_eliminar);
            this.Controls.Add(this.picture_atras);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_curso_matricula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_curso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Matriculas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matrícula";
            this.Load += new System.EventHandler(this.Matriculas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_curso)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_atras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_eliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_matricular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estudiante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_curso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_curso_matricula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaMatriculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.PictureBox picture_atras;
        private System.Windows.Forms.PictureBox picture_eliminar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox picture_matricular;
        private System.Windows.Forms.DataGridView dgv_estudiante;
    }
}