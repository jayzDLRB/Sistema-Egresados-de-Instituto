using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Elementos
{
  public class MinyCerrar : UserControl
  {
    private Button btnMinimizar;
    private Button btnCerrar;
    private Panel topPanel;

    public MinyCerrar()
    {
      InitializeComponent();
    }

    private void InitializeComponent()
    {
      this.topPanel = new System.Windows.Forms.Panel();
      this.btnMinimizar = new System.Windows.Forms.Button();
      this.btnCerrar = new System.Windows.Forms.Button();
      this.topPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // topPanel
      // 
      this.topPanel.BackColor = System.Drawing.Color.White;
      this.topPanel.Controls.Add(this.btnMinimizar);
      this.topPanel.Controls.Add(this.btnCerrar);
      this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
      this.topPanel.Location = new System.Drawing.Point(0, 0);
      this.topPanel.Name = "topPanel";
      this.topPanel.Size = new System.Drawing.Size(92, 46); // Ajustar tamaño del panel
      this.topPanel.TabIndex = 0;
      // 
      // btnMinimizar
      // 
      this.btnMinimizar.BackColor = System.Drawing.Color.White;
      this.btnMinimizar.FlatAppearance.BorderSize = 0;
      this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnMinimizar.ForeColor = System.Drawing.Color.FromArgb(0, 102, 204);
      this.btnMinimizar.Location = new System.Drawing.Point(10, 5); // Ajustar ubicación
      this.btnMinimizar.Name = "btnMinimizar";
      this.btnMinimizar.Size = new System.Drawing.Size(30, 30); // Aumentar tamaño
      this.btnMinimizar.TabIndex = 0;
      this.btnMinimizar.Text = "-";
      this.btnMinimizar.Font = new Font("Segoe UI", 14F, FontStyle.Regular); // Ajustar fuente para mayor tamaño
      this.btnMinimizar.UseVisualStyleBackColor = false;
      this.btnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
      // 
      // btnCerrar
      // 
      this.btnCerrar.BackColor = System.Drawing.Color.White;
      this.btnCerrar.FlatAppearance.BorderSize = 0;
      this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(0, 102, 204);
      this.btnCerrar.Location = new System.Drawing.Point(50, 5); // Ajustar ubicación
      this.btnCerrar.Name = "btnCerrar";
      this.btnCerrar.Size = new System.Drawing.Size(30, 30); // Aumentar tamaño
      this.btnCerrar.TabIndex = 1;
      this.btnCerrar.Text = "X";
      this.btnCerrar.Font = new Font("Segoe UI", 14F, FontStyle.Regular); // Ajustar fuente para mayor tamaño
      this.btnCerrar.UseVisualStyleBackColor = false;
      this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
      // 
      // MinyCerrar
      // 
      this.Controls.Add(this.topPanel);
      this.Name = "MinyCerrar";
      this.Size = new System.Drawing.Size(92, 46); // Ajustar tamaño del control
      this.topPanel.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    // Métodos para los botones
    private void BtnMinimizar_Click(object sender, EventArgs e)
    {
      Form parentForm = this.FindForm();
      if (parentForm != null)
      {
        parentForm.WindowState = FormWindowState.Minimized;
      }
    }

    private void BtnCerrar_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }
  }
}

