using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Presentacion.Formularios.CarrerasCursos
{
    public partial class FormularioCarrerasCursos : Form
    {
        public FormularioCarrerasCursos()
        {
            InitializeComponent();
            ListaCarreras();
            dgvCarreras.CellPainting += dgvCarreras_CellPainting;
           AgregarBotonesCarreras();
        }
        private void btnGuardarCarrera_Click(object sender, EventArgs e)
        {
            string carrera = txtNombreCarrera.Text.Trim();
            string descripcion = txtDescripcionCarrera.Text.Trim();
            string resultado = Negocio.Ejecu_Proc_Carreras_Cursos.Carreras.InsertarCarreras(carrera, descripcion);
            MessageBox.Show(resultado);
            ListaCarreras();
        }
        private void dgvCarreras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvCarreras.Columns["btnModificar"].Index && e.RowIndex >= 0)
            {
                int codigocarrera = Convert.ToInt32(dgvCarreras.Rows[e.RowIndex].Cells["Codigo Carrera"].Value);
                CarrerasCursos.FormMoficarCarrera mdf= new CarrerasCursos.FormMoficarCarrera(codigocarrera);
                mdf.CarreraModificada += ListaCarreras;
                mdf.ShowDialog();
            }
            if (e.ColumnIndex == dgvCarreras.Columns["btnEliminar"].Index && e.RowIndex >= 0) 
            {
                var confirmResult = MessageBox.Show("¿Está seguro que desea eliminar esta carrera?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes) 
                {
                    int codigocarrera = Convert.ToInt32(dgvCarreras.Rows[e.RowIndex].Cells["Codigo Carrera"].Value);
                    string resultado = Negocio.Ejecu_Proc_Carreras_Cursos.Carreras.EliminarCarreras(codigocarrera);
                    MessageBox.Show(resultado);
                    ListaCarreras();
                }
            }
        }
        private void dgvCarreras_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && e.RowIndex != dgvCarreras.NewRowIndex)
            {
                // Para la columna "Modificar"
                if (dgvCarreras.Columns[e.ColumnIndex].Name == "btnModificar")
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
                else if (dgvCarreras.Columns[e.ColumnIndex].Name == "btnEliminar")
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
            dgvCarreras.Columns.Add(btnModificar);
            dgvCarreras.Columns.Add(btnEliminar);
        }

        public void ListaCarreras()
        {
            dgvCarreras.DataSource = Negocio.Ejecu_Proc_Carreras_Cursos.Carreras.ListaCarrera();
            dgvCarreras.RowHeadersVisible = false;
        }


       //Estos no sirve se dio click solito 
        private void dgvCarreras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void FormularioCarrerasCursos_Load(object sender, EventArgs e)
        {

        }

        
    }
}
