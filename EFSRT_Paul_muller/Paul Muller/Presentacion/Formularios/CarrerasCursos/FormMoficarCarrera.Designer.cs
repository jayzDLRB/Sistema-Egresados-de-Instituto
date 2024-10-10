namespace Presentacion.Formularios.CarrerasCursos
{
    partial class FormMoficarCarrera
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
            this.txtnomcarr = new System.Windows.Forms.TextBox();
            this.txtdescrip = new System.Windows.Forms.TextBox();
            this.btnModifcar = new Presentacion.Elementos.RoundedButton();
            this.txtCodigoModificar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtnomcarr
            // 
            this.txtnomcarr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomcarr.Location = new System.Drawing.Point(47, 96);
            this.txtnomcarr.Multiline = true;
            this.txtnomcarr.Name = "txtnomcarr";
            this.txtnomcarr.Size = new System.Drawing.Size(246, 53);
            this.txtnomcarr.TabIndex = 1;
            // 
            // txtdescrip
            // 
            this.txtdescrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescrip.Location = new System.Drawing.Point(47, 197);
            this.txtdescrip.Multiline = true;
            this.txtdescrip.Name = "txtdescrip";
            this.txtdescrip.Size = new System.Drawing.Size(246, 57);
            this.txtdescrip.TabIndex = 2;
            // 
            // btnModifcar
            // 
            this.btnModifcar.BackColor = System.Drawing.Color.Gold;
            this.btnModifcar.BorderRadius = 20;
            this.btnModifcar.FlatAppearance.BorderSize = 0;
            this.btnModifcar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifcar.Location = new System.Drawing.Point(53, 308);
            this.btnModifcar.Name = "btnModifcar";
            this.btnModifcar.Size = new System.Drawing.Size(230, 78);
            this.btnModifcar.TabIndex = 0;
            this.btnModifcar.Text = "M";
            this.btnModifcar.UseVisualStyleBackColor = false;
            this.btnModifcar.Click += new System.EventHandler(this.btnModifcar_Click);
            // 
            // txtCodigoModificar
            // 
            this.txtCodigoModificar.Location = new System.Drawing.Point(53, 44);
            this.txtCodigoModificar.Name = "txtCodigoModificar";
            this.txtCodigoModificar.Size = new System.Drawing.Size(50, 22);
            this.txtCodigoModificar.TabIndex = 3;
            this.txtCodigoModificar.Visible = false;
            // 
            // FormMoficarCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 433);
            this.Controls.Add(this.txtCodigoModificar);
            this.Controls.Add(this.txtdescrip);
            this.Controls.Add(this.txtnomcarr);
            this.Controls.Add(this.btnModifcar);
            this.Name = "FormMoficarCarrera";
            this.Text = "FormMoficarCarrera";
            this.Load += new System.EventHandler(this.FormMoficarCarrera_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Elementos.RoundedButton btnModifcar;
        private System.Windows.Forms.TextBox txtnomcarr;
        private System.Windows.Forms.TextBox txtdescrip;
        private System.Windows.Forms.TextBox txtCodigoModificar;
    }
}