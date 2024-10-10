using Negocio.Ejuc_Proc_Usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Principal
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            AccesoDatos.Conectar.Conexion con= AccesoDatos.Conectar.Conexion.CrearInstancia();
            

    }

        private void linkRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Principal.Registrarse rg = new Principal.Registrarse();
            rg.Show();
            this.Close(); 
        }

    private void btnIniciarSesion_Click(object sender, EventArgs e)
    {
      string nombre = txtUsuariolg.Text.Trim();
      string contrasena = txtContrasenalg.PasswordText.Trim();

      // Validar que los campos no estén vacíos
      if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(contrasena))
      {
        MessageBox.Show("Todos los campos son obligatorios para poder ingresar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      try
      {
        // Llamar al método de la capa de negocio para validar el usuario
        bool resultado = Negocio.Ejuc_Proc_Usuario.Usuario.ValidarUsuario(nombre, contrasena);

        if (resultado) // Si el usuario es válido
        {
          this.Hide(); // Ocultar el formulario de inicio de sesión
          Principal.Menu mn = new Principal.Menu();
          mn.StartPosition = FormStartPosition.CenterScreen;
          mn.Show(); // Mostrar el menú principal
        }
        else // Si el usuario no es válido
        {
          MessageBox.Show("Nombre de usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
      }
      catch (Exception ex)
      {
        // Manejo de errores y mostrar mensaje al usuario
        MessageBox.Show("Ocurrió un error al ingresar al menú: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

        private void lnkHasOlvidadoContrasena_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecuperarContraseña rcpcontraseña= new RecuperarContraseña();
            rcpcontraseña.StartPosition = FormStartPosition.CenterScreen;
            rcpcontraseña.Show();
            this.Hide();
        }
    }
}
