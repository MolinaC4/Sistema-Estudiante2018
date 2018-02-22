namespace SistemaEstudiante
{
    partial class EstudiantesInactivos
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
            this.txt_cedula1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picture_atras = new System.Windows.Forms.PictureBox();
            this.dgv_estinactivo = new System.Windows.Forms.DataGridView();
            this.picture_activar = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_atras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estinactivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_activar)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_cedula1
            // 
            this.txt_cedula1.Location = new System.Drawing.Point(8, 46);
            this.txt_cedula1.Margin = new System.Windows.Forms.Padding(5);
            this.txt_cedula1.Name = "txt_cedula1";
            this.txt_cedula1.Size = new System.Drawing.Size(164, 29);
            this.txt_cedula1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.picture_activar);
            this.groupBox1.Controls.Add(this.txt_cedula1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(31, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 311);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Activar Estudiante";
            // 
            // picture_atras
            // 
            this.picture_atras.BackColor = System.Drawing.Color.Transparent;
            this.picture_atras.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.picture_atras.Image = global::SistemaEstudiante.Properties.Resources.FontAwesome_f060_0__641;
            this.picture_atras.Location = new System.Drawing.Point(802, 386);
            this.picture_atras.Name = "picture_atras";
            this.picture_atras.Size = new System.Drawing.Size(63, 61);
            this.picture_atras.TabIndex = 70;
            this.picture_atras.TabStop = false;
            this.picture_atras.Click += new System.EventHandler(this.picture_atras_Click);
            // 
            // dgv_estinactivo
            // 
            this.dgv_estinactivo.AllowUserToAddRows = false;
            this.dgv_estinactivo.AllowUserToDeleteRows = false;
            this.dgv_estinactivo.AllowUserToOrderColumns = true;
            this.dgv_estinactivo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_estinactivo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_estinactivo.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dgv_estinactivo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_estinactivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_estinactivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_estinactivo.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_estinactivo.Location = new System.Drawing.Point(250, 70);
            this.dgv_estinactivo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dgv_estinactivo.MultiSelect = false;
            this.dgv_estinactivo.Name = "dgv_estinactivo";
            this.dgv_estinactivo.ReadOnly = true;
            this.dgv_estinactivo.RowHeadersVisible = false;
            this.dgv_estinactivo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_estinactivo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_estinactivo.Size = new System.Drawing.Size(615, 299);
            this.dgv_estinactivo.TabIndex = 71;
            this.dgv_estinactivo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_estinactivo_CellDoubleClick);
            this.dgv_estinactivo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_estinactivo_CellDoubleClick);
            // 
            // picture_activar
            // 
            this.picture_activar.BackColor = System.Drawing.Color.Transparent;
            this.picture_activar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.picture_activar.Image = global::SistemaEstudiante.Properties.Resources.if_f_check_256_282474;
            this.picture_activar.Location = new System.Drawing.Point(8, 101);
            this.picture_activar.Name = "picture_activar";
            this.picture_activar.Size = new System.Drawing.Size(63, 61);
            this.picture_activar.TabIndex = 69;
            this.picture_activar.TabStop = false;
            this.toolTip1.SetToolTip(this.picture_activar, "Activar Estudiante");
            this.picture_activar.Click += new System.EventHandler(this.btnActiva_Click);
            // 
            // EstudiantesInactivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaEstudiante.Properties.Resources.Abstracto;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(895, 459);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_estinactivo);
            this.Controls.Add(this.picture_atras);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "EstudiantesInactivos";
            this.Text = "EstudiantesInactivos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_atras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estinactivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_activar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_cedula1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picture_atras;
        private System.Windows.Forms.DataGridView dgv_estinactivo;
        private System.Windows.Forms.PictureBox picture_activar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}