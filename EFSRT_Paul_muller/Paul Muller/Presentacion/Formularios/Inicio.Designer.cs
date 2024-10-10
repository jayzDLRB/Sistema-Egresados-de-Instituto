namespace Presentacion.Formularios
{
    partial class Inicio
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
      this.panel2 = new System.Windows.Forms.Panel();
      this.horafecha = new System.Windows.Forms.Timer(this.components);
      this.lblHora = new System.Windows.Forms.Label();
      this.lblFecha = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // panel2
      // 
      this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
      this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.panel2.Location = new System.Drawing.Point(119, 30);
      this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(418, 347);
      this.panel2.TabIndex = 3;
      // 
      // horafecha
      // 
      this.horafecha.Enabled = true;
      this.horafecha.Tick += new System.EventHandler(this.horafecha_Tick);
      // 
      // lblHora
      // 
      this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.lblHora.AutoSize = true;
      this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
      this.lblHora.Location = new System.Drawing.Point(218, 393);
      this.lblHora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.lblHora.Name = "lblHora";
      this.lblHora.Size = new System.Drawing.Size(108, 39);
      this.lblHora.TabIndex = 4;
      this.lblHora.Text = "00:00";
      // 
      // lblFecha
      // 
      this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.lblFecha.AutoSize = true;
      this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
      this.lblFecha.ForeColor = System.Drawing.SystemColors.AppWorkspace;
      this.lblFecha.Location = new System.Drawing.Point(31, 432);
      this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.lblFecha.Name = "lblFecha";
      this.lblFecha.Size = new System.Drawing.Size(388, 39);
      this.lblFecha.TabIndex = 5;
      this.lblFecha.Text = "Dia, 00 de Mes del 0000";
      // 
      // Inicio
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(637, 489);
      this.Controls.Add(this.lblFecha);
      this.Controls.Add(this.lblHora);
      this.Controls.Add(this.panel2);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.Name = "Inicio";
      this.Text = "Inicio";
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer horafecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
    }
}