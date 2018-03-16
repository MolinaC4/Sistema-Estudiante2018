namespace SistemaEstudiante
{
    partial class Curso
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosEliminadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verAyudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.picture_atras = new System.Windows.Forms.PictureBox();
            this.picture_eliminar = new System.Windows.Forms.PictureBox();
            this.picture_guardar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dgv_curso = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id_curso = new System.Windows.Forms.TextBox();
            this.txt_curso = new System.Windows.Forms.TextBox();
            this.lbl_nombre_curso = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_atras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_eliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_guardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_curso)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1190, 25);
            this.menuStrip1.TabIndex = 63;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoEstudianteToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 19);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // nuevoEstudianteToolStripMenuItem
            // 
            this.nuevoEstudianteToolStripMenuItem.Name = "nuevoEstudianteToolStripMenuItem";
            this.nuevoEstudianteToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.nuevoEstudianteToolStripMenuItem.Text = "Nuevo Curso";
            this.nuevoEstudianteToolStripMenuItem.Click += new System.EventHandler(this.nuevoEstudianteToolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
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
            this.cursosEliminadosToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(35, 19);
            this.herramientasToolStripMenuItem.Text = "Ver";
            // 
            // cursosEliminadosToolStripMenuItem
            // 
            this.cursosEliminadosToolStripMenuItem.Name = "cursosEliminadosToolStripMenuItem";
            this.cursosEliminadosToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.cursosEliminadosToolStripMenuItem.Text = "Cursos Eliminados";
            this.cursosEliminadosToolStripMenuItem.Click += new System.EventHandler(this.cursosEliminadosToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verAyudaToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 19);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // verAyudaToolStripMenuItem
            // 
            this.verAyudaToolStripMenuItem.Name = "verAyudaToolStripMenuItem";
            this.verAyudaToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.verAyudaToolStripMenuItem.Text = "Ver Ayuda";
            // 
            // picture_atras
            // 
            this.picture_atras.BackColor = System.Drawing.Color.Transparent;
            this.picture_atras.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.picture_atras.Image = global::SistemaEstudiante.Properties.Resources.FontAwesome_f060_0__641;
            this.picture_atras.Location = new System.Drawing.Point(1368, 646);
            this.picture_atras.Margin = new System.Windows.Forms.Padding(5);
            this.picture_atras.Name = "picture_atras";
            this.picture_atras.Size = new System.Drawing.Size(105, 99);
            this.picture_atras.TabIndex = 64;
            this.picture_atras.TabStop = false;
            this.toolTip1.SetToolTip(this.picture_atras, "Atrás");
            this.picture_atras.BackgroundImageChanged += new System.EventHandler(this.picture_atras_BackgroundImageChanged);
            this.picture_atras.Click += new System.EventHandler(this.picture_atras_Click);
            // 
            // picture_eliminar
            // 
            this.picture_eliminar.BackColor = System.Drawing.Color.Transparent;
            this.picture_eliminar.Image = global::SistemaEstudiante.Properties.Resources.if_edit_delete_1189201;
            this.picture_eliminar.Location = new System.Drawing.Point(165, 266);
            this.picture_eliminar.Margin = new System.Windows.Forms.Padding(5);
            this.picture_eliminar.Name = "picture_eliminar";
            this.picture_eliminar.Size = new System.Drawing.Size(63, 60);
            this.picture_eliminar.TabIndex = 77;
            this.picture_eliminar.TabStop = false;
            this.toolTip1.SetToolTip(this.picture_eliminar, "Eliminar");
            this.picture_eliminar.Click += new System.EventHandler(this.Inactivar_Click);
            // 
            // picture_guardar
            // 
            this.picture_guardar.BackColor = System.Drawing.Color.Transparent;
            this.picture_guardar.Image = global::SistemaEstudiante.Properties.Resources.if_floppy_disk_save_1038631;
            this.picture_guardar.Location = new System.Drawing.Point(65, 266);
            this.picture_guardar.Margin = new System.Windows.Forms.Padding(5);
            this.picture_guardar.Name = "picture_guardar";
            this.picture_guardar.Size = new System.Drawing.Size(60, 60);
            this.picture_guardar.TabIndex = 78;
            this.picture_guardar.TabStop = false;
            this.toolTip1.SetToolTip(this.picture_guardar, "Guardar");
            this.picture_guardar.Click += new System.EventHandler(this.btn_insertar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::SistemaEstudiante.Properties.Resources.FontAwesome_f060_0__64;
            this.pictureBox2.Location = new System.Drawing.Point(975, 465);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 60);
            this.pictureBox2.TabIndex = 76;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Atrás");
            this.pictureBox2.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // dgv_curso
            // 
            this.dgv_curso.AllowUserToAddRows = false;
            this.dgv_curso.AllowUserToDeleteRows = false;
            this.dgv_curso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_curso.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_curso.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dgv_curso.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_curso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_curso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_curso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_curso.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_curso.Location = new System.Drawing.Point(55, 147);
            this.dgv_curso.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.dgv_curso.MultiSelect = false;
            this.dgv_curso.Name = "dgv_curso";
            this.dgv_curso.ReadOnly = true;
            this.dgv_curso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_curso.RowHeadersVisible = false;
            this.dgv_curso.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_curso.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_curso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_curso.ShowEditingIcon = false;
            this.dgv_curso.Size = new System.Drawing.Size(396, 179);
            this.dgv_curso.TabIndex = 59;
            this.toolTip1.SetToolTip(this.dgv_curso, "Cursos");
            this.dgv_curso.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_curso_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(162, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 21);
            this.label1.TabIndex = 79;
            this.label1.Text = "Código del curso:";
            // 
            // txt_id_curso
            // 
            this.txt_id_curso.Location = new System.Drawing.Point(179, 452);
            this.txt_id_curso.Margin = new System.Windows.Forms.Padding(5);
            this.txt_id_curso.MaxLength = 6;
            this.txt_id_curso.Name = "txt_id_curso";
            this.txt_id_curso.Size = new System.Drawing.Size(289, 29);
            this.txt_id_curso.TabIndex = 1;
            this.txt_id_curso.Visible = false;
            this.txt_id_curso.TextChanged += new System.EventHandler(this.txt_id_curso_TextChanged);
            this.txt_id_curso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_curso_KeyPress);
            // 
            // txt_curso
            // 
            this.txt_curso.Location = new System.Drawing.Point(166, 249);
            this.txt_curso.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.txt_curso.Name = "txt_curso";
            this.txt_curso.Size = new System.Drawing.Size(289, 29);
            this.txt_curso.TabIndex = 2;
            this.txt_curso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_curso_KeyPress);
            // 
            // lbl_nombre_curso
            // 
            this.lbl_nombre_curso.AutoSize = true;
            this.lbl_nombre_curso.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombre_curso.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_curso.ForeColor = System.Drawing.Color.White;
            this.lbl_nombre_curso.Location = new System.Drawing.Point(162, 217);
            this.lbl_nombre_curso.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbl_nombre_curso.Name = "lbl_nombre_curso";
            this.lbl_nombre_curso.Size = new System.Drawing.Size(60, 21);
            this.lbl_nombre_curso.TabIndex = 70;
            this.lbl_nombre_curso.Text = "Curso:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.picture_eliminar);
            this.panel1.Controls.Add(this.txt_descripcion);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.picture_guardar);
            this.panel1.Location = new System.Drawing.Point(113, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 375);
            this.panel1.TabIndex = 80;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(52, 101);
            this.txt_descripcion.Margin = new System.Windows.Forms.Padding(5);
            this.txt_descripcion.MaxLength = 6;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(289, 29);
            this.txt_descripcion.TabIndex = 2;
            this.txt_descripcion.TextChanged += new System.EventHandler(this.txt_descripcion_TextChanged);
            this.txt_descripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_descripcion_KeyPress_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(87, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Formulario Curso";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lbl_buscar);
            this.panel2.Controls.Add(this.txt_buscar);
            this.panel2.Controls.Add(this.dgv_curso);
            this.panel2.Location = new System.Drawing.Point(533, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(504, 375);
            this.panel2.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(143, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 36);
            this.label3.TabIndex = 60;
            this.label3.Text = "Lista de cursos";
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_buscar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar.ForeColor = System.Drawing.Color.White;
            this.lbl_buscar.Location = new System.Drawing.Point(51, 75);
            this.lbl_buscar.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(113, 21);
            this.lbl_buscar.TabIndex = 58;
            this.lbl_buscar.Text = "Buscar curso:";
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(55, 106);
            this.txt_buscar.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(289, 29);
            this.txt_buscar.TabIndex = 4;
            this.txt_buscar.TextChanged += new System.EventHandler(this.txt_buscar_TextChanged);
            this.txt_buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_buscar_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Curso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::SistemaEstudiante.Properties.Resources.Abstracto;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1190, 545);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_id_curso);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txt_curso);
            this.Controls.Add(this.lbl_nombre_curso);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picture_atras);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Curso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Curso";
            this.Load += new System.EventHandler(this.Curso_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_atras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_eliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_guardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_curso)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verAyudaToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox picture_atras;
        private System.Windows.Forms.ToolStripMenuItem cursosEliminadosToolStripMenuItem;
        private System.Windows.Forms.PictureBox picture_eliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picture_guardar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txt_id_curso;
        private System.Windows.Forms.TextBox txt_curso;
        private System.Windows.Forms.Label lbl_nombre_curso;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.DataGridView dgv_curso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}