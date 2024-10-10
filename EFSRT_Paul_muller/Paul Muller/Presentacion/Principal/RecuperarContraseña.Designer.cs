namespace Presentacion.Principal
{
    partial class RecuperarContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecuperarContraseña));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtRegresarRcp = new Presentacion.Elementos.RoundedButton();
            this.btnEnviarCorreo = new Presentacion.Elementos.RoundedButton();
            this.txtCorreoRecuperacion = new Presentacion.Elementos.CustomCorreoTextBox();
            this.lblTexto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(484, 406);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox2.Location = new System.Drawing.Point(0, 395);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(484, 267);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // txtRegresarRcp
            // 
            this.txtRegresarRcp.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtRegresarRcp.BorderRadius = 20;
            this.txtRegresarRcp.FlatAppearance.BorderSize = 0;
            this.txtRegresarRcp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtRegresarRcp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtRegresarRcp.ForeColor = System.Drawing.Color.White;
            this.txtRegresarRcp.Location = new System.Drawing.Point(81, 375);
            this.txtRegresarRcp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRegresarRcp.Name = "txtRegresarRcp";
            this.txtRegresarRcp.Size = new System.Drawing.Size(313, 46);
            this.txtRegresarRcp.TabIndex = 25;
            this.txtRegresarRcp.Text = "REGRESAR";
            this.txtRegresarRcp.UseVisualStyleBackColor = false;
            this.txtRegresarRcp.Click += new System.EventHandler(this.txtRegresarRcp_Click);
            // 
            // btnEnviarCorreo
            // 
            this.btnEnviarCorreo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEnviarCorreo.BorderRadius = 20;
            this.btnEnviarCorreo.FlatAppearance.BorderSize = 0;
            this.btnEnviarCorreo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarCorreo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEnviarCorreo.ForeColor = System.Drawing.Color.White;
            this.btnEnviarCorreo.Location = new System.Drawing.Point(80, 322);
            this.btnEnviarCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnviarCorreo.Name = "btnEnviarCorreo";
            this.btnEnviarCorreo.Size = new System.Drawing.Size(313, 46);
            this.btnEnviarCorreo.TabIndex = 24;
            this.btnEnviarCorreo.Text = "ENVIAR";
            this.btnEnviarCorreo.UseVisualStyleBackColor = false;
            this.btnEnviarCorreo.Click += new System.EventHandler(this.btnEnviarCorreo_Click);
            // 
            // txtCorreoRecuperacion
            // 
            this.txtCorreoRecuperacion.BackColor = System.Drawing.Color.White;
            this.txtCorreoRecuperacion.Location = new System.Drawing.Point(83, 249);
            this.txtCorreoRecuperacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreoRecuperacion.Name = "txtCorreoRecuperacion";
            this.txtCorreoRecuperacion.Size = new System.Drawing.Size(312, 49);
            this.txtCorreoRecuperacion.TabIndex = 26;
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(98, 448);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(44, 16);
            this.lblTexto.TabIndex = 27;
            this.lblTexto.Text = "label1";
            // 
            // RecuperarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 662);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.txtCorreoRecuperacion);
            this.Controls.Add(this.txtRegresarRcp);
            this.Controls.Add(this.btnEnviarCorreo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RecuperarContraseña";
            this.Text = "RecuperarContraseña";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Elementos.RoundedButton txtRegresarRcp;
        private Elementos.RoundedButton btnEnviarCorreo;
    private Elementos.CustomCorreoTextBox txtCorreoRecuperacion;
        private System.Windows.Forms.Label lblTexto;
    }
}