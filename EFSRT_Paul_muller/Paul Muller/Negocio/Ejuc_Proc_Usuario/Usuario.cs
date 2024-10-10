using System;
using System.Windows.Forms;

namespace Negocio.Ejuc_Proc_Usuario
{
    public class Usuario
    {
        // Método para insertar un usuario con validación básica
        public static string InsertarUsuarios(string nomU, string cont, string corr)
        {
            // Validación simple de los parámetros
            if (string.IsNullOrWhiteSpace(nomU) || string.IsNullOrWhiteSpace(cont) || string.IsNullOrWhiteSpace(corr))
            {
                return "Error: Todos los campos son obligatorios.";
            }

            try
            {
                // Instancia de la clase de acceso a datos
                AccesoDatos.Usuario.Usuarios insertar = new AccesoDatos.Usuario.Usuarios();

                // Creación del objeto entidad de usuarios
                Entidades.Usuarios.EntidadesUsuarios objE = new Entidades.Usuarios.EntidadesUsuarios();
                objE.NombreUsuario = nomU;
                objE.Contrasena = cont;
                objE.CorreoElectronico = corr;

                // Llamada al método que inserta el usuario en la base de datos
                return insertar.ProcInsertarUsuarios(objE);
            }
            catch (Exception ex)
            {
                // Manejo de excepciones a nivel de negocio
                return $"Error al insertar usuario: {ex.Message}";
            }
        }
        public static bool ValidarUsuario(string nomU, string cont)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(nomU) || string.IsNullOrWhiteSpace(cont))
            {
                System.Windows.Forms.MessageBox.Show("Completa todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Retorna false si hay campos vacíos
            }

            try
            {
                // Crear una instancia de Usuarios
                AccesoDatos.Usuario.Usuarios usuario = new AccesoDatos.Usuario.Usuarios();
                Entidades.Usuarios.EntidadesUsuarios obtEv = new Entidades.Usuarios.EntidadesUsuarios
                {
                    NombreUsuario = nomU,
                    Contrasena = cont
                };

                // Llamar al método que valida el usuario
                bool valid = usuario.ProcValidarUsuarios(obtEv);

                // Mostrar el resultado en un MessageBox (opcional)
                //if (valid)
                //{
                //  System.Windows.Forms.MessageBox.Show("Usuario válido", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else
                //{
                //  System.Windows.Forms.MessageBox.Show("Usuario no válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}

                return valid; // Retorna el resultado de la validación
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                System.Windows.Forms.MessageBox.Show("Ocurrió un error al validar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Retorna false en caso de error
            }
        }

    }
}
