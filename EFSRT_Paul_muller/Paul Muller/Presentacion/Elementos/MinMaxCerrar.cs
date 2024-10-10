using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Elementos
{
  public class MinMaxCerrar : UserControl
  {
    private Button btnMinimizar;
    private Button btnMaximizar;
    private Button btnCerrar;
    private Panel topPanel;

    public MinMaxCerrar()
    {
      InitializeComponent();
    }

    private void InitializeComponent()
    {
      this.topPanel = new System.Windows.Forms.Panel();
      this.btnMinimizar = new System.Windows.Forms.Button();
      this.btnMaximizar = new System.Windows.Forms.Button();
      this.btnCerrar = new System.Windows.Forms.Button();
      this.topPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // topPanel
      // 
      this.topPanel.BackColor = System.Drawing.Color.FromArgb(0, 102, 204);
      this.topPanel.Controls.Add(this.btnMinimizar);
      this.topPanel.Controls.Add(this.btnMaximizar);
      this.topPanel.Controls.Add(this.btnCerrar);
      this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
      this.topPanel.Location = new System.Drawing.Point(0, 0);
      this.topPanel.Name = "topPanel";
      this.topPanel.Size = new System.Drawing.Size(120, 50); // Ajustar tamaño del panel
      this.topPanel.TabIndex = 0;
      // 
      // btnMinimizar
      // 
      this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(0, 102, 204);
      this.btnMinimizar.FlatAppearance.BorderSize = 0;
      this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnMinimizar.ForeColor = System.Drawing.Color.White;
      this.btnMinimizar.Location = new System.Drawing.Point(10, 5); // Ajustar ubicación (más arriba)
      this.btnMinimizar.Name = "btnMinimizar";
      this.btnMinimizar.Size = new System.Drawing.Size(30, 30); // Aumentar tamaño del botón
      this.btnMinimizar.TabIndex = 0;
      this.btnMinimizar.Font = new Font("Segoe UI", 14F, FontStyle.Regular); // Aumentar tamaño de fuente
      this.btnMinimizar.Text = "-";
      this.btnMinimizar.UseVisualStyleBackColor = false;
      this.btnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
      // 
      // btnMaximizar
      // 
      this.btnMaximizar.BackColor = System.Drawing.Color.FromArgb(0, 102, 204);
      this.btnMaximizar.FlatAppearance.BorderSize = 0;
      this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnMaximizar.ForeColor = System.Drawing.Color.White;
      this.btnMaximizar.Location = new System.Drawing.Point(50, 5); // Ajustar ubicación (más arriba)
      this.btnMaximizar.Name = "btnMaximizar";
      this.btnMaximizar.Size = new System.Drawing.Size(30, 30); // Aumentar tamaño del botón
      this.btnMaximizar.TabIndex = 1;
      this.btnMaximizar.Font = new Font("Segoe UI", 14F, FontStyle.Regular); // Aumentar tamaño de fuente
      this.btnMaximizar.Text = "⬜";
      this.btnMaximizar.UseVisualStyleBackColor = false;
      this.btnMaximizar.Click += new System.EventHandler(this.BtnMaximizar_Click);
      // 
      // btnCerrar
      // 
      this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(0, 102, 204);
      this.btnCerrar.FlatAppearance.BorderSize = 0;
      this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCerrar.ForeColor = System.Drawing.Color.White;
      this.btnCerrar.Location = new System.Drawing.Point(90, 5); // Ajustar ubicación (más arriba)
      this.btnCerrar.Name = "btnCerrar";
      this.btnCerrar.Size = new System.Drawing.Size(30, 30); // Aumentar tamaño del botón
      this.btnCerrar.TabIndex = 2;
      this.btnCerrar.Font = new Font("Segoe UI", 14F, FontStyle.Regular); // Aumentar tamaño de fuente
      this.btnCerrar.Text = "X";
      this.btnCerrar.UseVisualStyleBackColor = false;
      this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
      // 
      // MinMaxCerrar
      // 
      this.Controls.Add(this.topPanel);
      this.Name = "MinMaxCerrar";
      this.Size = new System.Drawing.Size(120, 50); // Ajustar tamaño del control
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

    private void BtnMaximizar_Click(object sender, EventArgs e)
    {
      Form parentForm = this.FindForm();
      if (parentForm != null)
      {
        if (parentForm.WindowState == FormWindowState.Maximized)
        {
          parentForm.WindowState = FormWindowState.Normal;
        }
        else
        {
          parentForm.WindowState = FormWindowState.Maximized;
        }
      }
    }

    private void BtnCerrar_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }
  }
}
