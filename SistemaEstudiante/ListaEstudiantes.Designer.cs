namespace SistemaEstudiante
{
    partial class ListaEstudiantes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_estudiante = new System.Windows.Forms.DataGridView();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.picture_atras = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estudiante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_atras)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_estudiante
            // 
            this.dgv_estudiante.AllowUserToAddRows = false;
            this.dgv_estudiante.AllowUserToDeleteRows = false;
            this.dgv_estudiante.AllowUserToOrderColumns = true;
            this.dgv_estudiante.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_estudiante.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_estudiante.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dgv_estudiante.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_estudiante.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_estudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_estudiante.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_estudiante.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_estudiante.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_estudiante.Location = new System.Drawing.Point(30, 73);
            this.dgv_estudiante.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dgv_estudiante.MultiSelect = false;
            this.dgv_estudiante.Name = "dgv_estudiante";
            this.dgv_estudiante.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_estudiante.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_estudiante.RowHeadersVisible = false;
            this.dgv_estudiante.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_estudiante.Size = new System.Drawing.Size(881, 364);
            this.dgv_estudiante.TabIndex = 34;
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(189, 36);
            this.txt_buscar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(211, 20);
            this.txt_buscar.TabIndex = 32;
            this.txt_buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_buscar_KeyPress);
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_buscar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar.ForeColor = System.Drawing.Color.White;
            this.lbl_buscar.Location = new System.Drawing.Point(26, 36);
            this.lbl_buscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(145, 21);
            this.lbl_buscar.TabIndex = 33;
            this.lbl_buscar.Text = "Buscar estudiante:";
            // 
            // picture_atras
            // 
            this.picture_atras.BackColor = System.Drawing.Color.Transparent;
            this.picture_atras.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.picture_atras.Image = global::SistemaEstudiante.Properties.Resources.FontAwesome_f060_0__641;
            this.picture_atras.Location = new System.Drawing.Point(848, 449);
            this.picture_atras.Name = "picture_atras";
            this.picture_atras.Size = new System.Drawing.Size(63, 61);
            this.picture_atras.TabIndex = 69;
            this.picture_atras.TabStop = false;
            this.picture_atras.Click += new System.EventHandler(this.picture_atras_Click);
            // 
            // ListaEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::SistemaEstudiante.Properties.Resources.Abstracto;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(930, 522);
            this.Controls.Add(this.picture_atras);
            this.Controls.Add(this.dgv_estudiante);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.lbl_buscar);
            this.Name = "ListaEstudiantes";
            this.Text = "ListaEstudiantes";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estudiante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_atras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_estudiante;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.PictureBox picture_atras;
    }
}