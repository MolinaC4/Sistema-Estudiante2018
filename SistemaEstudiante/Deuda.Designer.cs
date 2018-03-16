namespace SistemaEstudiante
{
    partial class Deuda
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
            this.lbl_busqueda = new System.Windows.Forms.Label();
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.dgv_deuda = new System.Windows.Forms.DataGridView();
            this.picture_atras = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_deuda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_atras)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_busqueda
            // 
            this.lbl_busqueda.AutoSize = true;
            this.lbl_busqueda.BackColor = System.Drawing.Color.Transparent;
            this.lbl_busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_busqueda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_busqueda.Location = new System.Drawing.Point(27, 37);
            this.lbl_busqueda.Name = "lbl_busqueda";
            this.lbl_busqueda.Size = new System.Drawing.Size(90, 20);
            this.lbl_busqueda.TabIndex = 7;
            this.lbl_busqueda.Text = "Busqueda";
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.Location = new System.Drawing.Point(31, 74);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(226, 20);
            this.txt_busqueda.TabIndex = 8;
            this.txt_busqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_busqueda_KeyUp);
            // 
            // dgv_deuda
            // 
            this.dgv_deuda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_deuda.Location = new System.Drawing.Point(31, 100);
            this.dgv_deuda.Name = "dgv_deuda";
            this.dgv_deuda.Size = new System.Drawing.Size(756, 283);
            this.dgv_deuda.TabIndex = 9;
            // 
            // picture_atras
            // 
            this.picture_atras.BackColor = System.Drawing.Color.Transparent;
            this.picture_atras.Image = global::SistemaEstudiante.Properties.Resources.FontAwesome_f060_0__641;
            this.picture_atras.Location = new System.Drawing.Point(724, 390);
            this.picture_atras.Name = "picture_atras";
            this.picture_atras.Size = new System.Drawing.Size(63, 61);
            this.picture_atras.TabIndex = 68;
            this.picture_atras.TabStop = false;
            this.picture_atras.Click += new System.EventHandler(this.picture_atras_Click);
            // 
            // Deuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(819, 463);
            this.Controls.Add(this.picture_atras);
            this.Controls.Add(this.dgv_deuda);
            this.Controls.Add(this.txt_busqueda);
            this.Controls.Add(this.lbl_busqueda);
            this.Name = "Deuda";
            this.Text = "REGISTRO DE DEUDAS";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_deuda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_atras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_busqueda;
        private System.Windows.Forms.TextBox txt_busqueda;
        private System.Windows.Forms.DataGridView dgv_deuda;
        private System.Windows.Forms.PictureBox picture_atras;
    }
}