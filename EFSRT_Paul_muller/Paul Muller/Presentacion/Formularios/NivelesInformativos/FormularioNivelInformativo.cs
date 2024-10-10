using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Formularios.NivelesInformativos
{
    public partial class FormularioNivelInformativo : Form
    {
        public FormularioNivelInformativo()
        {
            InitializeComponent();
            ListaNivelesInformativos();
            dvgNivelInformativo.CellPainting += dvgNivelInformativo_CellPainting;
            AgregarBotonesCarreras();
        }
        private void btnGuardarNivelInformativo_Click(object sender, EventArgs e)
        {
            string nivel=txtNombreNivelInformativo.Text.Trim();
            string descri=txtDescripcionNivelInformativo.Text.Trim();
            string resultado = Negocio.Ejucc_Proc_NivelesInformativos.NivelesInformativos.InsertarNivelInformativo(nivel,descri);
            MessageBox.Show(resultado);
            ListaNivelesInformativos();
        }
        private void dvgNivelInformativo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dvgNivelInformativo.Columns["btnModificar"].Index && e.RowIndex >= 0)
            {
                int codigonivelinformativo = Convert.ToInt32(dvgNivelInformativo.Rows[e.RowIndex].Cells["Codigo Nivel Informativo"].Value);
                NivelesInformativos.FormModificarNivelInformativo mdf = new NivelesInformativos.FormModificarNivelInformativo(codigonivelinformativo);
                mdf.CarreraModificada += ListaNivelesInformativos;
                mdf.ShowDialog();
            }
            if (e.ColumnIndex == dvgNivelInformativo.Columns["btnEliminar"].Index && e.RowIndex >= 0)
            {
                var confirmResult = MessageBox.Show("¿Está seguro que desea eliminar esta carrera?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    int codigonivelinformativo = Convert.ToInt32(dvgNivelInformativo.Rows[e.RowIndex].Cells["Codigo Nivel Informativo"].Value);
                    string resultado = Negocio.Ejucc_Proc_NivelesInformativos.NivelesInformativos.EliminarNivelInformativo(codigonivelinformativo);
                    MessageBox.Show(resultado);
                    ListaNivelesInformativos();
                }
            }
        }
        private void dvgNivelInformativo_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && e.RowIndex != dvgNivelInformativo.NewRowIndex)
            {
                // Para la columna "Modificar"
                if (dvgNivelInformativo.Columns[e.ColumnIndex].Name == "btnModificar")
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    var rect = e.CellBounds;
                    rect.Inflate(-2, -2); // Para que el botón no ocupe toda la celda

                    // Pintar fondo amarillo sin afectar el texto
                    e.Graphics.FillRectangle(new SolidBrush(Color.Yellow), rect);

                    // Pintar el texto encima sin cambiar su color original
                    TextRenderer.DrawText(e.Graphics, "Modificar", e.CellStyle.Font, rect, e.CellStyle.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

                    e.Handled = true; // Indica que hemos manejado completamente el pintado
                }
                // Para la columna "Eliminar"
                else if (dvgNivelInformativo.Columns[e.ColumnIndex].Name == "btnEliminar")
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    var rect = e.CellBounds;
                    rect.Inflate(-2, -2); // Para que el botón no ocupe toda la celda

                    // Pintar fondo rojo sin afectar el texto
                    e.Graphics.FillRectangle(new SolidBrush(Color.Red), rect);

                    // Pintar el texto encima sin cambiar su color original
                    TextRenderer.DrawText(e.Graphics, "Eliminar", e.CellStyle.Font, rect, e.CellStyle.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

                    e.Handled = true; // Indica que hemos manejado completamente el pintado
                }
            }
        }
        public void ListaNivelesInformativos()
        {
            dvgNivelInformativo.DataSource = Negocio.Ejucc_Proc_NivelesInformativos.NivelesInformativos.ListaNivelInformativo();
            dvgNivelInformativo.RowHeadersVisible = false;
        }
        private void AgregarBotonesCarreras()
        {
            // Crear la columna de botón para modificar
            DataGridViewButtonColumn btnModificar = new DataGridViewButtonColumn();
            btnModificar.HeaderText = "Modificar";
            btnModificar.Name = "btnModificar";
            btnModificar.Text = "Modificar";
            btnModificar.UseColumnTextForButtonValue = true;

            // Crear la columna de botón para eliminar
            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.HeaderText = "Eliminar";
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseColumnTextForButtonValue = true;

            // Agregar las columnas de botones al DataGridView
            dvgNivelInformativo.Columns.Add(btnModificar);
            dvgNivelInformativo.Columns.Add(btnEliminar);
        }
    }
}
