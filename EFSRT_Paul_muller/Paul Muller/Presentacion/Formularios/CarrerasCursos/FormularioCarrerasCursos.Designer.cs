namespace Presentacion.Formularios.CarrerasCursos
{
    partial class FormularioCarrerasCursos
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
      this.panel2 = new System.Windows.Forms.Panel();
      this.txtDescripcionCarrera = new System.Windows.Forms.TextBox();
      this.dgvCarreras = new System.Windows.Forms.DataGridView();
      this.label1 = new System.Windows.Forms.Label();
      this.panel3 = new System.Windows.Forms.Panel();
      this.txtNombreCarrera = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.btnGuardarCarrera = new Presentacion.Elementos.RoundedButton();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvCarreras)).BeginInit();
      this.panel3.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.Color.Goldenrod;
      this.panel2.Controls.Add(this.txtDescripcionCarrera);
      this.panel2.Location = new System.Drawing.Point(164, 81);
      this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.panel2.Name = "panel2";
      this.panel2.Padding = new System.Windows.Forms.Padding(1);
      this.panel2.Size = new System.Drawing.Size(349, 27);
      this.panel2.TabIndex = 84;
      // 
      // txtDescripcionCarrera
      // 
      this.txtDescripcionCarrera.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.txtDescripcionCarrera.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtDescripcionCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtDescripcionCarrera.Location = new System.Drawing.Point(1, 1);
      this.txtDescripcionCarrera.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.txtDescripcionCarrera.Multiline = true;
      this.txtDescripcionCarrera.Name = "txtDescripcionCarrera";
      this.txtDescripcionCarrera.Size = new System.Drawing.Size(347, 25);
      this.txtDescripcionCarrera.TabIndex = 0;
      // 
      // dgvCarreras
      // 
      this.dgvCarreras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvCarreras.Location = new System.Drawing.Point(31, 203);
      this.dgvCarreras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.dgvCarreras.Name = "dgvCarreras";
      this.dgvCarreras.RowHeadersWidth = 51;
      this.dgvCarreras.RowTemplate.Height = 24;
      this.dgvCarreras.Size = new System.Drawing.Size(508, 241);
      this.dgvCarreras.TabIndex = 82;
      this.dgvCarreras.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarreras_CellClick);
      this.dgvCarreras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarreras_CellContentClick);
      this.dgvCarreras.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvCarreras_CellPainting);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(84, 41);
      this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(76, 19);
      this.label1.TabIndex = 80;
      this.label1.Text = "Carreras:";
      // 
      // panel3
      // 
      this.panel3.BackColor = System.Drawing.Color.Goldenrod;
      this.panel3.Controls.Add(this.txtNombreCarrera);
      this.panel3.Location = new System.Drawing.Point(164, 41);
      this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.panel3.Name = "panel3";
      this.panel3.Padding = new System.Windows.Forms.Padding(1);
      this.panel3.Size = new System.Drawing.Size(284, 26);
      this.panel3.TabIndex = 79;
      // 
      // txtNombreCarrera
      // 
      this.txtNombreCarrera.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.txtNombreCarrera.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtNombreCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtNombreCarrera.Location = new System.Drawing.Point(1, 1);
      this.txtNombreCarrera.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.txtNombreCarrera.Multiline = true;
      this.txtNombreCarrera.Name = "txtNombreCarrera";
      this.txtNombreCarrera.Size = new System.Drawing.Size(282, 24);
      this.txtNombreCarrera.TabIndex = 0;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(61, 81);
      this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(99, 19);
      this.label2.TabIndex = 81;
      this.label2.Text = "Descripcion:";
      // 
      // btnGuardarCarrera
      // 
      this.btnGuardarCarrera.BackColor = System.Drawing.Color.DodgerBlue;
      this.btnGuardarCarrera.BorderRadius = 20;
      this.btnGuardarCarrera.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
      this.btnGuardarCarrera.FlatAppearance.BorderSize = 0;
      this.btnGuardarCarrera.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
      this.btnGuardarCarrera.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
      this.btnGuardarCarrera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnGuardarCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnGuardarCarrera.Location = new System.Drawing.Point(146, 130);
      this.btnGuardarCarrera.Margin = new System.Windows.Forms.Padding(2);
      this.btnGuardarCarrera.Name = "btnGuardarCarrera";
      this.btnGuardarCarrera.Size = new System.Drawing.Size(319, 37);
      this.btnGuardarCarrera.TabIndex = 83;
      this.btnGuardarCarrera.Text = "Guardar Carreras";
      this.btnGuardarCarrera.UseVisualStyleBackColor = false;
      this.btnGuardarCarrera.Click += new System.EventHandler(this.btnGuardarCarrera_Click);
      // 
      // FormularioCarrerasCursos
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(593, 534);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.btnGuardarCarrera);
      this.Controls.Add(this.dgvCarreras);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.panel3);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.Name = "FormularioCarrerasCursos";
      this.Text = "FormularioCarrerasCursos";
      this.Load += new System.EventHandler(this.FormularioCarrerasCursos_Load);
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvCarreras)).EndInit();
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDescripcionCarrera;
        private Elementos.RoundedButton btnGuardarCarrera;
        private System.Windows.Forms.DataGridView dgvCarreras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtNombreCarrera;
    private System.Windows.Forms.Label label2;
  }
}