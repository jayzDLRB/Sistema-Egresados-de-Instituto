using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Elementos
{
  public class CustomPasswordTextBox : UserControl
  {
    protected TextBox textBox;
    protected Label placeholderLabel;
    protected PictureBox icon;
    protected PictureBox visibilityToggleIcon; // Icono para alternar visibilidad
    protected Panel underlinePanel;
    private bool isPasswordVisible = false; // Estado de visibilidad de la contraseña

    public CustomPasswordTextBox()
    {
      textBox = new TextBox
      {
        BorderStyle = BorderStyle.None,
        Font = new Font("Segoe UI", 10),
        Location = new Point(30, 5),
        Width = 160,
        UseSystemPasswordChar = true // Muestra puntos
      };

      placeholderLabel = new Label
      {
        Text = "Password",
        Font = new Font("Segoe UI", 10),
        ForeColor = Color.Gray,
        Location = new Point(30, 5),
        AutoSize = false,
        Width = 160,
        Height = textBox.Height,
        TextAlign = ContentAlignment.MiddleLeft
      };

      icon = new PictureBox
      {
        Image = Properties.Resources.PasswordIconGray, // Imagen del ícono gris
        Location = new Point(5, 5),
        Size = new Size(20, 20),
        SizeMode = PictureBoxSizeMode.StretchImage
      };

      visibilityToggleIcon = new PictureBox
      {
        Image = Properties.Resources.cerrar_ojo, // Imagen del ícono de ojo cerrado
        Location = new Point(320, 5),
        Size = new Size(20, 20),
        SizeMode = PictureBoxSizeMode.StretchImage,
        Cursor = Cursors.Hand
      };

      underlinePanel = new Panel
      {
        BackColor = Color.Gray,
        Height = 2,
        Dock = DockStyle.Bottom
      };

      textBox.GotFocus += TextBox_GotFocus;
      textBox.LostFocus += TextBox_LostFocus;

      visibilityToggleIcon.Click += VisibilityToggleIcon_Click;

      Controls.Add(placeholderLabel);
      Controls.Add(textBox);
      Controls.Add(icon);
      Controls.Add(visibilityToggleIcon);
      Controls.Add(underlinePanel);

      placeholderLabel.Click += (s, e) => { textBox.Focus(); };
    }

    public string PasswordText
    {
      get { return textBox.Text; }
      set { textBox.Text = value; }
    }

    protected virtual void TextBox_GotFocus(object sender, EventArgs e)
    {
      placeholderLabel.Visible = false;
      underlinePanel.BackColor = ColorTranslator.FromHtml("#0563BB");
      icon.Image = Properties.Resources.PasswordIconBlue;
    }

    protected virtual void TextBox_LostFocus(object sender, EventArgs e)
    {
      if (string.IsNullOrWhiteSpace(textBox.Text))
      {
        placeholderLabel.Visible = true;
        underlinePanel.BackColor = Color.Gray;
        icon.Image = Properties.Resources.PasswordIconGray;
      }
    }

    private void VisibilityToggleIcon_Click(object sender, EventArgs e)
    {
      isPasswordVisible = !isPasswordVisible;
      textBox.UseSystemPasswordChar = !isPasswordVisible;
      visibilityToggleIcon.Image = isPasswordVisible
          ? Properties.Resources.ojoAzul // Imagen del ícono de ojo abierto
          : Properties.Resources.cerrar_ojo; // Imagen del ícono de ojo cerrado
    }
  }
}
