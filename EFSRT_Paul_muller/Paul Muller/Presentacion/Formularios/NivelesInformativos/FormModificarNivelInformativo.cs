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
    public partial class FormModificarNivelInformativo : Form
    {
        public int CodigoNivelInformativo { get; set; }
        public FormModificarNivelInformativo(int codigonivelinformativo)
        {
            InitializeComponent();
            CodigoNivelInformativo= codigonivelinformativo;
        }
        public event Action CarreraModificada;
        private void FormModificarNivelInformativo_Load(object sender, EventArgs e)
        {
            CargarDatosCarrera();
        }

        private void btnModifcarNLI_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigoModificarNivelInformativo.Text);
            string nombreNl = txtNomNivel.Text;
            string descripNL = txtDescripNl.Text;
            string mdf = Negocio.Ejucc_Proc_NivelesInformativos.NivelesInformativos.ModificarNivelInformativo(codigo, nombreNl, descripNL);
            MessageBox.Show(mdf);
            CarreraModificada?.Invoke();
            this.Hide();
        }
        public string CargarDatosCarrera()
        {

            string resultado = Negocio.Ejucc_Proc_NivelesInformativos.NivelesInformativos.ConsultarNivelInformativo(CodigoNivelInformativo, txtCodigoModificarNivelInformativo, txtNomNivel, txtDescripNl);
            return resultado;
        }
    }
}
