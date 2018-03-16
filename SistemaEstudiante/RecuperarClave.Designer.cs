namespace SistemaEstudiante
{
    partial class RecuperarClave
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
            this.txt_respuestaS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_opcion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.btn_recuperar = new System.Windows.Forms.Button();
            this.btn_atras = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_atras)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_respuestaS
            // 
            this.txt_respuestaS.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_respuestaS.Location = new System.Drawing.Point(290, 138);
            this.txt_respuestaS.Margin = new System.Windows.Forms.Padding(4);
            this.txt_respuestaS.MaxLength = 10;
            this.txt_respuestaS.Multiline = true;
            this.txt_respuestaS.Name = "txt_respuestaS";
            this.txt_respuestaS.PasswordChar = '*';
            this.txt_respuestaS.Size = new System.Drawing.Size(250, 29);
            this.txt_respuestaS.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(75, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 22);
            this.label1.TabIndex = 78;
            this.label1.Text = "Respuesta de Seguridad";
            // 
            // cbx_opcion
            // 
            this.cbx_opcion.FormattingEnabled = true;
            this.cbx_opcion.Items.AddRange(new object[] {
            "Nombre de un familiar",
            "Nombre de su mascota",
            "Color favorito",
            "Comida favorita"});
            this.cbx_opcion.Location = new System.Drawing.Point(79, 139);
            this.cbx_opcion.Name = "cbx_opcion";
            this.cbx_opcion.Size = new System.Drawing.Size(188, 21);
            this.cbx_opcion.TabIndex = 76;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(73, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 23);
            this.label5.TabIndex = 75;
            this.label5.Text = "Nombre de usuario:";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.Location = new System.Drawing.Point(290, 57);
            this.txt_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_usuario.MaxLength = 20;
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(252, 29);
            this.txt_usuario.TabIndex = 74;
            // 
            // btn_recuperar
            // 
            this.btn_recuperar.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recuperar.Location = new System.Drawing.Point(370, 209);
            this.btn_recuperar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_recuperar.Name = "btn_recuperar";
            this.btn_recuperar.Size = new System.Drawing.Size(172, 55);
            this.btn_recuperar.TabIndex = 79;
            this.btn_recuperar.Text = "Recuperar Clave";
            this.btn_recuperar.UseVisualStyleBackColor = true;
            this.btn_recuperar.Click += new System.EventHandler(this.btn_recuperar_Click);
            // 
            // btn_atras
            // 
            this.btn_atras.BackColor = System.Drawing.Color.Transparent;
            this.btn_atras.Image = global::SistemaEstudiante.Properties.Resources.FontAwesome_f060_0__641;
            this.btn_atras.Location = new System.Drawing.Point(290, 209);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(63, 61);
            this.btn_atras.TabIndex = 80;
            this.btn_atras.TabStop = false;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // RecuperarClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaEstudiante.Properties.Resources.Abstracto;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(601, 289);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.btn_recuperar);
            this.Controls.Add(this.txt_respuestaS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_opcion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_usuario);
            this.Name = "RecuperarClave";
            this.Text = "RecuperarClave";
            ((System.ComponentModel.ISupportInitialize)(this.btn_atras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_respuestaS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_opcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Button btn_recuperar;
        private System.Windows.Forms.PictureBox btn_atras;
    }
}