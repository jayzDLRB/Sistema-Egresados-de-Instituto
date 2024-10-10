using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Elementos
{
    public class RoundedButton : Button
    {
        // Propiedad para definir el radio de las esquinas
        public int BorderRadius { get; set; } = 20;
        private Color _hoverBackColor = ColorTranslator.FromHtml("#004386");
        private Color _pressedBackColor = ColorTranslator.FromHtml("#003366");

        public RoundedButton()
        {
            this.FlatStyle = FlatStyle.Flat; // EL ESTILO ES PLANO
            this.FlatAppearance.BorderSize = 0; // Elimina el borde plano predeterminado
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            // Configurar gráficos para suavizar los bordes
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Crear el rectángulo con esquinas redondeadas
            RectangleF rect = new RectangleF(0, 0, this.Width, this.Height);
            GraphicsPath path = GetRoundedRectPath(rect, BorderRadius);

            // color de fondo uu
            this.Region = new Region(path);
            using (SolidBrush brush = new SolidBrush(this.BackColor))
            {
                pevent.Graphics.FillPath(brush, path);
            }

            // Dibujar el texto centrado en el botón
            TextRenderer.DrawText(pevent.Graphics, this.Text, this.Font, this.ClientRectangle, this.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        private GraphicsPath GetRoundedRectPath(RectangleF rect, int radius)
        {
            float diameter = radius * 2;
            SizeF size = new SizeF(diameter, diameter);
            RectangleF arc = new RectangleF(rect.Location, size);

            GraphicsPath path = new GraphicsPath();

            // Esquina superior izquierda
            path.AddArc(arc, 180, 90);

            // Esquina superior derecha
            arc.X = rect.Right - diameter;
            path.AddArc(arc, 270, 90);

            // Esquina inferior derecha
            arc.Y = rect.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // Esquina inferior izquierda
            arc.X = rect.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            this.BackColor = _hoverBackColor;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.BackColor = ColorTranslator.FromHtml("#0563BB"); // Color predeterminado
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            this.BackColor = _pressedBackColor;
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            this.BackColor = _hoverBackColor;
        }
    }
}
