using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Formularios.CarrerasCursos
{
    public partial class FormMoficarCarrera : Form
    {
        public int CodigoCarrera { get; set; }
        public FormMoficarCarrera(int codigoCarrera)
        {
            InitializeComponent();
            CodigoCarrera = codigoCarrera;
        }

        private void FormMoficarCarrera_Load(object sender, EventArgs e)
        {
            CargarDatosCarrera();
            
        }
        public event Action CarreraModificada;
        private void btnModifcar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigoModificar.Text);
            string nombrecarrer = txtnomcarr.Text;
            string descrip = txtdescrip.Text;
            string mdf = Negocio.Ejecu_Proc_Carreras_Cursos.Carreras.ModificarCarreras(codigo, nombrecarrer,descrip);
            MessageBox.Show(mdf);
            CarreraModificada?.Invoke();
            this.Hide();
        }
        public string CargarDatosCarrera()
        {
 
            string resultado = Negocio.Ejecu_Proc_Carreras_Cursos.Carreras.ConsultarCarreras(CodigoCarrera,txtCodigoModificar,txtnomcarr, txtdescrip);
            return resultado;
        }
    }
}
