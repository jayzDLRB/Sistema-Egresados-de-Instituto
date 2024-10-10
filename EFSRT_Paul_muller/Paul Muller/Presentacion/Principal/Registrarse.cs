using System;
using System.Windows.Forms;

namespace Presentacion.Principal
{
  public partial class Registrarse : Form
  {
    public Registrarse()
    {
      InitializeComponent();
    }

    private void btnEnviar_Click(object sender, EventArgs e)
    {
      // Obtener los valores de los TextBox
      string nombre = txtNombreUsuario.Text.Trim();
      string contrasena = txtContrasena.PasswordText.Trim();
      string correo = txtCorreoElectronico.Text.Trim();

      // Validar que los campos no estén vacíos
      if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(contrasena) || string.IsNullOrEmpty(correo))
      {
        MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      try
      {
        // Llamar al método de la capa de negocio para insertar el usuario
        string resultado = Negocio.Ejuc_Proc_Usuario.Usuario.InsertarUsuarios(nombre, contrasena, correo);

        // Mostrar el resultado de la operación al usuario
        MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      catch (Exception ex)
      {
        // Manejo de errores y mostrar mensaje al usuario
        MessageBox.Show("Ocurrió un error al insertar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void roundedButton2_Click(object sender, EventArgs e)
    {
      Principal.Login lg= new Principal.Login();  
      lg.Show();
      this.Close();
    }
  }
}
