using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Formularios.Egresados
{
    public partial class FormularioEgresados : Form
    {
        public FormularioEgresados()
        {
            InitializeComponent();
            grbEntrega.Visible = false;
        }

    private void rdbTitulo_CheckedChanged(object sender, EventArgs e)
    {
      grbEntrega.Visible = true;
    }
  }
}
