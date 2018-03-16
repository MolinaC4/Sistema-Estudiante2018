namespace SistemaEstudiante
{
    partial class Invitado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invitado));
            this.picture_control_pagos = new System.Windows.Forms.PictureBox();
            this.picture_asistencia = new System.Windows.Forms.PictureBox();
            this.lbl_asistencia = new System.Windows.Forms.Label();
            this.lbl_deuda = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verAyudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picture_control_pagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_asistencia)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picture_control_pagos
            // 
            this.picture_control_pagos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picture_control_pagos.BackColor = System.Drawing.Color.Transparent;
            this.picture_control_pagos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_control_pagos.Image = global::SistemaEstudiante.Properties.Resources.if_cash_register_17219;
            this.picture_control_pagos.Location = new System.Drawing.Point(83, 86);
            this.picture_control_pagos.Name = "picture_control_pagos";
            this.picture_control_pagos.Size = new System.Drawing.Size(137, 123);
            this.picture_control_pagos.TabIndex = 92;
            this.picture_control_pagos.TabStop = false;
            this.toolTip1.SetToolTip(this.picture_control_pagos, "Control de pagos");
            this.picture_control_pagos.Click += new System.EventHandler(this.btn_deuda_Click);
            // 
            // picture_asistencia
            // 
            this.picture_asistencia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picture_asistencia.BackColor = System.Drawing.Color.Transparent;
            this.picture_asistencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_asistencia.Image = global::SistemaEstudiante.Properties.Resources.if_date_edit_66719;
            this.picture_asistencia.Location = new System.Drawing.Point(304, 85);
            this.picture_asistencia.Name = "picture_asistencia";
            this.picture_asistencia.Size = new System.Drawing.Size(133, 131);
            this.picture_asistencia.TabIndex = 89;
            this.picture_asistencia.TabStop = false;
            this.toolTip1.SetToolTip(this.picture_asistencia, "Asistencia");
            this.picture_asistencia.Click += new System.EventHandler(this.btn_asistencia_Click);
            // 
            // lbl_asistencia
            // 
            this.lbl_asistencia.AutoSize = true;
            this.lbl_asistencia.BackColor = System.Drawing.Color.Transparent;
            this.lbl_asistencia.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_asistencia.ForeColor = System.Drawing.Color.White;
            this.lbl_asistencia.Location = new System.Drawing.Point(311, 54);
            this.lbl_asistencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_asistencia.Name = "lbl_asistencia";
            this.lbl_asistencia.Size = new System.Drawing.Size(114, 28);
            this.lbl_asistencia.TabIndex = 88;
            this.lbl_asistencia.Text = "Asistencia";
            this.lbl_asistencia.Click += new System.EventHandler(this.lbl_asistencia_Click);
            // 
            // lbl_deuda
            // 
            this.lbl_deuda.AutoSize = true;
            this.lbl_deuda.BackColor = System.Drawing.Color.Transparent;
            this.lbl_deuda.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deuda.ForeColor = System.Drawing.Color.White;
            this.lbl_deuda.Location = new System.Drawing.Point(65, 55);
            this.lbl_deuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_deuda.Name = "lbl_deuda";
            this.lbl_deuda.Size = new System.Drawing.Size(180, 28);
            this.lbl_deuda.TabIndex = 86;
            this.lbl_deuda.Text = "Control de pagos";
            // 
            // btnAtras
            // 
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtras.Location = new System.Drawing.Point(376, 246);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(117, 39);
            this.btnAtras.TabIndex = 80;
            this.btnAtras.Text = "Cerrar sesión";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(547, 24);
            this.menuStrip1.TabIndex = 93;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
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
            // Invitado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaEstudiante.Properties.Resources.Abstracto;
            this.ClientSize = new System.Drawing.Size(547, 297);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.picture_control_pagos);
            this.Controls.Add(this.picture_asistencia);
            this.Controls.Add(this.lbl_asistencia);
            this.Controls.Add(this.lbl_deuda);
            this.Controls.Add(this.btnAtras);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Invitado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            this.Load += new System.EventHandler(this.Invitado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_control_pagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_asistencia)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_control_pagos;
        private System.Windows.Forms.PictureBox picture_asistencia;
        private System.Windows.Forms.Label lbl_asistencia;
        private System.Windows.Forms.Label lbl_deuda;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verAyudaToolStripMenuItem;
    }
}