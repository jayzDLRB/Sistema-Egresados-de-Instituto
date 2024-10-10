namespace Presentacion.Principal
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.lnkHasOlvidadoContrasena = new System.Windows.Forms.LinkLabel();
            this.linkRegistrarse = new System.Windows.Forms.LinkLabel();
            this.txtContrasenalg = new Presentacion.Elementos.CustomPasswordTextBox();
            this.txtUsuariolg = new Presentacion.Elementos.CustomUsuarioTextBox();
            this.btnIniciarSesion = new Presentacion.Elementos.RoundedButton();
            this.minyCerrar1 = new Presentacion.Elementos.MinyCerrar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(469, 577);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(705, 26);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(121, 111);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(595, 161);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 58);
            this.label1.TabIndex = 6;
            this.label1.Text = "Iniciar Sesión";
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorMessage.Image")));
            this.lblErrorMessage.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblErrorMessage.Location = new System.Drawing.Point(564, 383);
            this.lblErrorMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(139, 23);
            this.lblErrorMessage.TabIndex = 13;
            this.lblErrorMessage.Text = "Error Message";
            this.lblErrorMessage.Visible = false;
            // 
            // lnkHasOlvidadoContrasena
            // 
            this.lnkHasOlvidadoContrasena.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.lnkHasOlvidadoContrasena.AutoSize = true;
            this.lnkHasOlvidadoContrasena.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkHasOlvidadoContrasena.LinkColor = System.Drawing.Color.MediumBlue;
            this.lnkHasOlvidadoContrasena.Location = new System.Drawing.Point(821, 421);
            this.lnkHasOlvidadoContrasena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkHasOlvidadoContrasena.Name = "lnkHasOlvidadoContrasena";
            this.lnkHasOlvidadoContrasena.Size = new System.Drawing.Size(185, 16);
            this.lnkHasOlvidadoContrasena.TabIndex = 14;
            this.lnkHasOlvidadoContrasena.TabStop = true;
            this.lnkHasOlvidadoContrasena.Text = "¿Has olvidado tu contraseña?";
            this.lnkHasOlvidadoContrasena.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkHasOlvidadoContrasena_LinkClicked);
            // 
            // linkRegistrarse
            // 
            this.linkRegistrarse.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.linkRegistrarse.AutoSize = true;
            this.linkRegistrarse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkRegistrarse.LinkColor = System.Drawing.Color.MediumBlue;
            this.linkRegistrarse.Location = new System.Drawing.Point(641, 538);
            this.linkRegistrarse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkRegistrarse.Name = "linkRegistrarse";
            this.linkRegistrarse.Size = new System.Drawing.Size(228, 16);
            this.linkRegistrarse.TabIndex = 15;
            this.linkRegistrarse.TabStop = true;
            this.linkRegistrarse.Text = "¿No Tienes Una Cuenta? ¡Regístrate!";
            this.linkRegistrarse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegistrarse_LinkClicked);
            // 
            // txtContrasenalg
            // 
            this.txtContrasenalg.Location = new System.Drawing.Point(568, 320);
            this.txtContrasenalg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContrasenalg.Name = "txtContrasenalg";
            this.txtContrasenalg.PasswordText = "";
            this.txtContrasenalg.Size = new System.Drawing.Size(363, 39);
            this.txtContrasenalg.TabIndex = 18;
            // 
            // txtUsuariolg
            // 
            this.txtUsuariolg.BackColor = System.Drawing.Color.White;
            this.txtUsuariolg.Location = new System.Drawing.Point(568, 244);
            this.txtUsuariolg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsuariolg.Name = "txtUsuariolg";
            this.txtUsuariolg.Size = new System.Drawing.Size(363, 39);
            this.txtUsuariolg.TabIndex = 17;
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnIniciarSesion.BorderRadius = 20;
            this.btnIniciarSesion.FlatAppearance.BorderSize = 0;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.Location = new System.Drawing.Point(644, 470);
            this.btnIniciarSesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(236, 46);
            this.btnIniciarSesion.TabIndex = 16;
            this.btnIniciarSesion.Text = "INICIAR SESIÓN";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // minyCerrar1
            // 
            this.minyCerrar1.Location = new System.Drawing.Point(913, 0);
            this.minyCerrar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.minyCerrar1.Name = "minyCerrar1";
            this.minyCerrar1.Size = new System.Drawing.Size(123, 57);
            this.minyCerrar1.TabIndex = 19;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1036, 577);
            this.Controls.Add(this.minyCerrar1);
            this.Controls.Add(this.txtContrasenalg);
            this.Controls.Add(this.txtUsuariolg);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.linkRegistrarse);
            this.Controls.Add(this.lnkHasOlvidadoContrasena);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.LinkLabel lnkHasOlvidadoContrasena;
        private System.Windows.Forms.LinkLabel linkRegistrarse;
        private Elementos.RoundedButton btnIniciarSesion;
    private Elementos.CustomUsuarioTextBox txtUsuariolg;
    private Elementos.CustomPasswordTextBox txtContrasenalg;
    private Elementos.MinyCerrar minyCerrar1;
  }
}