using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Elementos
{
  public class CustomUsuarioTextBox : UserControl
  {
    protected TextBox textBox;
    protected Label placeholderLabel;
    protected PictureBox icon;
    protected Panel underlinePanel;

    public CustomUsuarioTextBox()
    {
      // Inicialización de los componentes
      textBox = new TextBox
      {
        BorderStyle = BorderStyle.None,
        Font = new Font("Segoe UI", 10),
        Location = new Point(30, 5),
        Width = 200
      };

      placeholderLabel = new Label
      {
        Text = "Usuario",
        Font = new Font("Segoe UI", 10),
        ForeColor = Color.Gray,
        Location = new Point(30, 5),
        AutoSize = false,
        Width = 200,
        Height = textBox.Height,
        TextAlign = ContentAlignment.MiddleLeft
      };

      icon = new PictureBox
      {
        Image = Properties.Resources.UserIconGray, // Imagen del ícono gris
        Location = new Point(5, 5),
        Size = new Size(20, 20),
        SizeMode = PictureBoxSizeMode.StretchImage
      };

      underlinePanel = new Panel
      {
        BackColor = Color.Gray,
        Height = 2,
        Dock = DockStyle.Bottom
      };

      textBox.GotFocus += TextBox_GotFocus;
      textBox.LostFocus += TextBox_LostFocus;

      Controls.Add(placeholderLabel);
      Controls.Add(textBox);
      Controls.Add(icon);
      Controls.Add(underlinePanel);

      placeholderLabel.Click += (s, e) => { textBox.Focus(); };
    }

    // Aquí se define la propiedad Text
    public new string Text
    {
      get { return textBox.Text; }
      set { textBox.Text = value; }
    }

    protected virtual void TextBox_GotFocus(object sender, EventArgs e)
    {
      placeholderLabel.Visible = false;
      underlinePanel.BackColor = ColorTranslator.FromHtml("#0563BB");
      icon.Image = Properties.Resources.UserIconBlue;
    }

    protected virtual void TextBox_LostFocus(object sender, EventArgs e)
    {
      if (string.IsNullOrWhiteSpace(textBox.Text))
      {
        placeholderLabel.Visible = true;
        underlinePanel.BackColor = Color.Gray;
        icon.Image = Properties.Resources.UserIconGray;
      }
    }
  }
}
