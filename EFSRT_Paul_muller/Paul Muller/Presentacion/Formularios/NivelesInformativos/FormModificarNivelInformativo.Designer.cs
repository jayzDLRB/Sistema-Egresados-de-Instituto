namespace Presentacion.Formularios.NivelesInformativos
{
    partial class FormModificarNivelInformativo
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
            this.txtCodigoModificarNivelInformativo = new System.Windows.Forms.TextBox();
            this.txtDescripNl = new System.Windows.Forms.TextBox();
            this.txtNomNivel = new System.Windows.Forms.TextBox();
            this.btnModifcarNLI = new Presentacion.Elementos.RoundedButton();
            this.SuspendLayout();
            // 
            // txtCodigoModificarNivelInformativo
            // 
            this.txtCodigoModificarNivelInformativo.Location = new System.Drawing.Point(53, 45);
            this.txtCodigoModificarNivelInformativo.Name = "txtCodigoModificarNivelInformativo";
            this.txtCodigoModificarNivelInformativo.Size = new System.Drawing.Size(50, 22);
            this.txtCodigoModificarNivelInformativo.TabIndex = 7;
            this.txtCodigoModificarNivelInformativo.Visible = false;
            // 
            // txtDescripNl
            // 
            this.txtDescripNl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripNl.Location = new System.Drawing.Point(47, 198);
            this.txtDescripNl.Multiline = true;
            this.txtDescripNl.Name = "txtDescripNl";
            this.txtDescripNl.Size = new System.Drawing.Size(246, 57);
            this.txtDescripNl.TabIndex = 6;
            // 
            // txtNomNivel
            // 
            this.txtNomNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomNivel.Location = new System.Drawing.Point(47, 97);
            this.txtNomNivel.Multiline = true;
            this.txtNomNivel.Name = "txtNomNivel";
            this.txtNomNivel.Size = new System.Drawing.Size(246, 53);
            this.txtNomNivel.TabIndex = 5;
            // 
            // btnModifcarNLI
            // 
            this.btnModifcarNLI.BackColor = System.Drawing.Color.Gold;
            this.btnModifcarNLI.BorderRadius = 20;
            this.btnModifcarNLI.FlatAppearance.BorderSize = 0;
            this.btnModifcarNLI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifcarNLI.Location = new System.Drawing.Point(53, 309);
            this.btnModifcarNLI.Name = "btnModifcarNLI";
            this.btnModifcarNLI.Size = new System.Drawing.Size(230, 78);
            this.btnModifcarNLI.TabIndex = 4;
            this.btnModifcarNLI.Text = "M";
            this.btnModifcarNLI.UseVisualStyleBackColor = false;
            this.btnModifcarNLI.Click += new System.EventHandler(this.btnModifcarNLI_Click);
            // 
            // FormModificarNivelInformativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 433);
            this.Controls.Add(this.txtCodigoModificarNivelInformativo);
            this.Controls.Add(this.txtDescripNl);
            this.Controls.Add(this.txtNomNivel);
            this.Controls.Add(this.btnModifcarNLI);
            this.Name = "FormModificarNivelInformativo";
            this.Text = "FormModificarNivelInformativo";
            this.Load += new System.EventHandler(this.FormModificarNivelInformativo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigoModificarNivelInformativo;
        private System.Windows.Forms.TextBox txtDescripNl;
        private System.Windows.Forms.TextBox txtNomNivel;
        private Elementos.RoundedButton btnModifcarNLI;
    }
}