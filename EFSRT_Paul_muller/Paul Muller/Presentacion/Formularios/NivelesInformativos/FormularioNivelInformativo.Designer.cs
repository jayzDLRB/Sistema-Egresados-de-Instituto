namespace Presentacion.Formularios.NivelesInformativos
{
    partial class FormularioNivelInformativo
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtNombreNivelInformativo = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDescripcionNivelInformativo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardarNivelInformativo = new Presentacion.Elementos.RoundedButton();
            this.dvgNivelInformativo = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgNivelInformativo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 28);
            this.label1.TabIndex = 82;
            this.label1.Text = "Nivel Informativo:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Goldenrod;
            this.panel3.Controls.Add(this.txtNombreNivelInformativo);
            this.panel3.Location = new System.Drawing.Point(237, 53);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(1);
            this.panel3.Size = new System.Drawing.Size(181, 34);
            this.panel3.TabIndex = 81;
            // 
            // txtNombreNivelInformativo
            // 
            this.txtNombreNivelInformativo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreNivelInformativo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNombreNivelInformativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreNivelInformativo.Location = new System.Drawing.Point(1, 1);
            this.txtNombreNivelInformativo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreNivelInformativo.Multiline = true;
            this.txtNombreNivelInformativo.Name = "txtNombreNivelInformativo";
            this.txtNombreNivelInformativo.Size = new System.Drawing.Size(179, 32);
            this.txtNombreNivelInformativo.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Goldenrod;
            this.panel2.Controls.Add(this.txtDescripcionNivelInformativo);
            this.panel2.Location = new System.Drawing.Point(237, 108);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(1);
            this.panel2.Size = new System.Drawing.Size(348, 34);
            this.panel2.TabIndex = 86;
            // 
            // txtDescripcionNivelInformativo
            // 
            this.txtDescripcionNivelInformativo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcionNivelInformativo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescripcionNivelInformativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionNivelInformativo.Location = new System.Drawing.Point(1, 1);
            this.txtDescripcionNivelInformativo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcionNivelInformativo.Multiline = true;
            this.txtDescripcionNivelInformativo.Name = "txtDescripcionNivelInformativo";
            this.txtDescripcionNivelInformativo.Size = new System.Drawing.Size(346, 32);
            this.txtDescripcionNivelInformativo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 28);
            this.label2.TabIndex = 85;
            this.label2.Text = "Descripcion:";
            // 
            // btnGuardarNivelInformativo
            // 
            this.btnGuardarNivelInformativo.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnGuardarNivelInformativo.BorderRadius = 20;
            this.btnGuardarNivelInformativo.FlatAppearance.BorderSize = 0;
            this.btnGuardarNivelInformativo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarNivelInformativo.Location = new System.Drawing.Point(110, 161);
            this.btnGuardarNivelInformativo.Name = "btnGuardarNivelInformativo";
            this.btnGuardarNivelInformativo.Size = new System.Drawing.Size(436, 66);
            this.btnGuardarNivelInformativo.TabIndex = 87;
            this.btnGuardarNivelInformativo.Text = "Guardar Nivel Informativo";
            this.btnGuardarNivelInformativo.UseVisualStyleBackColor = false;
            this.btnGuardarNivelInformativo.Click += new System.EventHandler(this.btnGuardarNivelInformativo_Click);
            // 
            // dvgNivelInformativo
            // 
            this.dvgNivelInformativo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgNivelInformativo.Location = new System.Drawing.Point(38, 243);
            this.dvgNivelInformativo.Name = "dvgNivelInformativo";
            this.dvgNivelInformativo.RowHeadersWidth = 51;
            this.dvgNivelInformativo.RowTemplate.Height = 24;
            this.dvgNivelInformativo.Size = new System.Drawing.Size(547, 347);
            this.dvgNivelInformativo.TabIndex = 88;
            this.dvgNivelInformativo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgNivelInformativo_CellClick);
            this.dvgNivelInformativo.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dvgNivelInformativo_CellPainting);
            // 
            // FormularioNivelInformativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 630);
            this.Controls.Add(this.dvgNivelInformativo);
            this.Controls.Add(this.btnGuardarNivelInformativo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioNivelInformativo";
            this.Text = "FormularioNivelInformativo";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgNivelInformativo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtNombreNivelInformativo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDescripcionNivelInformativo;
        private System.Windows.Forms.Label label2;
        private Elementos.RoundedButton btnGuardarNivelInformativo;
        private System.Windows.Forms.DataGridView dvgNivelInformativo;
    }
}